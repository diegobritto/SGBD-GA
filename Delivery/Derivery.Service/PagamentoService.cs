using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;

namespace Derivery.Service
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IPagamentoRepository _repository;
        public PagamentoService(IPagamentoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Pagamento> getById(int id)
        {
            return await _repository.getById(id);
        }

        public async Task<Pagamento> Add(Pagamento param)
        {
            return await _repository.Add(param);
        }

        public async Task<Pagamento> Update(int id, Pagamento param)
        {
            Pagamento result = await getById(id);
            if (result == null)
                return null;
            return await _repository.Update(param);
        }

        public async Task Delete(int id)
        {
            Pagamento result = await _repository.getById(id);
            await _repository.Delete(result);
        }
    }
}
