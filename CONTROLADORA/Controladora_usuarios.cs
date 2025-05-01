using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_COMUN;
using CAPA_COMUN.Cache;

namespace CONTROLADORA
{
    public class Controladora_usuarios
    {
        private static Controladora_usuarios instancia;
        private Context contextUsuario;
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
            contextUsuario = new Context();
        }

        public ReadOnlyCollection<Usuario> ListarUsuarios()
        {
            return contextUsuario.Usuarios.ToList().AsReadOnly();
        }

        public Usuario CrearUsuario(string nombre, string tipo, string nombre_usuario, string contraseña,string email, int nivel_acceso)
        {
            Usuario usuario = new Usuario();

            usuario.Nombre = nombre;
            usuario.Tipo_usuario = tipo;
            usuario.Nombre_usuario = nombre_usuario;
            usuario.Contraseña = contraseña;
            usuario.Email = email;
            usuario.Nivel_acceso = nivel_acceso;
            return usuario;
        }

        public string AgregarUsuario(Usuario nuevoUsuario)
        {
            try
            {
                contextUsuario.Add(nuevoUsuario);
                contextUsuario.SaveChanges();
                return $"Nuevo usuario agregado al sistema con exito";
            }
            catch (Exception ex)
            {
                return "Ocurrió un error en el sistema: " + ex.Message;
            }
        }

        public string ModificarCliente(Usuario usuario)
        {
            try
            {
                contextUsuario.Update(usuario);
                contextUsuario.SaveChanges();
                return $"Usuario modificado con exito";
            }
            catch (Exception ex)
            {
                return "Ocurrió un error en el sistema: " + ex.Message;
            }
        }

        public string EliminarCliente(Usuario usuario)
        {
            try
            {
                contextUsuario.Remove(usuario);
                contextUsuario.SaveChanges();
                return $"Usuario eliminado con exito";
            }
            catch (Exception ex)
            {
                return "Ocurrió un error en el sistema: " + ex.Message;
            }
        }

        public bool ValidarLogin(string Nombre_usuario, string Contra)
        {
            ReadOnlyCollection<Usuario> lst_usuarios = ListarUsuarios();

            foreach (Usuario usuario in lst_usuarios)
            {
                if (usuario.Nombre_usuario == Nombre_usuario && usuario.Contraseña == Contra)
                {
                    UsuarioCache.UsuarioId = usuario.UsuarioId;
                    UsuarioCache.UsuarioNombre = usuario.Nombre;
                    UsuarioCache.UsuarioTipo = usuario.Tipo_usuario;
                    UsuarioCache.UsuarioEmail = usuario.Email;
                    UsuarioCache.UsuarioNivel = usuario.Nivel_acceso;
                    return true;
                }
            }

            return false;
        }

        public bool ValidarUsuario(string emial)
        {
            ReadOnlyCollection<Usuario> lst_us = ListarUsuarios();

            foreach (Usuario usuario in lst_us)
            {
                if (usuario.Email == emial)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
