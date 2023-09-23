
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class CompraProveedorConfiguration : IEntityTypeConfiguration<CompraProveedor>
    {
        public void Configure(EntityTypeBuilder<CompraProveedor> builder)
        {
            builder.ToTable("compraproveedor");
            builder.Property(p=> p.FechaCompra)
            .HasColumnName("FechaCompra")
            .HasColumnType("datetime")
            .IsRequired();

            builder.HasOne(p=> p.Proveedor).WithMany(p=> p.CompraProveedores).HasForeignKey(P=> P.IdProveedorFk);
            builder.HasOne(p=> p.Persona).WithMany(p=> p.CompraProveedores).HasForeignKey(P=> P.IdPersonaFk);
        }
    }
