

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
        {
            public void Configure(EntityTypeBuilder<TipoPersona> builder)
            {
                builder.ToTable("tiposPersonas");

                builder.Property(p=> p.Descripcion)
                .HasColumnName("Descripcion")
                .HasMaxLength(50)
                .IsRequired();
            }
        }
