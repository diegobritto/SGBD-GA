using Derivery.Domain.Entities;

namespace Derivery.Domain.Interfaces
{
    public interface IPedidoRepository
    {
        Task<Pedido> getById(int id);
        Task<Pedido> Add(Pedido param);
        Task<Pedido> Update(Pedido param);
        Task Delete(Pedido param);
    }
}
