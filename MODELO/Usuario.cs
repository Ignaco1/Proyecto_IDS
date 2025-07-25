﻿using MODELO.Composite;
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
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nombre_usuario { get; set; }
        public string? Contraseña { get; set; }
        public string Email { get; set; }

        public int GrupoId { get; set; }

        [ForeignKey("GrupoId")]
        public virtual Grupo Grupo { get; set; }

        public bool PrimerIngreso { get; set; } = true;
    }
}
