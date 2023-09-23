using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

    public class TipoPersona : BaseEntity
    {
        public int Descripcion {get; set;}

        /*llaves*/
        public ICollection<Persona> Personas {get; set;}
    }
