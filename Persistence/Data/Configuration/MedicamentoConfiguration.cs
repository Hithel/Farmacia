
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Persistence.Data.Configuration;
    public class MedicamentoConfiguration : IEntityTypeConfiguration<Medicamento>
    {
        public void Configure(EntityTypeBuilder<Medicamento> builder)
        {
            builder.ToTable("medicamento");

            builder.Property(p=> p.Nombre)
            .HasColumnName("nombre")
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(p=> p.Precio)
            .HasColumnName("precio")
            .HasColumnType("decimal(10,10)")
            .IsRequired();

            builder.Property(p=> p.Stock)
            .HasColumnName("stock")
            .HasColumnType("int").HasMaxLength(6)
            .IsRequired();

            builder.Property(p=> p.FechaVencimiento)
            .HasColumnName("fechavencimiento")
            .HasColumnType("datetime")
            .IsRequired();

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Medicamentos)
            .HasForeignKey(p => p.IdEstadoFK);

            builder.HasOne(p => p.Categoria)
            .WithMany(p => p.Medicamentos)
            .HasForeignKey(p => p.IdCategoriaFK);

            builder.HasOne(p => p.Marca)
            .WithMany(p => p.Medicamentos)
            .HasForeignKey(p => p.IdMarcaFk);

            builder
            .HasMany(p => p.TiposPresentacion) /* TipoPresentacion */
            .WithMany(r => r.Medicamentos)
            .UsingEntity<Presentacion>(

                j => j
                .HasOne(pt => pt.Medicamento)
                .WithMany(t => t.Presentacion)
                .HasForeignKey(ut => ut.IdMedicamentoFk),


                j => j
                .HasOne(et => et.TipoPresentacion)
                .WithMany(et => et.Presentaciones)
                .HasForeignKey(el => el.IdTipoPresentacionFk),

                j =>
                {
                    j.ToTable("Presentacion");
                    j.HasKey(t => new { t.IdMedicamentoFk, t.IdTipoPresentacionFk });

                });

        }
    }
