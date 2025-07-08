using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("Pagos")]
    public class Pago
    {
        public int PagoId { get; set; }
        public int IdReserva { get; set; }
        public virtual Reserva Reserva { get; set; }
        public DateOnly FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string FormaDePago { get; set; }
    }
}
