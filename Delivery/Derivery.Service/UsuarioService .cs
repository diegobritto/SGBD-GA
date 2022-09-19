using Derivery.Domain.DTO;
using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;

namespace Derivery.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<Usuario> getById(int id)
        {
            return await _repository.getById(id);
        }

        public async Task<Usuario> Add(UsuarioDTO param)
        {
            return await _repository.Add(param);
        }

        public async Task<Usuario> Update(int id, UsuarioDTO param)
        {
            Usuario result = await getById(id);
            if (result == null)
                return null;
            return await _repository.Update(param);
        }

        public async Task Delete(int id)
        {
            Usuario result = await _repository.getById(id);
            await _repository.Delete(result);
        }
    }
}
