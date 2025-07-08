using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO.Composite;

namespace MODELO
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre_usuario { get; set; }
        public string Contraseña { get; set; }
        public string Email { get; set; }
        public virtual Grupo Grupo { get; set; }

    }
}
