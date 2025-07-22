using CAPA_COMUN.Cache;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class form_misDatosAjustes : Form
    {
        CONTROLADORA.Controladora_usuarios contro_us = new CONTROLADORA.Controladora_usuarios();
        
        public form_misDatosAjustes()
        {
            InitializeComponent();
            CargarDatos();
            Ocultar();
        }

        private void form_misDatosAjustes_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            MODELO.Usuario usuario = contro_us.ObtenerUsuarioId(UsuarioCache.UsuarioId);

            listbox_permisos.Items.Clear();

            txt_nombre.Text = usuario.Nombre;
            txt_apellido.Text = usuario.Apellido;
            txt_usuario.Text = usuario.Nombre_usuario;
            txt_email.Text = usuario.Email;
            txt_grupo.Text = usuario.Grupo.Nombre;
            listbox_permisos.Items.AddRange(usuario.Grupo.Permisos.ToArray());
        }

        private void Ocultar()
        {
            txt_grupo.Enabled = false;
            txt_usuario.Enabled = false;
            listbox_permisos.Enabled = false;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MODELO.Usuario usuario = contro_us.ObtenerUsuarioId(UsuarioCache.UsuarioId);

            if (usuario == null)
            {
                MessageBox.Show("El usuario no está registrado correctamente.");
                return;
            }


            if (!contro_us.ValidarUsuario(txt_email.Text, txt_usuario.Text, usuario.UsuarioId))
            {
                usuario.Nombre = txt_nombre.Text;
                usuario.Apellido = txt_apellido.Text;
                usuario.Email = txt_email.Text;


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
                MessageBox.Show("Este usuario ya existe\n\nIntente con otro email", "AVISO");
                return;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
