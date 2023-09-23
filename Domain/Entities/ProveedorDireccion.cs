using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

    public class ProveedorDireccion : BaseEntity
    {
        
        public string Descripcion {get; set;}

        /*llaves*/
        public int IdCiudadFk {get; set;}
        public Ciudad Ciudad {get; set;}
        public int IdProveedorFk {get; set;}
        public Proveedor Proveedor {get; set;}
    }
