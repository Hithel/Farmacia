
namespace Domain.Entities;
    public class MedicamentoReceta 
    {
        public int IdMedicamentoFk {get; set;}
        public Medicamento Medicamento {get; set;}
        public int IdRecetaFk {get; set;}
        public Receta Receta {get; set;}
    }
