using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        /*llaves*/
        public int IdPersonaFk {get; set;}
        public Persona Persona { get; set; }
    }
