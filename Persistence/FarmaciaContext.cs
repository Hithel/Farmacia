using Domain.Entities;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
    public class FarmaciaContext : DbContext
        {
            public FarmaciaContext(DbContextOptions<FarmaciaContext> options) : base(options)
            {
            
            }

            public DbSet<Cargo> Cargos  { get; set; }
            public DbSet<Categoria> Categorias  { get; set; }
            public DbSet<Ciudad> Ciudades  { get; set; }
            public DbSet<CompraProveedor> CompraProveedores  { get; set; }
            public DbSet<Departamento> Departamentos  { get; set; }
            public DbSet<Estado> Estados  { get; set; }
            public DbSet<Factura> Facturas  { get; set; }
            public DbSet<Marca> Marcas  { get; set; }
            public DbSet<Medicamento> Medicamentos  { get; set; }
            public DbSet<MedicamentoComprado> MedicamentoComprados  { get; set; }
            public DbSet<MedicamentoReceta> MedicamentoRecetas  { get; set; }
            public DbSet<MedicamentoVendido> MedicamentoVendidos  { get; set; }
            public DbSet<Pais> Paises  { get; set; }
            public DbSet<Persona> Personas  { get; set; }
            public DbSet<PersonaContacto> PersonaContactos  { get; set; }
            public DbSet<PersonaDireccion> PersonaDirecciones  { get; set; }
            public DbSet<Presentacion> Presentaciones  { get; set; }
            public DbSet<Proveedor> Proveedores  { get; set; }
            public DbSet<ProveedorContacto> ProveedorContactos  { get; set; }
            public DbSet<ProveedorDireccion> ProveedorDirecciones  { get; set; }
            public DbSet<Receta> Recetas  { get; set; }
            public DbSet<Rol> Roles  { get; set; }
            public DbSet<TipoContacto> TipoContactos  { get; set; }
            public DbSet<TipoDocumento> TipoDocumentos  { get; set; }
            public DbSet<TipoPersona> TipoPersonas  { get; set; }
            public DbSet<TipoPresentacion> TipoPresentaciones  { get; set; }
            public DbSet<User> Users  { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            }
        }
