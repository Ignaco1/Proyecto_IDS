using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("Usuarios")]
    public abstract class Usuario
    {
        public int UsuarioId { get; set; }
        public string Tipo_usuario { get; set; }
        public string Nombre_usuario { get; set; }
        public string Contraseña { get; set; }
        public string Email { get; set; }
        public abstract List<string> Permisos { get;}
        public string PermisosTexto => string.Join(", ", Permisos);
    }
}
