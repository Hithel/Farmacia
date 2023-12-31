
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Configuration;
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Marca> builder)
        {
            builder.ToTable("marcas");
            
            builder.Property(p=> p.Nombre)
            .HasColumnName("nombre")
            .HasMaxLength(50)
            .IsRequired();
            
        }
    }
