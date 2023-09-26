using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIFarmacia.Dtos;

    public class RecetaDto
    {
        public int Id {get; set;}
        public int IdDoctorFK {get; set;}
        public int IdPacienteFK { get; set; }
        public DateTime FechaCrecion {get; set;}
        public DateTime FechaExpiracion {get; set;}
        public string Descripcion {get; set;}
    }
