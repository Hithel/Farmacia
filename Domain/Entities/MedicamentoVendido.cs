
namespace Domain.Entities;
    public class MedicamentoVendido
    {
        public int IdMedicamentoFk {get; set;}
        public Medicamento Medicamento {get; set;}
        public int IdFacturaFK {get; set;}
        public Factura Factura {get; set;}
    }
