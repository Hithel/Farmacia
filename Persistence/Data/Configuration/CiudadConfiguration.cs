using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Configuration
{
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Ciudad> builder)
        {
            builder.ToTable("ciudad");
            builder.Property(p=> p.Nombre)
            .HasColumnType("nombre")
            .HasMaxLength(50)
            .IsRequired();

            builder.HasOne(p=> p.Departamento)
            .WithMany(p=> p.Ciudades)
            .HasForeignKey(p=> p.IdDepartamentoFk);
        }
    }
}