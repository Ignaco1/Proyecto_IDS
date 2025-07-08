using Microsoft.EntityFrameworkCore;
using MODELO.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Context: DbContext
    {
        private string cadena2 = "Data Source=RCAL1304P02-835;Initial Catalog=Sistema_cabañas;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";
        private string cadena_conexion = "Data Source=DESKTOP-VQDCHA3\\SQLEXPRESS;Initial Catalog=Sistema_cabañas;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<Cabaña> Cabañas { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Grupo> Grupos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(cadena2);



    }
}
