
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Configuration;
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categorias");

            builder.Property(p=> p.Nombre)
            .HasColumnName("nombre")
            .HasMaxLength(50)
            .IsRequired();

        }
    }
