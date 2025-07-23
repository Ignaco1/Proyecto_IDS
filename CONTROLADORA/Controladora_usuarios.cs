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
using System.Security.Cryptography;
using CONTROLADORA.Utilidades;
using CONTROLADORA.ServiciosCorreo;

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

        public (Usuario usuario, string contraOriginal) CrearUsuario(string grupoNombre, string nombre, string apellido, string nombre_usuario, string email)
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
                usuario.Email = email;
                usuario.GrupoId = grupo.GrupoId;

                string Contraseña = SeguridadUtilidades.GenerarContraseñaAleatoria();

                string contraseñaEncriptada = SeguridadUtilidades.EncriptarSHA256(Contraseña);

                usuario.Contraseña = contraseñaEncriptada;

                usuario.PrimerIngreso = true;


                return (usuario, Contraseña);
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
                    return "Ocurrió un error en el sistema: " + ex.InnerException.Message;

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
                    usuarioDb.PrimerIngreso = usuario.PrimerIngreso;

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
            string contraseñaEncriptada = SeguridadUtilidades.EncriptarSHA256(Contra);
            
            using (var context = new Context())
            {
                var usuario = context.Usuarios.Include(u => u.Grupo).ThenInclude(g => g.Permisos).FirstOrDefault(u => u.Nombre_usuario == Nombre_usuario && u.Contraseña == contraseñaEncriptada);

                if (usuario == null)
                    return null;

                return usuario;
            }

        }


        public Usuario ObtenerUsuarioId(int id)
        {
            using (var context = new Context())
            {
                var usuario = context.Usuarios.Include(u => u.Grupo).ThenInclude(g => g.Permisos).FirstOrDefault(u => u.UsuarioId == id);

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

        public bool ValidarUsuarioRecuperacion(string email, string usuNom)
        {
            using (var context = new Context())
            {
                return context.Usuarios.Any(u => u.Email.ToUpper() == email.ToUpper() && u.Nombre_usuario.ToUpper() == usuNom.ToUpper());
                
            }

        }

        public string EnviarDatos(string nombre_usuario, string email, string contraseña)
        {
            using (var context = new Context())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.Nombre_usuario == nombre_usuario && u.Email == email);

                if (usuario == null)
                {
                    return "El usuario o email no están registrados correctamente.";
                }

                try
                {
                    var mailService = new ServicioCorreoSistema();
                    string asunto = "Datos de ingreso inicial - VitaStays";
                    string mensaje = $"Hola {usuario.Nombre} {usuario.Apellido},\n\n" +
                                     $"Tu usuario es: {usuario.Nombre_usuario}\n\n " +
                                     $"Tu contraseña es: {contraseña}\n\n";

                    mailService.EnviarCorreo(asunto, mensaje, new List<string> { usuario.Email });

                    return "Datos iniciales enviados al usuario.";
                }
                catch (Exception ex)
                {
                    return "Error al enviar el correo:  " + ex.Message;
                }
            }

        }

        public string RecuperarContraseña(string nombre_usuario, string email)
        {
            using (var context = new Context())
            {
                var usuario = context.Usuarios.FirstOrDefault(u =>u.Nombre_usuario == nombre_usuario && u.Email == email);

                if (usuario == null)
                {
                    return "El usuario o email no están registrados correctamente.";
                }

                string nuevaContraseña = SeguridadUtilidades.GenerarContraseñaAleatoria();

                string contraseñaEncriptada = SeguridadUtilidades.EncriptarSHA256(nuevaContraseña);
               
                usuario.Contraseña = contraseñaEncriptada;

                context.SaveChanges();

                try
                {
                    var mailService = new ServicioCorreoSistema();
                    string asunto = "Contraseña temporal generada - VitaStays";
                    string mensaje = $"Hola {usuario.Nombre} {usuario.Apellido},\n\n" +
                                     $"Tu nueva contraseña es: {nuevaContraseña}\n\n" +
                                     $"Una vez iniciado sesion en el sistema, debes cambiar la contraseña desde la parte de ajustes.";

                    mailService.EnviarCorreo(asunto, mensaje, new List<string> { usuario.Email });

                    return "Nueva contraseña enviada correctamente. Verifique su bandeja de entrada.";
                }
                catch (Exception ex)
                {
                    return "Error al enviar el correo:  " + ex.Message;
                }
            }

        }


    }
}
