using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Composite
{
    public static class AdministradorDeGrupos
    {
        public static Dictionary<string, Grupo> Grupos { get; private set; } = new();

        public static void Inicializar()
        {
            #region PERMISOS
            var permisosSeguridad = new PermisoSimple { Nombre = "Seguridad" };
            var permisosAsignarPermisos = new PermisoSimple { Nombre = "Asignar Permisos" };
            var permisosABMusuarios = new PermisoSimple { Nombre = "ABM de Usuarios" };
            var permisosABMclientes = new PermisoSimple { Nombre = "ABM de Clientes" };
            var permisosABMcabañas = new PermisoSimple { Nombre = "ABM de Cabañas" };
            var permisosCabañasAlquiler = new PermisoSimple { Nombre = "Cabañas y alquiler" };
            var permisosReservas = new PermisoSimple { Nombre = "Reservas" };
            var permisosInformes = new PermisoSimple { Nombre = "Informes" };

            var permisosABMcompuesto = new PermisoCompuesto { Nombre = "ABM" };
            permisosABMcompuesto.AgregarPermiso(permisosABMusuarios);
            permisosABMcompuesto.AgregarPermiso(permisosABMclientes);
            permisosABMcompuesto.AgregarPermiso(permisosABMcabañas);

            #endregion

            Grupos["Administrador"] = new Grupo
            {
                Nombre = "Administrador",
                Permisos = new List<Permiso>
                {
                    permisosSeguridad,
                    permisosAsignarPermisos,
                    permisosABMcompuesto,
                    permisosCabañasAlquiler,
                    permisosReservas,
                    permisosInformes
                }
            };

            Grupos["Administracion"] = new Grupo
            {
                Nombre = "Administracion",
                Permisos = new List<Permiso>
                {
                    permisosABMclientes,
                    permisosABMcabañas,
                    permisosCabañasAlquiler,
                    permisosReservas
                }
            };

            Grupos["Gerencia"] = new Grupo
            {
                Nombre = "Gerencia",
                Permisos = new List<Permiso>
                {
                    permisosABMcompuesto,
                    permisosCabañasAlquiler,
                    permisosReservas,
                    permisosInformes
                }
            };

            Grupos["Finanzas"] = new Grupo
            {
                Nombre = "Finanzas",
                Permisos = new List<Permiso>
                {
                    permisosInformes
                }
            };
        }

        public static Grupo ObtenerGrupo(string nombre)
        {
            return Grupos.TryGetValue(nombre, out var grupo) ? grupo : null;
        }
    }
}
