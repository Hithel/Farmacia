using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;

    public class RecetaRepository: GenericRepository<Receta>, IReceta
    {
        protected readonly FarmaciaContext _context;
        
        public RecetaRepository(FarmaciaContext context) : base (context)
        {
            _context = context;
        }
    
        public override async Task<IEnumerable<Receta>> GetAllAsync()
        {
            return await _context.Recetas
            
            .Include(p => p.MedicamentoRecetas)
            
            .ToListAsync();
        }
    
        public override async Task<Receta> GetByIdAsync(int id)
        {
            return await _context.Recetas

            .Include(p => p.MedicamentoRecetas)
            
            .FirstOrDefaultAsync(p =>  p.Id == id);
        }
        
    }