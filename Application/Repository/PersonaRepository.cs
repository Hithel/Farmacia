using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;

    public class PersonaRepository : GenericRepository<Persona>, IPersona
{
    protected readonly FarmaciaContext _context;
    
    public PersonaRepository(FarmaciaContext context) : base (context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Persona>> GetAllAsyncPaciente()
    {
        return await _context.Personas
        .Where(p=> p.Cargo.Descripcion.ToUpper()== "PACIENTE")
        .Include(p => p.TipoDocumento)
        .Include(p => p.TipoPersona)
        .Include(p => p.Cargo)


            .ToListAsync();
    }
    public async Task<IEnumerable<Persona>> GetAllAsyncEmpleado()
    {
        return await _context.Personas
        .Where(p=> p.Cargo.Descripcion.ToUpper()== "EMPLEADO")
        .Include(p => p.TipoDocumento)
        .Include(p => p.TipoPersona)
        .Include(p => p.Cargo)


            .ToListAsync();
    }

    public async Task<IEnumerable<Persona>> GetAllAsyncAdministrador()
    {
        return await _context.Personas
        .Where(p=> p.Cargo.Descripcion.ToUpper()== "ADMINISTRADOR")
        .Include(p => p.TipoDocumento)
        .Include(p => p.TipoPersona)
        .Include(p => p.Cargo)


            .ToListAsync();
    }

    public async Task<IEnumerable<Persona>> GetAllAsyncDoctor()
    {
        return await _context.Personas
        .Where(p=> p.Cargo.Descripcion.ToUpper()== "DOCTOR")
        .Include(p => p.TipoDocumento)
        .Include(p => p.TipoPersona)
        .Include(p => p.Cargo)


            .ToListAsync();
    }

    public override async Task<Persona> GetByIdAsync(int id)
    {
        return await _context.Personas

        .Include(p => p.TipoDocumento)
        .Include(p => p.TipoPersona)
        .Include(p => p.Cargo)

        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
    

    public async Task<IEnumerable<Persona>> GetPersonasConMasVentas()
    {
        return await _context.Personas
            .Where(p => p.Cargo.Descripcion == "Empleado")
            .ToListAsync();

    }
}