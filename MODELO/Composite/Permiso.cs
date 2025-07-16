using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Composite
{
    [Table("Permisos")]
    public class Permiso
    {
        [Key]
        public int PermisoId { get; set; }

        [Required]
        public string Nombre { get; set; }

        public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();

        public override string ToString()
        {
            return Nombre;
        }
    }
}
