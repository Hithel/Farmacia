

namespace Domain.Entities;
    public class Receta : BaseEntity
    {
        public int IdDoctorFK {get; set;}
        public Persona Doctor { get; set; }
        public int IdPacienteFK { get; set; }
        public Persona Paciente { get; set; }
        public int IdMedicamentoRecetaFK { get; set;}
        public MedicamentoReceta MedicamentoReceta { get; set; }
        public DateTime FechaCrecion {get; set;}
        public DateTime FechaExpiracion {get; set;}
        public string Descripcion {get; set;}
        public ICollection<Medicamento> Medicamentos {get; set;}
        public ICollection<MedicamentoReceta>MedicamentoRecetas { get; set;}
        
    }
