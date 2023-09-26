using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;

    public class PersonaDireccionRepository :GenericRepository<PersonaDireccion>, IPersonaDireccion
    {
        protected readonly FarmaciaContext _context;
        
        public PersonaDireccionRepository(FarmaciaContext context) : base (context)
        {
            _context = context;
        }
    
        public override async Task<IEnumerable<PersonaDireccion>> GetAllAsync()
        {
            return await _context.PersonaDirecciones
                .Include(p => p.Persona)
                .ToListAsync();
        }
    
        public override async Task<PersonaDireccion> GetByIdAsync(int id)
        {
            return await _context.PersonaDirecciones
            .Include(p => p.Persona)
            .FirstOrDefaultAsync(p =>  p.Id == id);
        }
    }
