

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class TipoDocumentoConfiguration : IEntityTypeConfiguration<TipoDocumento>
        {
            public void Configure(EntityTypeBuilder<TipoDocumento> builder)
            {
                builder.ToTable("TipoDocumento");

            builder.Property(p=> p.Descripcion)
            .HasColumnType("nombre")
            .HasMaxLength(50)
            .IsRequired();
            }
        }
