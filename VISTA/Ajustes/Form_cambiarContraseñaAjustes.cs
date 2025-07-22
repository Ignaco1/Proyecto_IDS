using CAPA_COMUN.Cache;
using CONTROLADORA.Utilidades;
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

namespace VISTA
{
    public partial class Form_cambiarContraseñaAjustes : Form
    {
        CONTROLADORA.Controladora_usuarios contro_us = new CONTROLADORA.Controladora_usuarios();

        public Form_cambiarContraseñaAjustes()
        {
            InitializeComponent();
            btn_dejarVerConfirmar.Visible = false;
            btn_dejarVerNueva.Visible = false;
            btn_dejarVerActual.Visible = false;
        }

        private void Form_cambiarContraseñaAjustes_Load(object sender, EventArgs e)
        {
            txt_contraActual.UseSystemPasswordChar = true;
            txt_contraNueva.UseSystemPasswordChar = true;
            txt_confirmar.UseSystemPasswordChar = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES

            if (string.IsNullOrWhiteSpace(txt_contraActual.Text) || string.IsNullOrWhiteSpace(txt_contraNueva.Text) || string.IsNullOrWhiteSpace(txt_confirmar.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_contraActual.Text))
            {
                MessageBox.Show("Por favor, ingrese su contraseña actual.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_contraNueva.Text))
            {
                MessageBox.Show("Por favor, ingrese su contraseña nueva.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_confirmar.Text))
            {
                MessageBox.Show("Por favor, ingrese la confirmación de la contraseña nueva.", "Error");
                return;
            }

            var usuario = contro_us.ObtenerUsuarioId(UsuarioCache.UsuarioId);
            string claveActualEncriptada = SeguridadUtilidades.EncriptarSHA256(txt_contraActual.Text);

            if (usuario.Contraseña != claveActualEncriptada)
            {
                MessageBox.Show("La contraseña actual es incorrecta.", "Error");
                return;
            }

            if (txt_contraNueva.Text != txt_confirmar.Text)
            {
                MessageBox.Show("La nueva contraseña y su confirmación no coinciden.", "Error");
                return;
            }

            if (!ValidaContraseña(txt_contraNueva.Text))
            {
                MessageBox.Show("La nueva contraseña debe tener al menos 8 caracteres, incluyendo una letra mayúscula, una letra minúscula, un número y un carácter especial.", "Error");
                return;
            }

            #endregion

            try
            {
                string contraEncriptada = SeguridadUtilidades.EncriptarSHA256(txt_contraNueva.Text);
                usuario.Contraseña = contraEncriptada;

                contro_us.ModificarUsuario(usuario);
                MessageBox.Show("La clave ha sido cambiada exitosamente.", "Éxito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar la clave.", "Error");
                return;
            }

        }

        private bool ValidaContraseña(string contraseña)
        {
            string patron = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+{}\[\]:;<>,.?~\\\-]).{8,}$";
            return Regex.IsMatch(contraseña, patron);
        }

        private void btn_verActual_Click(object sender, EventArgs e)
        {
            txt_contraActual.UseSystemPasswordChar = false;
            btn_verActual.Visible = false;
            btn_dejarVerActual.Visible = true;
        }

        private void btn_verNueva_Click(object sender, EventArgs e)
        {
            txt_contraNueva.UseSystemPasswordChar = false;
            btn_verNueva.Visible = false;
            btn_dejarVerNueva.Visible = true;
        }

        private void btn_verConfirmar_Click(object sender, EventArgs e)
        {
            txt_confirmar.UseSystemPasswordChar = false;
            btn_verConfirmar.Visible = false;
            btn_dejarVerConfirmar.Visible = true;
        }

        private void bnt_dejarVerActual_Click(object sender, EventArgs e)
        {
            txt_contraActual.UseSystemPasswordChar = true;
            btn_verActual.Visible = true;
            btn_dejarVerActual.Visible = false;
        }

        private void btn_dejarVerNueva_Click(object sender, EventArgs e)
        {
            txt_contraNueva.UseSystemPasswordChar = true;
            btn_verNueva.Visible = true;
            btn_dejarVerNueva.Visible = false;
        }

        private void btn_dejarVerConfirmar_Click(object sender, EventArgs e)
        {
            txt_confirmar.UseSystemPasswordChar = true;
            btn_verConfirmar.Visible = true;
            btn_dejarVerConfirmar.Visible = false;
        }
    }
}
