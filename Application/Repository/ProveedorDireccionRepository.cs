using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;

    public class ProveedorDireccionRepository : GenericRepository<ProveedorDireccion>, IProveedorDireccion
    {
        protected readonly FarmaciaContext _context;
        
        public ProveedorDireccionRepository(FarmaciaContext context) : base (context)
        {
            _context = context;
        }
    
        public override async Task<IEnumerable<ProveedorDireccion>> GetAllAsync()
        {
            return await _context.ProveedorDirecciones
                .Include(p => p.Proveedor)
                .Include(p => p.Descripcion)
                .Include(p => p.Ciudad)
                .ToListAsync();
        }
    
        public override async Task<ProveedorDireccion> GetByIdAsync(int id)
        {
            return await _context.ProveedorDirecciones
            .Include(p => p.Proveedor)
            .Include(p => p.Descripcion)
            .Include(p => p.Ciudad)
            .FirstOrDefaultAsync(p =>  p.Id == id);
        }
    }
