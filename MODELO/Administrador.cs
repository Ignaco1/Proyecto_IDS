using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Administrador:Usuario
    {
        public override List<string> Permisos => new List<string>
        {
             "Reservas", "ABM", "Informes", "Seguridad"
        };
    }
}
