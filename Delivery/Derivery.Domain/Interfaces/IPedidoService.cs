using Derivery.Domain.Entities;

namespace Derivery.Domain.Interfaces
{
    public interface IPedidoService
    {
        Task<Pedido> getById(int id);
        Task<Pedido> Add(Pedido param);
        Task<Pedido> Update(int id, Pedido param);
        Task Delete(int id);
    }
}
