using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Reservas
    {
        public int ReservaId { get; set; }
        public int IdCliente { get; set; }
        public int IdCabaña { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }
    }
}
