using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Composite
{
    [Table("Grupos")]
    public class Grupo
    {
        [Key]
        public int GrupoId { get; set; }

        [Required]
        public string Nombre { get; set; }

        public virtual ICollection<Permiso> Permisos { get; set; } = new List<Permiso>();

        public override string ToString()
        {
            return Nombre;
        }
    }
}
