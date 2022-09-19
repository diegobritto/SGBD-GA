using Delivery.Data.Context;
using Derivery.Domain.DTO;
using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _context;
         public UsuarioRepository(DataContext context)
        {
            _context = context;
        }
        
        public async Task<Usuario> getById(int id)
        {
            Usuario usuario = _context.Usuarios
               .AsNoTracking()               
               .Where(item => item.IdUsuario == id)               
               .FirstOrDefault();
                        
            return usuario;
        }
        
        public async Task<Usuario> Add(UsuarioDTO param)
        {            
            Usuario usuario = new Usuario
            {
                Nome = param.Nome,
                EhEstabelecimento = param.EhEstabelecimento,                
                IdEndereco = param.IdEndereco
                
            };
            
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }
        
        public async Task<Usuario> Update(UsuarioDTO param)
        {
            EnderecoRepository endereco = new EnderecoRepository(_context);
            Usuario usuario = new Usuario
            {
                Nome = param.Nome,
                EhEstabelecimento = param.EhEstabelecimento,
                IdUsuario = param.IdUsuario,
                IdEndereco = param.IdEndereco,
                Endereco = endereco.getById(param.IdEndereco).Result
            };
            _context.ChangeTracker.Clear();
            _context.Entry<Usuario>(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return usuario;
        }
        
        public async Task Delete(Usuario param)
        {
            _context.ChangeTracker.Clear();
            _context.Usuarios.Remove(param);
            await _context.SaveChangesAsync();
        }
    }
}
