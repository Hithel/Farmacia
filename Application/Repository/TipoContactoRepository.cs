using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;

    public class TipoContactoRepository : GenericRepository<TipoContacto>, ITipoContacto
    {
        protected readonly FarmaciaContext _context;
        
        public TipoContactoRepository(FarmaciaContext context) : base (context)
        {
            _context = context;
        }
    
        public override async Task<IEnumerable<TipoContacto>> GetAllAsync()
        {
            return await _context.TipoContactos
                
                .ToListAsync();
        }
    
        public override async Task<TipoContacto> GetByIdAsync(int id)
        {
            return await _context.TipoContactos
            
            .FirstOrDefaultAsync(p =>  p.Id == id);
        }
    }
