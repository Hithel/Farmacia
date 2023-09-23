using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

    public class TipoContacto : BaseEntity
    {
        public string Descripcion {get; set;}

        /*llaves*/
        public ICollection<PersonaContacto> PersonaContactos {get; set;}
        public ICollection<ProveedorContacto> ProveedorContactos{get; set;}
    }
