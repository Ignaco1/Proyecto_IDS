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
    public partial class Form_usuarios_abm : Form
    {
        public Form_usuarios_abm()
        {
            InitializeComponent();
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
