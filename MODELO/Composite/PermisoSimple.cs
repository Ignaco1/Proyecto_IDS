using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Composite
{
    public class PermisoSimple : Permiso
    {
        public override void Mostrar(int nivel = 0)
        {
            Console.WriteLine($"{new string('-', nivel)} - {Nombre}");
        }
    }
}
