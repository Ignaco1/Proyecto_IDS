using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Composite
{
    public abstract class Permiso
    {
        public string Nombre { get; set; }

        public Grupo a
        {
            get => default;
            set
            {
            }
        }

        public abstract void Mostrar(int nivel = 0);
    }
}
