using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_COMUN.Cache
{
    public static class UsuarioCache
    {
        public static int UsuarioId { get; set; }
        public static string UsuarioNombre { get; set; }
        public static string UsuarioApellido { get; set; }
        public static string UsuarioNombre_usuario { get; set; }
        public static string UsuarioEmail { get; set; }
        public static string UsuarioGrupoNombre { get; set; }

        public static List<string> Permisos { get; set; } = new List<string>();

    }
}
