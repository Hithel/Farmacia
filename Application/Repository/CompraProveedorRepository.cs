
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
    public class CompraProveedorRepository : GenericRepository<CompraProveedor>, ICompraProveedor
    {
        private readonly FarmaciaContext _context;
    
        public CompraProveedorRepository(FarmaciaContext context) : base(context)
        {
            _context = context;
        }
    
        public override async Task<IEnumerable<CompraProveedor>> GetAllAsync()
            {
                return await _context.CompraProveedores
                .Include(p => p.MedicamentoComprados)
                .ToListAsync();
            }
    
            public override async Task<CompraProveedor> GetByIdAsync(int id)
            {
                return await _context.CompraProveedores
                .Include(p => p.MedicamentoComprados)
                .FirstOrDefaultAsync(p => p.Id == id);
            }
    }