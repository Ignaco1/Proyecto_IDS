using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        CONTROLADORA.Controladora_grupos contro_grup = new CONTROLADORA.Controladora_grupos();
        private string vari = "";
        private int indice = 0;
        private string variF = "";
        private List<Usuario> listaUsuariosFiltro = new List<Usuario>();

        public Form_usuarios_abm()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_LISTA();
            btn_quitarFiltro.Enabled = false;
        }

        private void Form_usuarios_abm_Load(object sender, EventArgs e)
        {
            cb_tipoUsuario.Items.Clear();
            cb_tipoFiltro.Items.Clear();

            var grupos = contro_grup.ListarGrupos();

            foreach (var grupo in grupos)
            {
                cb_tipoUsuario.Items.Add(grupo.Nombre);
                cb_tipoFiltro.Items.Add(grupo.Nombre);
            }

        }

        private void ARMA_GRILLA()
        {

            dataGridView.DataSource = null;

            var usuarios = contro_us.ListarUsuarios()
            .Select(u => new
            {
                u.UsuarioId,
                Nombre = u.Nombre + " " + u.Apellido,
                Nombre_de_usuario = u.Nombre_usuario,
                u.Email,
                Grupo = u.Grupo?.Nombre ?? "Sin grupo"

            }).ToList();

            dataGridView.DataSource = usuarios;
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
            txt_usuario.Text = "";
            txt_apellido.Text = "";
            txt_nombre.Text = "";
            cb_tipoUsuario.Text = "";
            txt_email.Text = "";
            txt_contraseña.Text = "";
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MODELO.Usuario usuario = null;

            #region VALIDACIONES

            if (string.IsNullOrWhiteSpace(cb_tipoUsuario.Text))
            {
                MessageBox.Show("Seleccione un tipo de usuario.", "Error");
                return;
            }

            var grupoSeleccionado = contro_grup.ObtenerGrupoPorNombre(cb_tipoUsuario.Text);

            if (grupoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un tipo de usuario posible.\nNo ingrese usuarios que no existen. ", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del usuario.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_apellido.Text))
            {
                MessageBox.Show("Ingrese el apellido del usuario.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_usuario.Text))
            {
                MessageBox.Show("Ingrese el usuario.", "Error");
                return;
            }

            if (txt_usuario.Text.Length < 4 || txt_usuario.Text.Contains(" "))
            {
                MessageBox.Show("El Id de usuario debe tener al menos 4 caracteres y no contener espacios.", "Error");
                return;
            }

            //if (!ValidarMail(txt_email.Text))
            //{
            //    MessageBox.Show("Ingrese un email posible para el usuario.\nEJ: Ignaciocarignano@vitastays.com", "Error");
            //    return;
            //}

            if (string.IsNullOrWhiteSpace(txt_contraseña.Text))
            {
                MessageBox.Show("Ingrese una contraseña para el usuario.", "Error");
                return;
            }

            if (txt_contraseña.Text.Length < 6 || !txt_contraseña.Text.Any(char.IsLetter) || !txt_contraseña.Text.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres, incluyendo letras y números.", "Error");
                return;
            }




            #endregion

            if (vari == "A")
            {
                if (!contro_us.ValidarUsuario(txt_email.Text, txt_usuario.Text, 0))
                {
                    usuario = contro_us.CrearUsuario(cb_tipoUsuario.Text, txt_nombre.Text, txt_apellido.Text, txt_usuario.Text, txt_contraseña.Text, txt_email.Text);

                    try
                    {
                        string resultado = contro_us.AgregarUsuario(usuario);
                        MessageBox.Show(resultado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el usuario:  " + ex.Message, "ERROR");
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
                if (variF == "F")
                {
                    usuario = listaUsuariosFiltro[indice];
                }
                else
                {
                    usuario = contro_us.ListarUsuarios()[indice];
                }

                usuario.Nombre = txt_nombre.Text;
                usuario.Apellido = txt_apellido.Text;
                usuario.Nombre_usuario = txt_usuario.Text;
                usuario.Contraseña = txt_contraseña.Text;
                usuario.Email = txt_email.Text;

                usuario.GrupoId = grupoSeleccionado.GrupoId;

                if (!contro_us.ValidarUsuario(txt_email.Text, txt_usuario.Text, usuario.UsuarioId))
                {

                    try
                    {
                        string resultado = contro_us.ModificarUsuario(usuario);
                        MessageBox.Show(resultado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar el usuario:  " + ex.Message, "ERROR");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Este usuario ya existe\n\nIntente con otro email o usuario", "AVISO");
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
            MODO_LISTA();
            LIMPIAR();
            txt_contraseña.Enabled = true;

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
                MessageBox.Show("Seleccione un usuario.", "Error");
                return;
            }

            MODELO.Usuario usuario;
            vari = "M";

            if (variF == "F")
            {
                usuario = listaUsuariosFiltro[indice];
            }
            else
            {
                usuario = contro_us.ListarUsuarios()[indice];
            }

            cb_tipoUsuario.Text = usuario.Grupo?.Nombre;
            txt_nombre.Text = usuario.Nombre;
            txt_apellido.Text = usuario.Apellido;
            txt_usuario.Text = usuario.Nombre_usuario;
            txt_email.Text = usuario.Email;

            txt_contraseña.Text = usuario.Contraseña;
            //txt_contraseña.Enabled = false;

            MODO_CARGA();

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell == null)
            {
                MessageBox.Show("Seleccione un usuario.", "ERROR");
                return;
            }

            indice = dataGridView.CurrentRow.Index;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario.", "Error");
                return;
            }

            MODELO.Usuario usuario;

            if (variF == "F")
            {
                usuario = listaUsuariosFiltro[indice];
            }
            else
            {
                usuario = contro_us.ListarUsuarios()[indice];
            }

            DialogResult result = MessageBox.Show($"Está seguro que desea eliminar al usuario:\n\nNombre: {usuario.Nombre + " " + usuario.Apellido}\n\nNombre de usuario: {usuario.Nombre_usuario}\n\nEmail: {usuario.Email}\n\nGrupo: {usuario.Grupo.Nombre}", "AVISO", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string respuesta = contro_us.EliminarUsuario(usuario);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario:  " + ex.Message, "ERROR");
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
            cb_tipoFiltro.SelectedIndex = -1;
            txt_nombreFiltro.Clear();
            txt_apellidoFiltro.Clear();
            ARMA_GRILLA();

            btn_quitarFiltro.Enabled = false;
            variF = "";
        }

        private void FILTRAR()
        {
            dataGridView.DataSource = null;

            string tipoUsuarioFiltro = cb_tipoFiltro.Text;
            string nombreFiltro = txt_nombreFiltro.Text.Trim().ToLower();
            string apellidoFiltro = txt_apellidoFiltro.Text.Trim().ToLower();

            listaUsuariosFiltro = contro_us.ListarUsuarios()
                .Where(u =>
                (string.IsNullOrEmpty(tipoUsuarioFiltro) || u.Grupo?.Nombre == tipoUsuarioFiltro) &&
                (string.IsNullOrEmpty(nombreFiltro) || u.Nombre.ToLower().Contains(nombreFiltro)) &&
                (string.IsNullOrEmpty(apellidoFiltro) || u.Apellido.ToLower().Contains(apellidoFiltro))
                ).ToList();

            var datosamostrar = listaUsuariosFiltro
            .Select(u => new
            {
                u.UsuarioId,
                Nombre = u.Nombre + " " + u.Apellido,
                Nombre_de_usuario = u.Nombre_usuario,
                u.Email,
                u.GrupoId,
                Grupo = u.Grupo?.Nombre ?? "Sin grupo"

            }).ToList();

            dataGridView.DataSource = datosamostrar;

        }
    }
}
