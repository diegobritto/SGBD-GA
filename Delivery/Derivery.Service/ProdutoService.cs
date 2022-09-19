using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;

namespace Derivery.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Produto> getById(int id)
        {
            return await _repository.getById(id);
        }

        public async Task<Produto> Add(Produto param)
        {
            return await _repository.Add(param);
        }

        public async Task<Produto> Update(int id, Produto param)
        {
            Produto result = await getById(id);
            if (result == null)
                return null;
            return await _repository.Update(param);
        }

        public async Task Delete(int id)
        {
            Produto result = await _repository.getById(id);
            await _repository.Delete(result);
        }
    }
}
