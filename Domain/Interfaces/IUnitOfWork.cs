
namespace Domain.Interfaces;
    public interface IUnitOfWork
    {
        ICargo Cargos { get; }
        ICategoria Categorias { get; }
        ICiudad Ciudades { get; }
        ICompraProveedor CompraProveedores { get; }
        IDepartamento Departamentos { get; }
        IEstado Estados { get; }
        IFactura Facturas { get; }
        IMarca Marcas { get; }
        IMedicamento Medicamentos { get; }
        IMedicamentoComprado MedicamentoComprados { get; }
        IMedicamentoVendido MedicamentoVendidos {get; }
        IPais Paises { get; }
        IPersona Personas { get; }
        IPersonaContacto PersonaContactos { get; }
        IPersonaDireccion PersonaDirecciones { get; }
        IProveedor Proveedores { get; }
        IProveedorContacto ProveedorContactos { get; }
        IProveedorDireccion ProveedorDirecciones { get; }
        IReceta Recetas { get; }
        IRol Roles { get; }
        ITipoContacto TipoContactos { get; }
        ITipoDocumento TipoDocumentos { get; }
        ITipoPersona TipoPersonas { get; }
        IUser Users { get; }
        Task<int> SaveAsync();
    }
