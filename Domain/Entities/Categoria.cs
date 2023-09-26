

namespace Domain.Entities;
    public class Categoria : BaseEntity
    {
        public string Nombre {get; set;}
        public ICollection<Medicamento> Medicamentos {get; set;}

    }
