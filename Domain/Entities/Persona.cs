

namespace Domain.Entities;

    public class Persona : BaseEntity
    {
        public string Nombre {get; set;}
        public DateTime FechaRegistro {get; set;}

        /*llaves*/
        public int IdTipoDocumentoFk {get; set;}
        public TipoDocumento TipoDocumento {get; set;}
        public int IdTipoPersonaFk {get; set;}
        public TipoPersona TipoPersona {get; set;}
        public int IdCargoFk {get; set;}
        public Cargo Cargo {get; set;}
        public User User {get; set;}
        public ICollection<Receta> Recetas {get; set;}
        public ICollection<PersonaDireccion> PersonaDirecciones {get; set;}
        public ICollection<PersonaContacto> PersonaContactos {get; set;}
        public ICollection<CompraProveedor> CompraProveedores {get; set;}
        public ICollection<Factura> Facturas {get; set;}
    }
