

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class PersonaContactoConfiguration : IEntityTypeConfiguration<PersonaContacto>
        {
            public void Configure(EntityTypeBuilder<PersonaContacto> builder)
            {
                builder.ToTable("personasContactos");

    
                builder.Property(p=> p.Contacto)
                .HasColumnName("Contacto")
                .HasMaxLength(50)
                .IsRequired();

                builder.HasOne(p => p.Persona)
                .WithMany(p => p.PersonaContactos)
                .HasForeignKey(p => p.IdPersonaFk);

                builder.HasOne(p => p.TipoContacto)
                .WithMany(p => p.PersonaContactos)
                .HasForeignKey(p => p.IdTipoContactoFk);
            }
        }
    