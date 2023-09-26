using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIFarmacia.Dtos;

    public class MedicamentoDto
    {
        public int Id { get; set;}
        public string Nombre {get; set;}
        public decimal Precio {get; set;}
        public int Stock {get; set;}
        public DateTime FechaVencimiento {get; set;}
        public int IdEstadoFK {get; set;}
        public Boolean EstadoReceta {get; set;}
        public int IdCategoriaFK {get; set;}
        public string Presentacion {get; set;}
        public int IdMarcaFk {get; set;}
        
    }
