using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIFarmacia.Dtos;

    public class MedicamentoVendidoDto
    {   
        public int Id {get; set;}
        public int IdMedicamentoFk {get; set;}
        public int IdFacturaFK {get; set;}
        public int IdRecetaFk {get; set;}

    }
