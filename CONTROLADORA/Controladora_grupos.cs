using MODELO.Composite;
using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace CONTROLADORA
{
    public class Controladora_grupos
    {
        private static Controladora_grupos instancia;
        //private Context contextGrupo;
        public static Controladora_grupos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_grupos();
                }
                return instancia;
            }
        }

        public Controladora_grupos()
        {
            
        }

        public ReadOnlyCollection<Grupo> ListarGrupos()
        {
            using (var context = new Context())
            {
                var gruposConPermisos = context.Grupos
                .Include(g => g.Permisos)
                .ToList();

                return gruposConPermisos.AsReadOnly();
            }
        }

        public ReadOnlyCollection<Grupo> ListarGruposConPermisos()
        {
            using (var context = new Context())
            {
                return context.Grupos
                    .Include(g => g.Permisos)
                    .ToList()
                    .AsReadOnly();
            }
        }

        public Grupo CrearGrupos(string nombre)
        {
            Grupo grupo = new Grupo();

            grupo.Nombre = nombre;

            return grupo;
        }

        public string AgregarGrupo(Grupo nuevoGrupo)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Grupos.Add(nuevoGrupo);
                    context.SaveChanges();
                    return "Nuevo grupo agregado al sistema con exito.";
                }
                catch (Exception ex)
                {
                    return "Error al agregar grupo: " + ex.Message;
                }
            }
        }

        public string ModificarGrupo(Grupo grupo)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Grupos.Update(grupo);
                    context.SaveChanges();
                    return "Grupo modificado con éxito.";
                }
                catch (Exception ex)
                {
                    return "Error al modificar grupo: " + ex.Message;
                }
            }

        }

        public string EliminarGrupo(Grupo grupo)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Grupos.Remove(grupo);
                    context.SaveChanges();
                    return "Grupo eliminado con éxito.";
                }
                catch (Exception ex)
                {
                    return "Error al eliminar grupo: " + ex.Message;
                }
            }

        }

        public bool ValidarGrupo(string nombre)
        {
            using (var context = new Context())
            {
                ReadOnlyCollection<Grupo> lst_grupos = ListarGrupos();

                foreach (Grupo g in lst_grupos)
                {
                    if (g.Nombre == nombre)
                    {
                        return true;
                    }

                }
                return false;
            }

            
        }

        public bool ValidarGrupoModificado(Grupo grupo)
        {
            using (var context = new Context())
            {
                ReadOnlyCollection<Grupo> lst_grupos = ListarGrupos();

                foreach (Grupo g in lst_grupos)
                {
                    if (g.Nombre == grupo.Nombre && g.GrupoId != grupo.GrupoId)
                    {
                        return true;
                    }

                }
                return false;
            }

        }

        public string AsignarPermisosAGrupo(int grupoId, List<Permiso> permisosSeleccionados)
        {
            using (var context = new Context()) 
            {
                try
                {
                    var grupo = context.Grupos
                        .Include(g => g.Permisos)
                        .FirstOrDefault(g => g.GrupoId == grupoId);

                    if (grupo == null)
                        return "Grupo no encontrado.";

                    grupo.Permisos.Clear();

                    var idsSeleccionados = permisosSeleccionados.Select(p => p.PermisoId).ToList();

                    var permisosDesdeDb = context.Permisos
                    .Where(p => idsSeleccionados.Contains(p.PermisoId))
                    .ToList();

                    foreach (var permiso in permisosDesdeDb)
                    {
                        grupo.Permisos.Add(permiso);
                    }

                    context.SaveChanges();
                    return "Permisos asignados correctamente.";
                }
                catch (Exception ex)
                {
                    return "Error al asignar permisos: " + ex.Message;
                }
            }
        }




    }
}
