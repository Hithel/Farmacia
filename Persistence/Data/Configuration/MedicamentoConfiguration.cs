
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
            .HasForeignKey(p => p.IdCategoriaFK);

            builder.HasOne(p => p.Marca)
            .WithMany(p => p.Medicamentos)
            .HasForeignKey(p => p.IdMarcaFk);

                builder
                .HasMany(p => p.Facturas) /* TipoPresentacion */
                .WithMany(r => r.Medicamentos)
                .UsingEntity<MedicamentoVendido>(

                    j => j
                    .HasOne(et => et.Factura)
                    .WithMany(et => et.MedicamentoVendidos)
                    .HasForeignKey(el => el.IdFacturaFK),

                    j => j
                    .HasOne(pt => pt.Medicamento)
                    .WithMany(t => t.MedicamentoVendidos)
                    .HasForeignKey(ut => ut.IdMedicamentoFk),
                    
                    j =>
                    {
                        j.ToTable("MedicamentoVendido");
                        j.HasKey(t => new { t.IdMedicamentoFk, t.IdFacturaFK });

                    });

                    builder
                .HasMany(p => p.Recetas) /* TipoPresentacion */
                .WithMany(r => r.Medicamentos)
                .UsingEntity<MedicamentoReceta>(

                    j => j
                    .HasOne(et => et.Receta)
                    .WithMany(et => et.MedicamentoRecetas)
                    .HasForeignKey(el => el.IdRecetaFk),

                    j => j
                    .HasOne(pt => pt.Medicamento)
                    .WithMany(t => t.MedicamentoRecetas)
                    .HasForeignKey(ut => ut.IdMedicamentoFk),
                    
                    j =>
                    {
                        j.ToTable("MedicamentoReceta");
                        j.HasKey(t => new { t.IdMedicamentoFk, t.IdRecetaFk });

                    });

/*dotnet ef database update --project ./Persistencia/ --startup-project ./API/
 */
        }
    }
