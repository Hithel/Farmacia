using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

    public class Ciudad : BaseEntity
    {
        public string Nombre {get; set;}

        /*llaves*/
        public int IdDepartamentoFk {get; set;}
        public Departamento Departamento {get; set;}
        public ICollection<PersonaDireccion> PersonaDirecciones {get; set;}
        public ICollection<ProveedorDireccion> ProveedorDirecciones {get; set;}
    }
