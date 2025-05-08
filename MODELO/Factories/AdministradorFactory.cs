using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Factories
{
    public class AdministradorFactory:UsuarioFactory
    {
        public override Usuario CrearUsuario(string Tipo, string nombreUsu, string contra, string email)
        {
            return new Administrador
            {
                Tipo_usuario = Tipo,
                Nombre_usuario = nombreUsu,
                Contraseña = contra,
                Email = email
            };
        }
    }
}
