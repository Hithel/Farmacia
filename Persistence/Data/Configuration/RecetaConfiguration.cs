

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class RecetaConfiguration : IEntityTypeConfiguration<Receta>
        {
            public void Configure(EntityTypeBuilder<Receta> builder)
            {
                builder.ToTable("Receta");

                builder.Property(e => e.FechaCrecion)
                .HasColumnName("FechaCrecion")
                .IsRequired()
                .HasColumnType("DateTime");

                builder.Property(e => e.FechaExpiracion)
                .HasColumnName("FechaExpiracion")
                .IsRequired()
                .HasColumnType("DateTime");

                builder.Property(p=> p.Descripcion)
                .HasColumnName("Descripcion")
                .HasMaxLength(50)
                .IsRequired();

                builder.HasOne(p => p.Doctor)
                .WithMany(p => p.RecetasDoc)
                .HasForeignKey(p => p.IdDoctorFK);

                builder.HasOne(p => p.Paciente)
                .WithMany(p => p.RecetasPac)
                .HasForeignKey(p => p.IdPacienteFK);

                builder.HasOne(p => p.Factura)
                .WithMany(p => p.Recetas)
                .HasForeignKey(p => p.IdFacturaFK);
            }
        }
