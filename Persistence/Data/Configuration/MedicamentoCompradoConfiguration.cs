

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class MedicamentoCompradoConfiguration : IEntityTypeConfiguration<MedicamentoComprado>
        {
            public void Configure(EntityTypeBuilder<MedicamentoComprado> builder)
            {
                builder.ToTable("medicamentosComprados");

            builder.Property(p=> p.PrecioCompra)
            .HasColumnName("PrecioCompra")
            .HasColumnType("decimal(10,10)")
            .IsRequired();
            builder.Property(p=> p.Cantidad)
            .HasColumnName("Cantidad")
            .HasColumnType("int")
            .HasMaxLength(6)
            .IsRequired();

            builder.HasOne(p => p.Compra)
            .WithMany(p => p.MedicamentoComprados)
            .HasForeignKey(p => p.IdCompraProveedorFk);

            builder.HasOne(p => p.Medicamento)
            .WithMany(p => p.MedicamentoComprados)
            .HasForeignKey(p => p.IdMedicamentoFk);
            }
        }
