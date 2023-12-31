
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.ToTable("paises");
        builder.Property(p =>p.Nombre)
        .HasColumnName("nombre")
        .HasMaxLength(120)
        .IsRequired();

        

    }
}
