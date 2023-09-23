
namespace Domain.Entities;
    public class TipoPresentacion : BaseEntity
    {
        public string Nombre {get; set;}

        public ICollection<Medicamento> Medicamentos {get; set;} = new HashSet<Medicamento>();

        public ICollection<Presentacion> Presentaciones {get; set;}

    }
