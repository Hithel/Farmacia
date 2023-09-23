using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

    public class PersonaContacto : BaseEntity
    {
        public string Contacto {get; set;}

        /*llaves*/
        public int IdPersonaFk {get; set;}
        public Persona Persona {get; set;}
        public int IdTipoContactoFk {get; set;}
        public TipoContacto TipoContacto {get; set;}
    }
