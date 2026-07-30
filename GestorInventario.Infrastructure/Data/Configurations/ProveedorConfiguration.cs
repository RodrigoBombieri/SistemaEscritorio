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
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("Proveedores");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.RazonSocial).IsRequired().HasMaxLength(150);
            builder.Property(p => p.CUIT).HasMaxLength(20);
        }
    }
}