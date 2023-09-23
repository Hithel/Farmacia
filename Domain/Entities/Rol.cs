using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

    public class Rol : BaseEntity
    {
        public string Descripcion {get; set;}

        /*llaves*/
        public ICollection<User> Users {get; set;}
    }
