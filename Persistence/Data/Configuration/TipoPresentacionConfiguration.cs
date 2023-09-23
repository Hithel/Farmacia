

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class TipoPresentacionConfiguration : IEntityTypeConfiguration<TipoPresentacion>
        {
            public void Configure(EntityTypeBuilder<TipoPresentacion> builder)
            {
                builder.ToTable("TipoPresentacion");

                builder.Property(p=> p.Nombre)
                .HasColumnType("nombre")
                .HasMaxLength(50)
                .IsRequired();
    
            }
        }
