
namespace Domain.Entities;
    public class Marca : BaseEntity
    {
        public string Nombre {get; set;}
        
        public ICollection<Medicamento> Medicamentos {get; set;}
        
    }
