using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("Cabañas")]
    public class Cabaña
    {
        public int CabañaId {  get; set; }
        public string Nombre { get; set; }
        public int Habitaciones { get; set; }
        public double Precio_estadia {  get; set; }

    }
}
