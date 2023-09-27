using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace APIFarmacia.Dtos;

    public class PersonaContactoDto:BaseEntity
    {
        public string Contacto {get; set;}
        public int IdPersonaFk {get; set;}
        public int IdTipoContactoFk {get; set;}
    }
