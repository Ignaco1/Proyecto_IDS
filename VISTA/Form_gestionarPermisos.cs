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
    public partial class Form_gestionarPermisos : Form
    {
        CONTROLADORA.Controladora_permisos contro_per = new CONTROLADORA.Controladora_permisos();
        string vari;
        int indice = 0;
        public Form_gestionarPermisos()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_GRILLA();
        }

        private void Form_gestionarPermisos_Load(object sender, EventArgs e)
        {

        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var permisos = contro_per.ListarPermisos()
                .Select(p => new
                {
                    ID = p.PermisoId,
                    Nombre = p.Nombre,
                    Grupos = string.Join(", ", p.Grupos.Select(g => g.Nombre))
                })
                .ToList();

            dataGridView1.DataSource = permisos;
        }

        private void MODO_GRILLA()
        {
            groupBox_permisos.Enabled = true;
            groupBox_carga.Enabled = false;
        }

        private void MODO_CARGA()
        {
            groupBox_permisos.Enabled = false;
            groupBox_carga.Enabled = true;
        }

        private void LIMPIAR()
        {
            txt_nombre.Text = "";
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_crearPermiso_Click(object sender, EventArgs e)
        {
            vari = "C";
            MODO_CARGA();
        }

        private void btn_modificarPermiso_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un permiso", "Error");
                return;
            }

            MODELO.Composite.Permiso permiso;
            vari = "M";

            permiso = contro_per.ListarPermisos()[indice];

            txt_nombre.Text = permiso.Nombre;

            MODO_CARGA();
        }

        private void btn_eliminarPermiso_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un permiso", "Error");
                return;
            }

            MODELO.Composite.Permiso permiso;

            permiso = contro_per.ListarPermisos()[indice];
            DialogResult resultado = MessageBox.Show($"Está seguro que desea eliminar el permiso:\n\nNombre: {permiso.Nombre}", "AVISO", MessageBoxButtons.YesNo);

            if(resultado== DialogResult.Yes)
            {
                try
                {
                    string respuesta = contro_per.EliminarPermiso(permiso);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el permiso: " + ex.Message);
                }

            }

            ARMA_GRILLA();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MODELO.Composite.Permiso permiso = null;

            if (vari == "C")
            {
                if (!contro_per.ValidarPermiso(txt_nombre.Text))
                {
                    permiso = contro_per.CrearPermisos(txt_nombre.Text);

                    try
                    {
                        string respuesta = contro_per.AgregarPermiso(permiso);
                        MessageBox.Show(respuesta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al crear el permiso: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Este permiso ya existe en el sistema.\n\nIntente con otro nombre de permiso.", "AVISO");
                    return;
                }
            }

            if (vari == "M")
            {
                permiso = contro_per.ListarPermisos()[indice];

                permiso.Nombre = txt_nombre.Text;

                if (!contro_per.ValidarPermisoModificado(permiso))
                {
                    try
                    {
                        string respuesta = contro_per.ModificarPermiso(permiso);
                        MessageBox.Show(respuesta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar el permiso: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Este permiso ya existe en el sistema.\n\nIntente con otro nombre de permiso.", "AVISO");
                    return;
                }
            } 
            

            ARMA_GRILLA();
            LIMPIAR();
            MODO_GRILLA();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            MODO_GRILLA();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un permiso", "Error");
                return;
            }

            indice = dataGridView1.CurrentRow.Index;
        }
    }
}
