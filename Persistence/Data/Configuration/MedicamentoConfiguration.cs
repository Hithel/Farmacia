using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class MedicamentoConfiguration : IEntityTypeConfiguration<Medicamento>
    {
        public void Configure(EntityTypeBuilder<Medicamento> builder)
        {
            builder.ToTable("medicamento");

            builder.Property(p=> p.Nombre).HasColumnName("nombre").HasMaxLength(50).IsRequired();
            builder.Property(p=> p.Precio).HasColumnName("precio").HasColumnType("decimal(10,10)").IsRequired();
            builder.Property(p=> p.Stock).HasColumnName("stock").HasColumnType("int").HasMaxLength(6).IsRequired();
            builder.Property(p=> p.FechaVencimiento).HasColumnName("fechavencimiento").HasColumnType("datetime").IsRequired();

            
        }
    }
}