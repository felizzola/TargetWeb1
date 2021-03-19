using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetWeb1.Models;

namespace TargetWeb1.Database
{
    public class PortalTargetDbContext : DbContext
    {
        public PortalTargetDbContext(DbContextOptions<PortalTargetDbContext> options) : base(options)
        {

        }
        public DbSet<Articulo> Articulos { get; set; }
  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use Fluent API to configure  

            // Map entities to tables  
            modelBuilder.Entity<Articulo>().ToTable("UserGroups");
            

            // Configure Primary Keys  
            modelBuilder.Entity<Articulo>().HasKey(ug => ug.Id).HasName("PK_UserGroups");

            // Configure indexes  
            modelBuilder.Entity<Articulo>().HasIndex(p => p.Codigo).IsUnique().HasDatabaseName("Idx_Name");


            // Configure columns  
            //  modelBuilder.Entity<Articulo>().Property(ug => ug.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
           // modelBuilder.Entity<Articulo>().Property(ug => ug.Id);
            modelBuilder.Entity<Articulo>().Property(ug => ug.FechaAlta);
            modelBuilder.Entity<Articulo>().Property(ug => ug.UrlImagen);
            modelBuilder.Entity<Articulo>().Property(ug => ug.Codigo);
            modelBuilder.Entity<Articulo>().Property(ug => ug.Nombre);
            modelBuilder.Entity<Articulo>().Property(ug => ug.Descripcion);
            modelBuilder.Entity<Articulo>().Property(ug => ug.StockUnidades);
            modelBuilder.Entity<Articulo>().Property(ug => ug.StockEnBulto);
            modelBuilder.Entity<Articulo>().Property(ug => ug.PrecioSugMinorista);
            modelBuilder.Entity<Articulo>().Property(ug => ug.PrecioSugMayorista);
            modelBuilder.Entity<Articulo>().Property(ug => ug.StockUnidades);
            modelBuilder.Entity<Articulo>().Property(ug => ug.PrecioSugMeLi);

            // Configure relationships  
        }
    }
}