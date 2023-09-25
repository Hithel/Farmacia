
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
        {
            public void Configure(EntityTypeBuilder<Proveedor> builder)
            {
                builder.ToTable("Proveedor");

                builder.Property(e => e.Nombre)
                .HasColumnName("Nombre")
                .IsRequired()
                .HasMaxLength(50);
            }
        }
