using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Controladora_usuarios
    {
        private static Controladora_usuarios _instancia;
        public static Controladora_usuarios Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Controladora_usuarios();
                }
                return _instancia;
            }
        }
        private Controladora_usuarios()
        {
            // Constructor privado para evitar instanciación externa
        }
        public bool ValidarLogin(string Nombre_usuario, string Contra)
        {
            // Aquí puedes implementar la lógica para validar el login
            // Por ejemplo, consultar una base de datos o una lista de usuarios
            // En este caso, simplemente se valida contra un usuario y contraseña fijos
            if (Nombre_usuario == "admin" && Contra == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
