using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace APIFarmacia.Dtos;

    public class RolDto:BaseEntity
    {
        public string Descripcion {get; set;}
    }
