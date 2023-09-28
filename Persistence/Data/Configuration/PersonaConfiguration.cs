

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
        {
            public void Configure(EntityTypeBuilder<Persona> builder)
            {
                builder.ToTable("personas");
    
                builder.Property(e => e.Nombre)
                .HasColumnName("Nombre")
                .IsRequired()
                .HasMaxLength(50);

                builder.Property(e => e.FechaRegistro)
                .HasColumnName("FechaRegistro")
                .IsRequired()
                .HasColumnType("DateTime");

                builder.HasOne(p => p.TipoDocumento)
                .WithMany(p => p.Personas)
                .HasForeignKey(p => p.IdTipoDocumentoFk);

                builder.HasOne(p => p.TipoPersona)
                .WithMany(p => p.Personas)
                .HasForeignKey(p => p.IdTipoPersonaFk);

                builder.HasOne(p => p.Cargo)
                .WithMany(p => p.Personas)
                .HasForeignKey(p => p.IdCargoFk);

                
            }
        }
