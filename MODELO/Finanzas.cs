using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Finanzas:Usuario
    {
        public override List<string> Permisos => new List<string>
        {
             "Informes"
        };
    }
}
