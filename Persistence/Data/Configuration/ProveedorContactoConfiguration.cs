
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class ProveedorContactoConfiguration : IEntityTypeConfiguration<ProveedorContacto>
        {
            public void Configure(EntityTypeBuilder<ProveedorContacto> builder)
            {
                builder.ToTable("ProveedorContacto");
    
                builder.Property(p=> p.Contacto)
                .HasColumnType("nombre")
                .HasMaxLength(50)
                .IsRequired();

                builder.HasOne(p => p.Proveedor)
                .WithMany(p => p.ProveedorContactos)
                .HasForeignKey(p => p.IdProveedorFk);

                builder.HasOne(p => p.TipoContacto)
                .WithMany(p => p.ProveedorContactos)
                .HasForeignKey(p => p.IdTipoContactoFk);
            }
        }
