

namespace Domain.Entities;

    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        /*llaves*/
        public int IdPersonaFk {get; set;}
        public Persona Persona { get; set; }

        public int IdRol { get; set; }
        public Rol Rol{ get; set; }
    }
