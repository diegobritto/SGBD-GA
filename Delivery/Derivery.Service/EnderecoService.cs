using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;

namespace Derivery.Service
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _repository;
        public EnderecoService(IEnderecoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Endereco> getById(int id)
        {
            return await _repository.getById(id);
        }

        public async Task<Endereco> Add(Endereco param)
        {
            return await _repository.Add(param);
        }

        public async Task<Endereco> Update(int id, Endereco param)
        {
            Endereco result = await getById(id);
            if (result == null)
                return null;
            return await _repository.Update(param);
        }

        public async Task Delete(int id)
        {
            Endereco result = await _repository.getById(id);
            await _repository.Delete(result);
        }
    }
}
