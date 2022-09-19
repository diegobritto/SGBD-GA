using Delivery.Data.Context;
using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private readonly DataContext _context;
         public PagamentoRepository(DataContext context)
        {
            _context = context;
        }
        
        public async Task<Pagamento> getById(int id)
        {
            Pagamento endereco = _context.Pagamentos
               .AsNoTracking()
               .Where(item => item.IdPagamento == id)
               .FirstOrDefault();
            return endereco;
        }
        
        public async Task<Pagamento> Add(Pagamento param)
        {
            _context.Pagamentos.Add(param);
            await _context.SaveChangesAsync();
            return param;
        }
        
        public async Task<Pagamento> Update(Pagamento param)
        {
            _context.ChangeTracker.Clear();
            _context.Entry<Pagamento>(param).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return param;
        }
        
        public async Task Delete(Pagamento param)
        {
            _context.ChangeTracker.Clear();
            _context.Pagamentos.Remove(param);
            await _context.SaveChangesAsync();
        }
    }
}
