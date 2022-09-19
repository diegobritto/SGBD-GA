using Delivery.Data.Context;
using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly DataContext _context;
         public EnderecoRepository(DataContext context)
        {
            _context = context;
        }
        
        public async Task<Endereco> getById(int id)
        {
            Endereco endereco = _context.Enderecos
               .AsNoTracking()
               .Where(item => item.IdEndereco == id)
               .FirstOrDefault();
            return endereco;
        }
        
        public async Task<Endereco> Add(Endereco param)
        {
            _context.Enderecos.Add(param);
            await _context.SaveChangesAsync();
            return param;
        }
        
        public async Task<Endereco> Update(Endereco param)
        {
            _context.ChangeTracker.Clear();
            _context.Entry<Endereco>(param).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return param;
        }
        
        public async Task Delete(Endereco param)
        {
            _context.ChangeTracker.Clear();
            _context.Enderecos.Remove(param);
            await _context.SaveChangesAsync();
        }
    }
}
