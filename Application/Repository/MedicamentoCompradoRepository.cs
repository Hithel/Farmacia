

using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
    public class MedicamentoCompradoRepository : GenericRepository<MedicamentoComprado>, IMedicamentoComprado
    {
        private readonly FarmaciaContext _context;
    
        public  MedicamentoCompradoRepository(FarmaciaContext context) : base(context)
        {
            _context = context;
        }
    
        public override async Task<IEnumerable<MedicamentoComprado>> GetAllAsync()
            {
                return await _context.MedicamentoComprados
                .Include(p => p.Medicamentos)
                .ToListAsync();
            }
    
            public override async Task<MedicamentoComprado> GetByIdAsync(int id)
            {
                return await _context.MedicamentoComprados
                .Include(p => p.Medicamentos)
                .FirstOrDefaultAsync(p => p.Id == id);
            }
    }
