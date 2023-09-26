using Domain.Entities;

namespace Domain.Interfaces;

public interface IPersona : IGenericRepo<Persona>
{
    Task<IEnumerable<Persona>> GetAllAsyncPaciente();
    Task<IEnumerable<Persona>> GetAllAsyncEmpleado();
    Task<IEnumerable<Persona>> GetAllAsyncDoctor();
    Task<IEnumerable<Persona>> GetAllAsyncAdministrador();
    Task<IEnumerable<Persona>> GetPersonasConMasVentas();
}
