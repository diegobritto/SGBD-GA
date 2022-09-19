using Delivery.Data.Context;
using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly DataContext _context;
         public PedidoRepository(DataContext context)
        {
            _context = context;
        }
        
        public async Task<Pedido> getById(int id)
        {
            Pedido endereco = await  _context.Pedidos
               .Include(p => p.Produtos)
               .AsNoTracking()
               .Where(item => item.IdPedido == id)
               .FirstOrDefaultAsync();
            return endereco;
        }
        
        public async Task<Pedido> Add(Pedido param)
        {
            await InsertProdutoPedido(param);
            await _context.Pedidos.AddAsync(param);
            
            await _context.SaveChangesAsync();
            return param;
        }

        private async Task InsertProdutoPedido(Pedido param)
        {
            foreach (var item in param.Produtos)
            {
                var itemConsultado = await _context.Produtos
                    .AsNoTracking()
                    .FirstOrDefaultAsync(p => p.IdProduto == item.IdProduto);
                
                _context.Entry(item).CurrentValues
                    .SetValues(itemConsultado);
            }
        }

        public async Task<Pedido> Update(Pedido param)
        {
            _context.ChangeTracker.Clear();
            _context.Entry<Pedido>(param).State = EntityState.Modified;
            await InsertProdutoPedido(param);
            await _context.SaveChangesAsync();
            return param;
        }
        
        public async Task Delete(Pedido param)
        {
            _context.ChangeTracker.Clear();
            _context.Pedidos.Remove(param);
            await _context.SaveChangesAsync();
        }
    }
}
