using Derivery.Domain.DTO;
using Derivery.Domain.Entities;

namespace Derivery.Domain.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> getById(int id);
        Task<Usuario> Add(UsuarioDTO param);
        Task<Usuario> Update(int id, UsuarioDTO param);
        Task Delete(int id);
    }
}
