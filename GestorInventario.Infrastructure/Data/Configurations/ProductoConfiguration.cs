using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GestorInventario.Domain.Entities;

namespace GestorInventario.Infrastructure.Data.Configurations
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Productos");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Codigo).IsRequired().HasMaxLength(50);
            builder.HasIndex(p => p.Codigo).IsUnique();

            builder.Property(p => p.Nombre).IsRequired().HasMaxLength(150);
            builder.Property(p => p.PrecioCosto).HasColumnType("decimal(18,2)");
            builder.Property(p => p.PrecioVenta).HasColumnType("decimal(18,2)");

            builder.HasOne(p => p.Categoria)
                   .WithMany(c => c.Productos)
                   .HasForeignKey(p => p.CategoriaId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Proveedor)
                   .WithMany(pr => pr.Productos)
                   .HasForeignKey(p => p.ProveedorId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}