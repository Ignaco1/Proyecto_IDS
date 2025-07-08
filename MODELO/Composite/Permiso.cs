using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Composite
{
    public abstract class Permiso
    {
        public int PermisoId { get; set; }
        public string Nombre { get; set; }

        public abstract void Mostrar(int nivel = 0);
    }
}
