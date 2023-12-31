
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class PersonaDireccionConfiguration : IEntityTypeConfiguration<PersonaDireccion>
        {
            public void Configure(EntityTypeBuilder<PersonaDireccion> builder)
            {
                builder.ToTable("personasDirecciones");
    
                builder.Property(p=> p.Descripcion)
                .HasColumnName("Descripcion")
                .HasMaxLength(50)
                .IsRequired();

                builder.HasOne(p => p.Persona)
                .WithMany(p => p.PersonaDirecciones)
                .HasForeignKey(p => p.IdPersonaFk);

                builder.HasOne(p => p.Ciudad)
                .WithMany(p => p.PersonaDirecciones)
                .HasForeignKey(p => p.IdCiudadFk);
            }
        }
