
namespace Domain.Entities;

    public class PersonaDireccion : BaseEntity
    {
        public string Descripcion {get; set;}

        /*llaves*/
        public int IdPersonaFk {get; set;}
        public Persona Persona {get; set;}
        public int IdCiudadFk {get; set;}
        public Ciudad Ciudad {get; set;}
    }
