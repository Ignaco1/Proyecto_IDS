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
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<PermisoSimple> PermisosSimples { get; set; }
        public DbSet<PermisoCompuesto> PermisosCompuestos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(cadena2);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permiso>()
                .HasDiscriminator<string>("TipoPermiso")
                .HasValue<PermisoSimple>("Simple")
                .HasValue<PermisoCompuesto>("Compuesto");

            modelBuilder.Entity<PermisoCompuesto>()
                .HasMany(p => p.Permisos)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Grupo)
                .WithMany()
                .HasForeignKey("GrupoId") 
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Grupo>()
                .HasMany(g => g.Permisos)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

    }
}
