using Derivery.Domain.Entities;

namespace Derivery.Domain.Interfaces
{
    public interface IPagamentoRepository
    {
        Task<Pagamento> getById(int id);
        Task<Pagamento> Add(Pagamento param);
        Task<Pagamento> Update(Pagamento param);
        Task Delete(Pagamento param);
    }
}
