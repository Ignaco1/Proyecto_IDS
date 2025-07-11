﻿using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_COMUN;
using CAPA_COMUN.Cache;

using MODELO.Composite;

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

        public Usuario CrearUsuarioFactory(string grupoNombre, string nombre_usuario, string contraseña,string email)
        {
            Grupo grupo = AdministradorDeGrupos.ObtenerGrupo(grupoNombre);

            if(grupo == null)
            {
                throw new Exception("Grupo no valido");
            }

            return new Usuario
            {
                Nombre_usuario=nombre_usuario,
                Contraseña=contraseña,
                Email=email,
                Grupo = grupo
            };

            
        }

        public string AgregarUsuario(Usuario nuevoUsuario)
        {
            try
            {
                contextUsuario.Add(nuevoUsuario);
                contextUsuario.SaveChanges();
                return "Nuevo usuario agregado al sistema con exito";
            }
            catch (Exception ex)
            {
                return "Ocurrió un error en el sistema: " + ex.Message;
            }
        }

        public string ModificarUsuario(Usuario usuario)
        {
            try
            {
                contextUsuario.Update(usuario);
                contextUsuario.SaveChanges();
                return "Usuario modificado con exito";
            }
            catch (Exception ex)
            {
                return "Ocurrió un error en el sistema: " + ex.Message;
            }
        }

        public string EliminarUsuario(Usuario usuario)
        {
            try
            {
                contextUsuario.Remove(usuario);
                contextUsuario.SaveChanges();
                return "Usuario eliminado con exito";
            }
            catch (Exception ex)
            {
                return "Ocurrió un error en el sistema: " + ex.Message;
            }
        }

        public Usuario ValidarLogin(string Nombre_usuario, string Contra)
        {
            var usuario = contextUsuario.Usuarios.FirstOrDefault(u => u.Nombre_usuario == Nombre_usuario && u.Contraseña == Contra);

            if (usuario == null)
                return null;

            return usuario;
        }

        public bool ValidarUsuario(string email, string usuNom, int id)
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
