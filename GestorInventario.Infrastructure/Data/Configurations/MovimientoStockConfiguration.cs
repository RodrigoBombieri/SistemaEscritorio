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
    public class MovimientoStockConfiguration : IEntityTypeConfiguration<MovimientoStock>
    {
        public void Configure(EntityTypeBuilder<MovimientoStock> builder)
        {
            builder.ToTable("MovimientosStock");
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Tipo).HasConversion<string>().HasMaxLength(20);
            builder.Property(m => m.Motivo).HasMaxLength(200);

            builder.HasOne(m => m.Producto)
                   .WithMany(p => p.Movimientos)
                   .HasForeignKey(m => m.ProductoId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Usuario)
                   .WithMany()
                   .HasForeignKey(m => m.UsuarioId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}