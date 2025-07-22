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
    public partial class Form_ajustesUsuario : Form
    {
        public Form_ajustesUsuario()
        {
            InitializeComponent();
        }

        private void Form_ajustesUsuario_Load(object sender, EventArgs e)
        {

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

        private void btn_datos_Click(object sender, EventArgs e)
        {
            AbrirForms(new form_misDatosAjustes());
        }

        private void btn_cambiarContra_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_cambiarContraseñaAjustes());
        }

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
