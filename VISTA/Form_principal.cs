using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
            OcultarSubmenu();
            btn_restaurar.Visible = false;
        }

        #region Mover form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel_forms_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel_menuLateral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void Form_principal_Load(object sender, EventArgs e)
        {

        }

        private void OcultarSubmenu()
        {
            panel_ABM.Visible = false;
        }

        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btn_ABM_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panel_ABM);
        }

        private void btn_cabañas_alquiler_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }

        private void btn_informes_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }

        private Form formActual = null;
        private void AbrirForms(Form formNuevo)
        {
            if (formActual != null)
            {
                formActual.Close();
            }

            formActual = formNuevo;

            formNuevo.TopLevel = false;
            formNuevo.FormBorderStyle = FormBorderStyle.None;
            formNuevo.Dock = DockStyle.Fill;
            panel_forms.Controls.Add(formNuevo);
            panel_forms.Tag = formNuevo;
            formNuevo.BringToFront();

            formNuevo.Show();

        }

        private void btn_ABM_usuarios_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_usuarios_abm());
        }

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_restaurar.Visible = true;
            btn_maximizar.Visible = false;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }
    }
}

