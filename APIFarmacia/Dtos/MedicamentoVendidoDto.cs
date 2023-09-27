using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace APIFarmacia.Dtos;

    public class MedicamentoVendidoDto:BaseEntity
    {   
        public int IdMedicamentoFk {get; set;}
        public int IdFacturaFK {get; set;}
        public int IdRecetaFk {get; set;}

    }
