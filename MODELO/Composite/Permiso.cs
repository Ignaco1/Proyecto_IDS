using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Composite
{
    [Table("Permisos")]
    public class Permiso
    {
        public int PermisoId { get; set; }
        public string Nombre { get; set; }
    }
}
