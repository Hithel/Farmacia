

namespace Domain.Entities;
    public class Presentacion
    {
        public int IdMedicamentoFk { get; set;}
        public Medicamento MedicamentoFk { get; set; }
        public int IdTipoPresentacionFk { get; set; }
        public TipoPresentacion TipoPresentacionFk { get; set; }
    }
