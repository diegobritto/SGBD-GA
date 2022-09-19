using Delivery.Data.Context;
using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext _context;
         public ProdutoRepository(DataContext context)
        {
            _context = context;
        }
        
        public async Task<Produto> getById(int id)
        {
            Produto endereco = _context.Produtos
               .AsNoTracking()
               .Where(item => item.IdProduto == id)
               .FirstOrDefault();
            return endereco;
        }
        
        public async Task<Produto> Add(Produto param)
        {
            _context.Produtos.Add(param);
            await _context.SaveChangesAsync();
            return param;
        }
        
        public async Task<Produto> Update(Produto param)
        {
            _context.ChangeTracker.Clear();
            _context.Entry<Produto>(param).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return param;
        }
        
        public async Task Delete(Produto param)
        {
            _context.ChangeTracker.Clear();
            _context.Produtos.Remove(param);
            await _context.SaveChangesAsync();
        }
    }
}
