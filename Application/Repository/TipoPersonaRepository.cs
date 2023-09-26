

using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository; 
    public class TipoPersonaRepository : GenericRepository<TipoPersona>, ITipoPersona
    {
        protected readonly FarmaciaContext _context;
        
        public TipoPersonaRepository(FarmaciaContext context) : base (context)
        {
            _context = context;
        }
    
        public override async Task<IEnumerable<TipoPersona>> GetAllAsync()
        {
            return await _context.TipoPersonas
                .Include(p => p.Personas)
                .ToListAsync();
        }
    
        public override async Task<TipoPersona> GetByIdAsync(int id)
        {
            return await _context.TipoPersonas
            .Include(p => p.Personas)
            .FirstOrDefaultAsync(p =>  p.Id == id);
        }
    }
