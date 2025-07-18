using CAPA_COMUN.Cache;
using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.Composite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Controladora_permisos
    {
        private static Controladora_permisos instancia;
        //private Context contextPermiso;
        public static Controladora_permisos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_permisos();
                }
                return instancia;
            }
        }

        public Controladora_permisos()
        {
            
        }

        public ReadOnlyCollection<Permiso> ListarPermisos()
        {
            using (var context = new Context())
            {

                var permisosConGrupos = context.Permisos
                .Include(p => p.Grupos)
                .ToList();

                return permisosConGrupos.AsReadOnly();
            }
        }

        public Permiso CrearPermisos(string nombre)
        {
            Permiso permiso = new Permiso();

            permiso.Nombre = nombre;

            return permiso;
        }

        public string AgregarPermiso(Permiso nuevoPermiso)
        {
            using (var context = new Context())
            {

                try
                {
                    context.Add(nuevoPermiso);
                    context.SaveChanges();
                    return "Nuevo permiso agregado al sistema con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrió un error en el sistema: " + ex.Message;
                }
            }
        }

        public string ModificarPermiso(Permiso permisoModificado)
        {
            using (var context = new Context())
            {
                try
                {
                    var permisoExistente = context.Permisos
                        .Include(p => p.Grupos)
                        .FirstOrDefault(p => p.PermisoId == permisoModificado.PermisoId);

                    if (permisoExistente == null)
                        return "El permiso no existe.";


                    permisoExistente.Nombre = permisoModificado.Nombre;


                    permisoExistente.Grupos.Clear();


                    foreach (var grupo in permisoModificado.Grupos)
                    {
                        var grupoExistente = context.Grupos.Find(grupo.GrupoId);
                        if (grupoExistente != null)
                        {
                            permisoExistente.Grupos.Add(grupoExistente);
                        }
                    }

                    context.SaveChanges();
                    return "Permiso modificado con éxito.";
                }
                catch (Exception ex)
                {
                    return "Ocurrió un error en el sistema: " + ex.Message;
                }

            }
        }

        public string EliminarPermiso(Permiso permiso)
        {
            using (var context = new Context())
            {

                try
                {
                    context.Remove(permiso);
                    context.SaveChanges();
                    return "Permiso eliminado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrió un error en el sistema: " + ex.Message;
                }
            }

        }

        public bool ValidarPermiso(string nombre)
        {
            using (var context = new Context())
            {
                ReadOnlyCollection<Permiso> lst_permisos = ListarPermisos();

                foreach (Permiso p in lst_permisos)
                {
                    if (p.Nombre == nombre)
                    {
                        return true;
                    }
                }

                return false;
            }

        }

        public bool ValidarPermisoModificado(Permiso Permiso)
        {
            using (var context = new Context())
            {
                ReadOnlyCollection<Permiso> lst_permisos = ListarPermisos();

                foreach (Permiso p in lst_permisos)
                {
                    if (p.Nombre == Permiso.Nombre && p.PermisoId != Permiso.PermisoId)
                    {
                        return true;
                    }
                }

                return false;
            }

        }
    }
}
