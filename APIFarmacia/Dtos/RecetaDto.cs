
using Domain.Entities;

namespace APIFarmacia.Dtos;
    public class RecetaDto : BaseEntity
    {
        public Persona Doctor { get; set; }
        public Persona Paciente { get; set; }
        public DateTime FechaCrecion {get; set;}
        public DateTime FechaExpiracion {get; set;}
        public string Descripcion {get; set;}
    }
