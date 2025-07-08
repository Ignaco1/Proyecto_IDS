using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Composite
{
    public class PermisoCompuesto:Permiso
    {
        public List<Permiso> Permisos { get; set; } = new();

        public override void Mostrar(int nivel = 0)
        {
            Console.WriteLine($"{new string('-', nivel)} - {Nombre}");
            foreach (var permiso in Permisos)
            {
                permiso.Mostrar(nivel + 2);
            }
        }

        public void AgregarPermiso(Permiso permiso)
        {
            Permisos.Add(permiso);
        }

        public void EliminarPermiso(Permiso permiso)
        {
            Permisos.Remove(permiso);
        }
    }
}
