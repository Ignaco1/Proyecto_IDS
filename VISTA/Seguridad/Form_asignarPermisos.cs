using CAPA_COMUN.Cache;
using MODELO.Composite;
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
    public partial class Form_asignarPermisos : Form
    {
        CONTROLADORA.Controladora_permisos contro_per = new CONTROLADORA.Controladora_permisos();
        CONTROLADORA.Controladora_grupos contro_grup = new CONTROLADORA.Controladora_grupos();
        string vari;
        int indice = 0;
        public Form_asignarPermisos()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_GRILLA();
            txt_nombre.Enabled = false;
        }

        private void Form_asignarPermisos_Load(object sender, EventArgs e)
        {
            check_listaPermisos.Items.Clear();

            var permisos = contro_per.ListarPermisos();

            foreach (var permiso in permisos)
            {
                check_listaPermisos.Items.Add(permiso, false);
            }
        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var grupos = contro_grup.ListarGrupos();

            List<MODELO.Composite.Grupo> gruposFiltrados;

            if (UsuarioCache.UsuarioGrupoNombre != "SuperAdministrador")
            {
                gruposFiltrados = grupos.Where(g => g.Nombre != "SuperAdministrador").ToList();
            }
            else
            {
                gruposFiltrados = grupos.ToList();
            }

            var datosGrilla = gruposFiltrados
                .Select(g => new
                {
                    ID = g.GrupoId,
                    Nombre = g.Nombre,
                    Permisos = string.Join(", ", g.Permisos.Select(p => p.Nombre))
                })
                .ToList();

            dataGridView1.DataSource = datosGrilla;
        }

        private void MODO_GRILLA()
        {
            groupBox_grupos.Enabled = true;
            groupBox_carga.Enabled = false;
        }

        private void MODO_CARGA()
        {
            groupBox_grupos.Enabled = false;
            groupBox_carga.Enabled = true;
        }

        private void LIMPIAR()
        {
            txt_nombre.Text = "";

            for (int i = 0; i < check_listaPermisos.Items.Count; i++)
            {
                check_listaPermisos.SetItemChecked(i, false);
            }
        }

        private void btn_asignarPermisos_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un grupo.", "Error");
                return;
            }

            vari = "A";

            MODELO.Composite.Grupo grupo = contro_grup.ListarGrupos()[indice];

            txt_nombre.Text = grupo.Nombre;

            MODO_CARGA();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (vari == "A")
            {
                MODELO.Composite.Grupo grupo = contro_grup.ListarGrupos()[indice];

                var permisosSeleccionados = check_listaPermisos.CheckedItems
                .OfType<Permiso>()
                .ToList();

                if (permisosSeleccionados.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un permiso.", "Error");
                    return;
                }

                try
                {
                    string respuesta = contro_grup.AsignarPermisosAGrupo(grupo.GrupoId, permisosSeleccionados);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al asignar permisos: " + ex.Message, "Error");
                    return;
                }
            }

            if (vari == "M")
            {
                MODELO.Composite.Grupo grupo = contro_grup.ListarGrupos()[indice];

                var permisosSeleccionados = check_listaPermisos.CheckedItems
                .OfType<Permiso>()
                .ToList();

                if (permisosSeleccionados.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un permiso.", "Error");
                    return;
                }

                try
                {
                    string respuesta = contro_grup.AsignarPermisosAGrupo(grupo.GrupoId, permisosSeleccionados);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al asignar permisos: " + ex.Message, "Error");
                    return;
                }
            }

            ARMA_GRILLA();
            MODO_GRILLA();
            LIMPIAR();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MODO_GRILLA();
            LIMPIAR();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un grupo.", "Error");
                return;
            }

            indice = dataGridView1.CurrentRow.Index;
        }

        private void btn_modificarPermisos_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un grupo.", "Error");
                return;
            }

            vari = "M";

            MODELO.Composite.Grupo grupo = contro_grup.ListarGrupos()[indice];

            txt_nombre.Text = grupo.Nombre;

            check_listaPermisos.Items.Clear();

            var todosLosPermisos = contro_per.ListarPermisos();

            foreach (var permiso in todosLosPermisos)
            {
                bool estaAsignado = grupo.Permisos.Any(p => p.PermisoId == permiso.PermisoId);
                check_listaPermisos.Items.Add(permiso, estaAsignado);
            }

            MODO_CARGA();

        }
    }
}
