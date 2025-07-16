using Microsoft.EntityFrameworkCore;
using MODELO.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Context : DbContext
    {
        private string cadena_conexion = "Data Source=DESKTOP-VQDCHA3\\SQLEXPRESS;Initial Catalog=Sistema_IDS;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<Cabaña> Cabañas { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(cadena_conexion);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Grupo>()
                .HasMany(g => g.Permisos)
                .WithMany(p => p.Grupos)
                .UsingEntity(j => j.ToTable("GrupoPermisos"));

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Grupo)
                .WithMany()
                .HasForeignKey(u => u.GrupoId)
                .OnDelete(DeleteBehavior.Cascade); 
        }

    }
}
