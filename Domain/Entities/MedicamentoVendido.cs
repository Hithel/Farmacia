
namespace Domain.Entities;
    public class MedicamentoVendido : BaseEntity
    {
        public int IdMedicamentoFk {get; set;}
        public Medicamento Medicamento {get; set;}
        public int IdFacturaFK {get; set;}
        public Factura Factura {get; set;}
    }
