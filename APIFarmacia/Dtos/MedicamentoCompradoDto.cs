using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace APIFarmacia.Dtos;

    public class MedicamentoCompradoDto:BaseEntity
    {   
        
        public int IdCompraProveedorFk {get; set;}
        public int IdMedicamentoFk {get; set;}
        public int Cantidad {get; set;}
        public double PrecioCompra {get; set;}
        
    }
