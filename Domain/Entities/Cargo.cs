using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

    public class Cargo
    {
        public string Descripcion {get; set;}

        /*llaves*/
        public ICollection<Persona> Personas {get; set;}
    }
