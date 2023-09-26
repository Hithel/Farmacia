using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIFarmacia.Dtos;

    public class ProveedorDireccionDto
    {
        public int Id {get; set;}
        public string Descripcion {get; set;}
        public int IdCiudadFk {get; set;}
        public int IdProveedorFk {get; set;}
    }
