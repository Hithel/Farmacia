
namespace Domain.Entities;
    public class CompraProveedor : BaseEntity
    {
        public DateTime FechaCompra {get; set;}
        public int IdProveedorFk {get; set;}
        public Proveedor Proveedor {get; set;}
        public int IdPersonaFk {get; set; }
        public Persona Persona {get; set;}
        public ICollection<MedicamentoComprado> MedicamentoComprados {get; set;}

    }
