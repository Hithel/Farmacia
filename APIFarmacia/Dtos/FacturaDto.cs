using Domain.Entities;

namespace APIFarmacia.Dtos;

public class FacturaDto : BaseEntity
    {
        public DateTime Fecha { get; set;}
        public decimal Total {get; set;}
        public int IdPersonaFk {get; set;}        
        public int IdDoctorFk {get; set;}        
    }