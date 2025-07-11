using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MODELO;
using CAPA_COMUN;
using CAPA_COMUN.Cache;

namespace VISTA
{
    public partial class Form_inicio : Form
    {
        CONTROLADORA.Controladora_usuarios contro_usu = new CONTROLADORA.Controladora_usuarios();

        public Form_inicio()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Form_inicio_Load(object sender, EventArgs e)
        {
            bnt_dejarVer.Visible = false;
            label_error.Visible = false;
            pictureBox_error.Visible = false;
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "USUARIO")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = SystemColors.AppWorkspace;
            }

        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "USUARIO";
                txt_usuario.ForeColor = SystemColors.AppWorkspace;
            }

        }

        private void txt_contra_Enter(object sender, EventArgs e)
        {
            if (txt_contra.Text == "CONTRASEÑA")
            {
                txt_contra.Text = "";
                txt_contra.ForeColor = SystemColors.AppWorkspace;
                txt_contra.UseSystemPasswordChar = true;
            }
        }

        private void txt_contra_Leave(object sender, EventArgs e)
        {
            if (txt_contra.Text == "")
            {
                txt_contra.Text = "CONTRASEÑA";
                txt_contra.ForeColor = SystemColors.AppWorkspace;
                txt_contra.UseSystemPasswordChar = false;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form_inicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            txt_contra.UseSystemPasswordChar = false;
            btn_ver.Visible = false;
            bnt_dejarVer.Visible = true;
        }

        private void bnt_dejarVer_Click(object sender, EventArgs e)
        {
            txt_contra.UseSystemPasswordChar = true;
            bnt_dejarVer.Visible = false;
            btn_ver.Visible = true;
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "USUARIO" && txt_contra.Text == "CONTRASEÑA")
            {
                MostrarError("Por favor, complete todos los campos.");
            }
            else if (txt_usuario.Text == "USUARIO")
            {
                MostrarError("Por favor, ingrese el nombre de usuario.");
            }
            else if (txt_contra.Text == "CONTRASEÑA")
            {
                MostrarError("Por favor, ingrese la contraseña.");
            }
            else
            {
                var usuario = contro_usu.ValidarLogin(txt_usuario.Text, txt_contra.Text);

                if (usuario != null)
                {
                    
                    UsuarioCache.UsuarioId = usuario.UsuarioId;
                    UsuarioCache.UsuarioNombre = usuario.Nombre_usuario;
                    UsuarioCache.UsuarioEmail = usuario.Email;


                    Form_principal form_principal = new Form_principal();
                    form_principal.Show();
                    form_principal.FormClosed += CerraSesion;

                    this.Hide();
                }
                else
                {
                    MostrarError("Usuario o contraseña incorrectos.\nIntente otra vez.");
                    txt_contra.Text = "CONTRASEÑA";
                    txt_usuario.Text = "USUARIO";
                    txt_contra.UseSystemPasswordChar = false;
                }
                
            }


        }

        private void MostrarError(string msj)
        {
            label_error.Text = msj;
            label_error.Visible = true;
            pictureBox_error.Visible = true;
        }

        private void CerraSesion(object sender, FormClosedEventArgs e)
        {
            txt_contra.Text = "CONTRASEÑA";
            txt_usuario.Text = "USUARIO";
            label_error.Visible = false;
            pictureBox_error.Visible = false;
            txt_contra.UseSystemPasswordChar = false;
            this.Show();
            
        }
    }
}
