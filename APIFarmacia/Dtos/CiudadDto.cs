using Domain.Entities;

namespace APIFarmacia.Dtos;
public class CiudadDto : BaseEntity
{
    public string Nombre {get; set;}

        /*llaves*/
    public int IdDepartamentoFk {get; set;}

        /*llaves*/
}
