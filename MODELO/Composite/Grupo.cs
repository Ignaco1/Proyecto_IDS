using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Composite
{
    [Table("Grupos")]
    public class Grupo
    {
        public int GrupoId { get; set; }
        public string Nombre { get; set; }
        public virtual List<Permiso> Permisos { get; set; } = new();
    }
}
