using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_COMUN;
using CAPA_COMUN.Cache;
using MODELO.Composite;
using Microsoft.EntityFrameworkCore;

namespace CONTROLADORA
{
    public class Controladora_usuarios
    {
        private static Controladora_usuarios instancia;
       // private Context contextUsuario;
        public static Controladora_usuarios Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_usuarios();
                }
                return instancia;
            }
        }

        public Controladora_usuarios()
        {
            
        }

        public ReadOnlyCollection<Usuario> ListarUsuarios()
        {
            using (var context = new Context())
            {
                var usuariosConGrupo = context.Usuarios
                .Include(u => u.Grupo)
                .ToList();

                return usuariosConGrupo.AsReadOnly();
            }

        }

        public Usuario CrearUsuario(string grupoNombre, string nombre, string apellido, string nombre_usuario, string contraseña, string email)
        {
            using (var context = new Context())
            {
                var grupo = context.Grupos.FirstOrDefault(g => g.Nombre == grupoNombre);

                if (grupo == null)
                {
                    throw new Exception("Grupo no encontrado.");
                }

                var usuario = new Usuario();

                usuario.Nombre = nombre;
                usuario.Apellido = apellido;
                usuario.Nombre_usuario = nombre_usuario;
                usuario.Contraseña = contraseña;
                usuario.Email = email;
                usuario.GrupoId = grupo.GrupoId;
                

                return usuario;
            }
        }

        public string AgregarUsuario(Usuario nuevoUsuario)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Add(nuevoUsuario);
                    context.SaveChanges();
                    return "Nuevo usuario agregado al sistema con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrió un error en el sistema: " + ex.Message;

                }

            }
        }

        public string ModificarUsuario(Usuario usuario)
        {
            using (var context = new Context())
            {
                try
                {
                    var usuarioDb = context.Usuarios.FirstOrDefault(u => u.UsuarioId == usuario.UsuarioId);

                    if (usuarioDb == null)
                        return "Usuario no encontrado.";

                    usuarioDb.Nombre = usuario.Nombre;
                    usuarioDb.Apellido = usuario.Apellido;
                    usuarioDb.Nombre_usuario = usuario.Nombre_usuario;
                    usuarioDb.Contraseña = usuario.Contraseña;
                    usuarioDb.Email = usuario.Email;
                    usuarioDb.GrupoId = usuario.GrupoId;

                    context.SaveChanges();
                    return "Usuario modificado con éxito";
                }
                catch (Exception ex)
                {
                    return "Ocurrió un error en el sistema: " + ex.Message;
                }
            }

        }

        public string EliminarUsuario(Usuario usuario)
        {
            using (var context = new Context())
            {

                try
                {
                    context.Remove(usuario);
                    context.SaveChanges();
                    return "Usuario eliminado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrió un error en el sistema:  " + ex.Message;
                }
            }

        }

        public Usuario ValidarLogin(string Nombre_usuario, string Contra)
        {
            using (var context = new Context())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.Nombre_usuario == Nombre_usuario && u.Contraseña == Contra);

                if (usuario == null)
                    return null;

                return usuario;
            }

        }

        public bool ValidarUsuario(string email, string usuNom, int id)
        {
            using (var context = new Context())
            {
                ReadOnlyCollection<Usuario> lst_us = ListarUsuarios();

                foreach (Usuario usuario in lst_us)
                {
                    if ((usuario.Email == email || usuario.Nombre_usuario == usuNom) && usuario.UsuarioId != id)
                    {
                        return true;
                    }
                }
                return false;
            }

        }

    }
}
