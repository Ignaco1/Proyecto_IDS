using MODELO.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MODELO.Factories
{
    public static class UsuarioFactory
    {
        public static Usuario CrearUsuario(string grupoNombre, string nombreUsu, string contra, string email)
        {

            var grupo = CrearGrupo(grupoNombre);

            return new Usuario
            {
                Nombre_usuario = nombreUsu,
                Contraseña = contra,
                Email = email,
                Grupo = grupo
            };

        }
        private static Grupo CrearGrupo(string nombre)
        {
            var grupo = new Grupo { Nombre = nombre };

            switch (nombre)
            {
                case "Administrador":
                    grupo.Permisos.Add(new PermisoSimple { Nombre = "Reservas" });
                    grupo.Permisos.Add(new PermisoSimple { Nombre = "Informes" });
                    grupo.Permisos.Add(new PermisoSimple { Nombre = "Seguridad" });

                    var abm = new PermisoCompuesto { Nombre = "ABM" };
                    abm.AgregarPermiso(new PermisoSimple { Nombre = "ABM Usuarios" });
                    abm.AgregarPermiso(new PermisoSimple { Nombre = "ABM Clientes" });
                    grupo.Permisos.Add(abm);
                    break;

                case "Finanzas":
                    grupo.Permisos.Add(new PermisoSimple { Nombre = "Informes" });
                    break;

                case "Gerencia":
                    grupo.Permisos.Add(new PermisoSimple { Nombre = "Reservas" });
                    grupo.Permisos.Add(new PermisoSimple { Nombre = "Informes" });
                    break;
            }

            return grupo;
        }
        

    }
}
