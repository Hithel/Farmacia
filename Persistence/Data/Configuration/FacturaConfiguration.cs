
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Configuration;
    public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Factura> builder)
        {
            builder.ToTable("facturas");
            builder.Property(p=> p.Fecha)
            .HasColumnName("fecha")
            .HasColumnType("datetime")
            .IsRequired();

            builder.Property(p=> p.Total)
            .HasColumnName("total")
            .HasColumnType("decimal(10,10)")
            .IsRequired();

            builder.HasOne(p=> p.Persona)
            .WithMany(p=> p.Facturas)
            .HasForeignKey(p=>p.IdPersonaFk);

            builder.HasOne(p=> p.Persona)
            .WithMany(p=> p.Facturas)
            .HasForeignKey(p=>p.IdDoctorFk);

        }
    }
