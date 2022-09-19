using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;

namespace Derivery.Service
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _repository;
        public PedidoService(IPedidoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Pedido> getById(int id)
        {
            return await _repository.getById(id);
        }

        public async Task<Pedido> Add(Pedido param)
        {
            return await _repository.Add(param);
        }

        public async Task<Pedido> Update(int id, Pedido param)
        {
            Pedido result = await getById(id);
            if (result == null)
                return null;
            return await _repository.Update(param);
        }

        public async Task Delete(int id)
        {
            Pedido result = await _repository.getById(id);
            await _repository.Delete(result);
        }
    }
}
