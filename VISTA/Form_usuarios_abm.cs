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
        public Form_usuarios_abm()
        {
            InitializeComponent();
            MODO_LISTA();
            ARMA_GRILLA();
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
            txt_nombre.Text = "";
            txt_email.Text = "";
            txt_contraseña.Text = "";
            txt_idUsuario.Text = "";
            cb_tipoUsuario.Text = "";
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //MODELO.Usuario usuario = new MODELO.Usuario();

            //#region VALIDACIONES

            //if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            //{
            //    MessageBox.Show("Ingrese el nombre del usuario.", "ERROR");
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(cb_tipoUsuario.Text))
            //{
            //    MessageBox.Show("Seleccione un tipo de usuario.", "ERROR");
            //    return;
            //}

            //if (cb_tipoUsuario.Text != "Administrador" && cb_tipoUsuario.Text != "Administración" && cb_tipoUsuario.Text != "Finanzas" && cb_tipoUsuario.Text != "Gerencia")
            //{
            //    MessageBox.Show("Seleccione un tipo de usuario posible.\nNo ingrese usuario que no existen. ", "ERROR");
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(txt_idUsuario.Text))
            //{
            //    MessageBox.Show("Ingrese el ID del usuario.", "ERROR");
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(txt_contraseña.Text))
            //{
            //    MessageBox.Show("Ingrese una contraseña para el usuario.", "ERROR");
            //    return;
            //}
            

            //if (string.IsNullOrWhiteSpace(txt_email.Text))
            //{
            //    MessageBox.Show("Ingrese el email del usuario.", "ERROR");
            //    return;
            //}

            //if (!ValidarMail(txt_email.Text))
            //{
            //    MessageBox.Show("Ingrese un email posible para el usuario.\nEJ: Ignaciocarignano@vitastays.com", "ERROR");
            //    return;
            //}

            //#endregion

            //if (vari == "A")
            //{
            //    if (!contro_us.ValidarUsuario(txt_email.Text))
            //    {
            //        int nivel = 0;
            //        switch (cb_tipoUsuario.Text)
            //        {
            //            case "Administrador":
            //                nivel = 0;
            //                break;

            //            case "Administración":
            //                nivel = 1;
            //                break;

            //            case "Finanzas":
            //                nivel = 2;
            //                break;

            //            case "Gerencia":
            //                nivel = 3;
            //                break;
            //        }

            //        usuario = contro_us.CrearUsuario(txt_nombre.Text, cb_tipoUsuario.Text, txt_idUsuario.Text, txt_contraseña.Text, txt_email.Text, nivel);

            //       try
            //       {
            //            string resultado = contro_us.AgregarUsuario(usuario);
            //            MessageBox.Show(resultado);
            //       }
            //       catch (Exception ex)
            //       {
            //            MessageBox.Show("Ocurrió un error en el sistema: " + ex.Message, "ERROR");
            //       }
                    
            //    }
            //    else
            //    {
            //        MessageBox.Show("Este cliente ya existe\n\nIntente con otro email", "AVISO");
            //        return;
            //    }
            //}

            //ARMA_GRILLA();
            //MODO_LISTA();
            //LIMPIAR();

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
    }
}
