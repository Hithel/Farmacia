
namespace Domain.Entities;
    public class Medicamento : BaseEntity
    {
        public string Nombre {get; set;}
        public decimal Precio {get; set;}
        public int Stock {get; set;}
        public DateTime FechaVencimiento {get; set;}
        public int IdEstadoFK {get; set;}
        public Estado Estado {get; set;}
        public Boolean EstadoReceta {get; set;}
        public int IdCategoriaFK {get; set;}
        public Categoria Categoria {get; set;}
        public int IdMarcaFk {get; set;}
        public Marca Marca {get; set;}
        public ICollection<MedicamentoReceta> MedicamentoRecetas {get; set;}
        public ICollection<Receta> Recetas {get; set;}
        public ICollection<MedicamentoVendido> MedicamentoVendidos {get; set;}
        public ICollection<Factura> Facturas {get; set;}
        public ICollection<Presentacion> Presentaciones {get; set;}
        public ICollection<TipoPresentacion> TiposPresentacion {get; set;} = new HashSet<TipoPresentacion>();
        public ICollection<Marca> Marcas {get; set;}
        public ICollection<MedicamentoComprado> MedicamentoComprados {get; set;}
    }
