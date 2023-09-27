using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace APIFarmacia.Dtos;

    public class PersonaDto:BaseEntity
    {
        public string Nombre {get; set;}
        public DateTime FechaRegistro {get; set;}
        public int IdTipoPersonaFk { get; set; }
        public int IdCargoFk { get; set; }

    }
