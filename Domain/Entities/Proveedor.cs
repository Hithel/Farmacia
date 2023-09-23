

namespace Domain.Entities;

    public class Proveedor : BaseEntity
    {
        public string Nombre {get; set;}

        /*llaves*/
        public ICollection<ProveedorDireccion> ProveedorDirecciones {get; set;}
        public ICollection<ProveedorContacto> ProveedorContactos {get; set;}
        public ICollection<CompraProveedor> CompraProveedores {get; set;}
    }
