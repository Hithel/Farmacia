using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository
{
    public class ProveedorContactoRepository : GenericRepository<ProveedorContacto>, IProveedorContacto
    {
        protected readonly FarmaciaContext _context;
        
        public ProveedorContactoRepository(FarmaciaContext context) : base (context)
        {
            _context = context;
        }
    
        public override async Task<IEnumerable<ProveedorContacto>> GetAllAsync()
        {
            return await _context.ProveedorContactos
                .Include(p => p.TipoContacto)
                .ToListAsync();
        }
    
        public override async Task<ProveedorContacto> GetByIdAsync(int id)
        {
            return await _context.ProveedorContactos
            .Include(p => p.TipoContacto)
            .FirstOrDefaultAsync(p =>  p.Id == id);
        }
        
    }
}