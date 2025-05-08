using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Factories
{
    public abstract class UsuarioFactory
    {
        public abstract Usuario CrearUsuario(string Tipo, string nombreUsu, string contra, string email);
    }
}
