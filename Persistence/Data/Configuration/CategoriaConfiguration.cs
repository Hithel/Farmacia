
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Configuration;
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria");

            builder.Property(p=> p.Nombre)
            .HasColumnType("nombre")
            .HasMaxLength(50)
            .IsRequired();

        }
    }
