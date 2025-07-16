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
    public partial class Form_usuarios_abm : Form
    {
        CONTROLADORA.Controladora_usuarios contro_us = new CONTROLADORA.Controladora_usuarios();
        private string vari;
        private int indice = 0;

        public Form_usuarios_abm()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_LISTA();
        }

        private void Form_usuarios_abm_Load(object sender, EventArgs e)
        {
            groupBox_carga.Enabled = false;

            cb_filtro.Items.Add("Administrador");
            cb_filtro.Items.Add("Administración");
            cb_filtro.Items.Add("Finanzas");
            cb_filtro.Items.Add("Gerencia");

            cb_tipoUsuario.Items.Add("Administrador");
            cb_tipoUsuario.Items.Add("Administración");
            cb_tipoUsuario.Items.Add("Finanzas");
            cb_tipoUsuario.Items.Add("Gerencia");



        }

        private void ARMA_GRILLA()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = contro_us.ListarUsuarios();
        }

        private void MODO_LISTA()
        {
            groupBox_carga.Enabled = false;
            groupBox_lista.Enabled = true;
        }

        private void MODO_CARGA()
        {
            groupBox_carga.Enabled = true;
            groupBox_lista.Enabled = false;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            vari = "A";
            MODO_CARGA();
        }

        private void LIMPIAR()
        {
            txt_email.Text = "";
            txt_contraseña.Text = "";
            txt_nomUsuario.Text = "";
            cb_tipoUsuario.Text = "";
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MODELO.Usuario usuario = null;

            #region VALIDACIONES

            if (string.IsNullOrWhiteSpace(cb_tipoUsuario.Text))
            {
                MessageBox.Show("Seleccione un tipo de usuario.", "ERROR");
                return;
            }

            if (cb_tipoUsuario.Text != "Administrador" && cb_tipoUsuario.Text != "Administración" && cb_tipoUsuario.Text != "Finanzas" && cb_tipoUsuario.Text != "Gerencia")
            {
                MessageBox.Show("Seleccione un tipo de usuario posible.\nNo ingrese usuario que no existen. ", "ERROR");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_nomUsuario.Text))
            {
                MessageBox.Show("Ingrese el ID del usuario.", "ERROR");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_contraseña.Text))
            {
                MessageBox.Show("Ingrese una contraseña para el usuario.", "ERROR");
                return;
            }


            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Ingrese el email del usuario.", "ERROR");
                return;
            }

            if (!ValidarMail(txt_email.Text))
            {
                MessageBox.Show("Ingrese un email posible para el usuario.\nEJ: Ignaciocarignano@vitastays.com", "ERROR");
                return;
            }

            #endregion

            if (vari == "A")
            {
                if (!contro_us.ValidarUsuario(txt_email.Text, txt_nomUsuario.Text, 0))
                {
                    usuario = contro_us.CrearUsuarioFactory(cb_tipoUsuario.Text, txt_nomUsuario.Text, txt_contraseña.Text, txt_email.Text);

                    try
                    {
                        string resultado = contro_us.AgregarUsuario(usuario);
                        MessageBox.Show(resultado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el usuario: " + ex.Message, "ERROR");
                    }

                }
                else
                {
                    MessageBox.Show("Este usuario ya existe\n\nIntente con otro email o nombre de usuario", "AVISO");
                    return;
                }
            }

            if (vari == "M")
            {
                usuario = contro_us.ListarUsuarios()[indice];

                if (!contro_us.ValidarUsuario(txt_email.Text, txt_nomUsuario.Text, usuario.UsuarioId))
                {
                    usuario.Nombre_usuario = txt_nomUsuario.Text;
                    usuario.Contraseña = txt_contraseña.Text;
                    usuario.Email = txt_email.Text;

                    try
                    {
                        string resultado = contro_us.ModificarUsuario(usuario);
                        MessageBox.Show(resultado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error en el sistema: " + ex.Message, "ERROR");
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Este usuario ya existe\n\nIntente con otro email o nombre de usuario", "AVISO");
                    return;
                }

            }
            
            

            ARMA_GRILLA();
            MODO_LISTA();
            LIMPIAR();

        }

        private bool ValidarMail(string email)
        {
            if (email.Length < 6)
                return false;

            if (email.IndexOf('@') == -1 || email.IndexOf('@') != email.LastIndexOf('@'))
                return false;

            string[] partes = email.Split('@');

            if (partes.Length != 2)
                return false;

            string usuario = partes[0];
            string dominioCompleto = partes[1];

            if (string.IsNullOrWhiteSpace(usuario) || usuario.Contains(" "))
                return false;

            if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9._-]+$"))
                return false;

            return (dominioCompleto.Equals("vitastays.com", StringComparison.OrdinalIgnoreCase));

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario", "Error");
                return;
            }

            MODELO.Usuario usuario;
            vari = "M";

            usuario = contro_us.ListarUsuarios()[indice];

            txt_nomUsuario.Text = usuario.Nombre_usuario;
            txt_contraseña.Text = usuario.Contraseña;
            txt_email.Text = usuario.Email;

            MODO_CARGA();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell == null)
            {
                MessageBox.Show("Seleccione un usuario", "ERROR");
                return;
            }

            indice = dataGridView.CurrentRow.Index;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario", "Error");
                return;
            }

            MODELO.Usuario usuario;

            usuario = contro_us.ListarUsuarios()[indice];

            DialogResult result = MessageBox.Show($"Está seguro que desea eliminar al usuario:\n\nNombre: {usuario.Nombre_usuario}\n\nEmail: {usuario.Email}", "AVISO", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string respuesta = contro_us.EliminarUsuario(usuario);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en el sistema: " + ex.Message, "ERROR");
                    return;
                }
            }

            ARMA_GRILLA();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MODO_LISTA();
            LIMPIAR();
        }
    }
}
