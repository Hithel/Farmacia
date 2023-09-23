
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
        {
            public void Configure(EntityTypeBuilder<Rol> builder)
            {
                builder.ToTable("Rol");

                builder.Property(p=> p.Descripcion)
                .HasColumnType("nombre")
                .HasMaxLength(50)
                .IsRequired();
    
            }
        }