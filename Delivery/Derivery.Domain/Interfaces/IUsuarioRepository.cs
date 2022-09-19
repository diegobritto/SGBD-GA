using Derivery.Domain.DTO;
using Derivery.Domain.Entities;

namespace Derivery.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> getById(int id);
        Task<Usuario> Add(UsuarioDTO param);
        Task<Usuario> Update(UsuarioDTO param);
        Task Delete(Usuario param);
    }
}
