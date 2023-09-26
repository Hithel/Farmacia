using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;

public class PersonaContactoRepository: GenericRepository<PersonaContacto>, IPersonaContacto
{
    protected readonly  FarmaciaContext _context;
    
    public PersonaContactoRepository( FarmaciaContext context) : base (context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<PersonaContacto>> GetAllAsync()
    {
        return await _context.PersonaContactos
        
            .ToListAsync();
    }

    public override async Task<PersonaContacto> GetByIdAsync(int id)
    {
        return await _context.PersonaContactos
        
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}
