using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIFarmacia.Dtos;

    public class PersonaDto
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public DateTime FechaRegistro {get; set;}
        public int IdTipoPersonaFk { get; set; }
        public int IdCargoFk { get; set; }

    }
