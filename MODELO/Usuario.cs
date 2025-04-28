using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("Usuarios")]
    public class Usuario
    {
        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Nombre_usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nivel_acceso { get; set; }
    }
}
