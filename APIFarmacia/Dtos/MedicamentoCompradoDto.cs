using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIFarmacia.Dtos;

    public class MedicamentoCompradoDto
    {   
        public int Id {get; set;}
        public int IdCompraProveedorFk {get; set;}
        public int IdMedicamentoFk {get; set;}
        public int Cantidad {get; set;}
        public double PrecioCompra {get; set;}
        
    }
