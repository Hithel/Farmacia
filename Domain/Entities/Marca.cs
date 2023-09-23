
namespace Domain.Entities;
    public class Marca
    {
        public string Nombre {get; set;}
        public ICollection<Medicamento> Medicamentos {get; set;}
        
    }
