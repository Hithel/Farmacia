
using Domain.Entities;

namespace APIFarmacia.Dtos;
    public class RecetaDto : BaseEntity
    {
        public int IdDoctorFK {get; set;}
        public int IdPacienteFK { get; set; }
        public DateTime FechaCrecion {get; set;}
        public DateTime FechaExpiracion {get; set;}
        public string Descripcion {get; set;}
    }
