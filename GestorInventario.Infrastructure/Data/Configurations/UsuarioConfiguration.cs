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
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.NombreUsuario).IsRequired().HasMaxLength(50);
            builder.HasIndex(u => u.NombreUsuario).IsUnique();

            builder.Property(u => u.Rol).HasConversion<string>().HasMaxLength(20);
        }
    }
}