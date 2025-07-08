using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("Reservas")]
    public class Reserva
    {
        public int ReservaId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Cabaña Cabaña { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public DateOnly FechaEgreso { get; set; }
        public string Estado { get; set; }
        public virtual List<Pago> Pagos { get; set; } = new();
    }
}
