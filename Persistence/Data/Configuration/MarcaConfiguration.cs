using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Configuration
{
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Marca> builder)
        {
            builder.ToTable("marca");
            builder.Property(p=> p.Nombre)
            .HasColumnName("nombre")
            .HasMaxLength(50)
            .IsRequired();
            
        }
    }
}