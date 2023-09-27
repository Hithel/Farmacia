using Domain.Entities;

namespace APIFarmacia.Dtos;
public class CompraProveedorDto : BaseEntity
{
    public DateTime FechaCompra {get; set;}
    public int IdProveedorFk {get; set;}    
    public int IdPersonaFk {get; set; }
    
}
