

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class ProveedorDireccionConfiguration : IEntityTypeConfiguration<ProveedorDireccion>
        {
            public void Configure(EntityTypeBuilder<ProveedorDireccion> builder)
            {
                builder.ToTable("proveedoresDirecciones");

                builder.Property(p=> p.Descripcion)
                .HasColumnName("Descripcion")
                .HasMaxLength(50)
                .IsRequired();

                builder.HasOne(p => p.Proveedor)
                .WithMany(p => p.ProveedorDirecciones)
                .HasForeignKey(p => p.IdProveedorFk);

                builder.HasOne(p => p.Ciudad)
                .WithMany(p => p.ProveedorDirecciones)
                .HasForeignKey(p => p.IdCiudadFk);
            }
        }
