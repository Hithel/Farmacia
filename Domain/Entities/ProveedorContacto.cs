using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

    public class ProveedorContacto : BaseEntity
    {
        public string Contacto {get; set;}

        /*llaves*/
        public int IdProveedorFk {get; set;}
        public Proveedor Proveedor {get; set;}
        public int IdTipoContactoFk{get; set;}
        public TipoContacto TipoContacto {get; set;}
    }
