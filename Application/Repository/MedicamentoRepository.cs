using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
    public class MedicamentoRepository : GenericRepository<Medicamento>, IMedicamento
    {
        private readonly FarmaciaContext _context;
    
        public MedicamentoRepository(FarmaciaContext context) : base(context)
        {
            _context = context;
        }
    
        public  async Task<IEnumerable<Medicamento>> GetStockLess50Async(int cantidad)
            {
                return await _context.Medicamentos
                .Where(m => m.Stock < cantidad)
                .ToListAsync();
            }
    
        //     public override async Task<Medicamento> GetByIdAsync(int id)
        //     {
        //         return await _context.Medicamentos
        //         .FirstOrDefaultAsync(p => p.Id == id);
        //     }
    }