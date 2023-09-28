using Domain.Entities;

namespace Domain.Interfaces;

public interface IMedicamento : IGenericRepo<Medicamento>
{
    Task<IEnumerable<Medicamento>> GetStockLess50Async(int cantidad);
}