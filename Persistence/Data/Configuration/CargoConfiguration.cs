
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Configuration;
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("cargos");

            builder.Property(p=> p.Descripcion)
            .HasColumnName("nombre")
            .HasMaxLength(50)
            .IsRequired();

        }
    }
