using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VISTA
{
    public partial class Form_clientes_abm : Form
    {
        CONTROLADORA.Controladora_clientes contro_cli = new CONTROLADORA.Controladora_clientes();
        string vari;
        int indice;
        string variF = "";
        private List<Cliente> listaClientesFiltro = new List<Cliente>();
        public Form_clientes_abm()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_LISTA();
            btn_quitarFiltro.Enabled = false;
        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var cliente = contro_cli.ListarClientes()
                .Select(c => new
                {
                    c.ClienteId,
                    Nombre = c.Nombre + " " + c.Apellido,
                    c.Dni,
                    c.Email,
                    c.Telefono
                }).ToList();

            dataGridView1.DataSource = cliente;

        }

        private void MODO_LISTA()
        {
            groupBox_carga.Enabled = false;
            groupBox_grilla.Enabled = true;
        }

        private void MODO_CARGA()
        {
            groupBox_carga.Enabled = true;
            groupBox_grilla.Enabled = false;
        }

        private void LIMPIAR()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_dni.Text = "";
            txt_email.Text = "";
            txt_telefono.Text = "";
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente.", "Error");
                return;
            }

            indice = dataGridView1.CurrentRow.Index;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            vari = "A";

            MODO_CARGA();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente.", "Error");
                return;
            }

            vari = "M";
            MODELO.Cliente cliente;


            if (variF == "")
            {
                cliente = contro_cli.ListarClientes()[indice];
            }
            else
            {
                 cliente = listaClientesFiltro[indice];
            }

            txt_nombre.Text = cliente.Nombre;
            txt_apellido.Text = cliente.Apellido;
            txt_dni.Text = cliente.Dni;
            txt_email.Text = cliente.Email;
            txt_telefono.Text = cliente.Telefono;

            MODO_CARGA();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente.", "Error");
                return;
            }

            MODELO.Cliente cliente;

            if (variF == "")
            {
                cliente = contro_cli.ListarClientes()[indice];
            }
            else
            {
                cliente = listaClientesFiltro[indice];
            }

            DialogResult resultado = MessageBox.Show($"Está seguro que desea eliminar al cliente:\n\nNombre: {cliente.Nombre + " " + cliente.Apellido}\n\nDNI: {cliente.Dni}\n\nEmail: {cliente.Email}\n\nTelefono: {cliente.Telefono}", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string respuesta = contro_cli.EliminarCliente(cliente);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente:  " + ex.Message, "ERROR");
                    return;
                }
            }

            if (variF == "")
            {
                ARMA_GRILLA();
            }
            else
            {
                FILTRAR();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MODELO.Cliente cliente = null;

            #region VALIDACIONES

            if (string.IsNullOrWhiteSpace(txt_dni.Text))
            {
                MessageBox.Show("Ingrese el DNI del cliente.", "Error");
                return;
            }

            if (!ValidaDni(txt_dni.Text))
            {
                MessageBox.Show("El DNI debe contener entre 7 y 8 dígitos.", "Error");
                return;
            }


            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_apellido.Text))
            {
                MessageBox.Show("Ingrese el apellido del cliente.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Ingrese el email del cliente.", "Error");
                return;
            }

            if (!ValidaEmial(txt_email.Text))
            {
                MessageBox.Show("El email ingresado no es válido. Ingrese un email valido\n\nEjemplo: Ignaciocarignano@gmail.com", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_telefono.Text))
            {
                MessageBox.Show("Ingrese el numero de telefono del cliente.", "Error");
                return;
            }

            if(!ValidaTelefono(txt_telefono.Text))
            {
                MessageBox.Show("El número de teléfono debe contener solo números y tener entre 6 y 15 dígitos.", "Error");
                return;
            }


            #endregion

            if (vari == "A")
            {
                if(!contro_cli.ValidaCliente(txt_dni.Text, txt_email.Text, 0))
                {
                    cliente = contro_cli.CrearCliente(txt_nombre.Text, txt_apellido.Text, txt_dni.Text, txt_email.Text, txt_telefono.Text);

                    try
                    {
                        string resultado = contro_cli.AgregarCliente(cliente);
                        MessageBox.Show(resultado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el cliente:  " + ex.Message, "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Este cliente ya existe\n\nIntente con otro email o numero de DNI", "AVISO");
                    return;
                }
            }

            if (vari == "M")
            {

                if (variF == "")
                {
                    cliente = contro_cli.ListarClientes()[indice];
                }
                else
                {
                    cliente=listaClientesFiltro[indice];
                }

                if(!contro_cli.ValidaCliente(txt_dni.Text, txt_email.Text, cliente.ClienteId))
                {
                    cliente.Nombre = txt_nombre.Text;
                    cliente.Apellido= txt_apellido.Text;
                    cliente.Dni = txt_dni.Text;
                    cliente.Email = txt_email.Text;
                    cliente.Telefono = txt_telefono.Text;

                    try
                    {
                        string resultado = contro_cli.ModificarCliente(cliente);
                        MessageBox.Show(resultado);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar el cliente:  " + ex.Message, "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Este cliente ya existe\n\nIntente con otro email o numero de DNI", "AVISO");
                    return;
                }
            }

            if (variF == "")
            {
                ARMA_GRILLA();
            }
            else
            {
                FILTRAR();
            }   
            LIMPIAR();
            MODO_LISTA();
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MODO_LISTA();
            LIMPIAR();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            variF = "F";

            btn_quitarFiltro.Enabled = true;

            FILTRAR();

        }

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            txt_dniFiltro.Clear();
            txt_nombreFiltro.Clear();
            txt_apellidoFiltro.Clear();

            ARMA_GRILLA();

            variF = "";

            btn_quitarFiltro.Enabled = false;
        }

        private bool ValidaEmial(string email)
        {
            if (email.IndexOf('@') == -1 || email.IndexOf('@') != email.LastIndexOf('@'))
                return false;

            string[] partes = email.Split('@');

            if (partes.Length != 2)
                return false;

            string usuario = partes[0];
            string dominio = partes[1];

            if (string.IsNullOrWhiteSpace(usuario) || usuario.Contains(" "))
                return false;

            if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9._-]+$"))
                return false;

            if (!dominio.Contains('.'))
                return false;

            return true;
        }

        private bool ValidaTelefono(string telefono)
        {
            string limpio = telefono.Replace(" ", "").Replace("-", "");

            return Regex.IsMatch(limpio, @"^\d{6,15}$");
        }

        private bool ValidaDni(string dni)
        {

            return Regex.IsMatch(dni, @"^\d{7,8}$");
        }

        private void FILTRAR()
        {
            dataGridView1.DataSource = null;

            string dniFiltro = txt_dniFiltro.Text;
            string nombreFiltro = txt_nombreFiltro.Text.Trim().ToLower();
            string apellidoFiltro = txt_apellidoFiltro.Text.Trim().ToLower();

            listaClientesFiltro = contro_cli.ListarClientes()
                .Where(c =>
                (string.IsNullOrEmpty(dniFiltro) || c.Dni.Contains(dniFiltro)) &&
                (string.IsNullOrEmpty(nombreFiltro) || c.Nombre.ToLower().Contains(nombreFiltro)) &&
                (string.IsNullOrEmpty(apellidoFiltro) || c.Apellido.ToLower().Contains(apellidoFiltro))
                ).ToList();

            var datosAmostrar = listaClientesFiltro
            .Select(c => new
            {
                c.ClienteId,
                Nombre = c.Nombre + " " + c.Apellido,
                c.Dni,
                c.Email,
                c.Telefono
            }).ToList();

            dataGridView1.DataSource = datosAmostrar;

        }

    }
}
