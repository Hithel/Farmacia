using Domain.Entities;

namespace APIFarmacia.Dtos;
public class DepartamentoDto : BaseEntity
{
    public string Nombre {get; set;}
    public int IdPaisFk {get; set;}
}
