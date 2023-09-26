

using Domain.Entities;

namespace APIFarmacia.Dtos;
    public class ProveedorDireccionDto : BaseEntity
    {
        public string Descripcion {get; set;}

        /*llaves*/
        public Ciudad Ciudad {get; set;}
        public Proveedor Proveedor {get; set;}
    }
