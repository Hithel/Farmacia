

namespace Domain.Entities;
    public class MedicamentoComprado : BaseEntity
    {
        public int IdCompraProveedorFk {get; set;}
        public CompraProveedor Compra { get; set; }
        public int IdMedicamentoFk { get; set; }
        public Medicamento Medicamento { get; set; }
        public int Cantidad { get; set; }
        public double PrecioCompra {get; set;}
        public ICollection<Medicamento> Medicamentos {get; set;}

    }
