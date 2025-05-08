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
        public int Capacidad { get; set; }
        public decimal PrecioPorNoche { get; set; }
        public string Descripcion { get; set; }
        public bool Activa { get; set; }

    }
}
