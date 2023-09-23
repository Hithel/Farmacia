

namespace Domain.Entities;
    public class Presentacion
    {
        public int IdMedicamentoFk { get; set; }
        public Medicamento Medicamento { get; set; }
        public int IdTipoPresentacionFk { get; set; }
        public TipoPresentacion TipoPresentacion { get; set; }
    }
