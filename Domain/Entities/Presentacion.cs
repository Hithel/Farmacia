

namespace Domain.Entities;
public class Presentacion : BaseEntity
{
    public int IdMedicamentoFk { get; set; }
    public Medicamento Medicamento { get; set; }
    public int IdTipoPresentacionFk { get; set; }
    public TipoPresentacion TipoPresentacion { get; set; }
}
