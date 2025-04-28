using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("Alquileres")]
    public class Alquiler
    {
        public int AlquilerId { get; set; }
        public Cabaña Nombre_cabaña {  get; set; }
        public Cliente Cliente { get; set; }
        public DateOnly Fecha_Inicio { get; set; }
        public DateOnly Fecha_Fin { get; set; }

    }
}
