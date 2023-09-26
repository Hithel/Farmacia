

namespace Domain.Entities;
    public class Factura : BaseEntity
    {
        public DateTime Fecha { get; set;}
        public decimal Total {get; set;}

        public int IdPersonaFk {get; set;}
        public Persona Persona {get; set;}

        public int IdDoctorFk {get; set;}
        public Persona PersonaDoctor {get; set;}

        public ICollection<Medicamento> Medicamentos {get; set;}
        public ICollection<MedicamentoVendido> MedicamentoVendidos {get; set;}
    }
