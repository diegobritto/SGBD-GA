using Derivery.Domain.Entities;

namespace Derivery.Domain.Interfaces
{
    public interface IPagamentoService
    {
        Task<Pagamento> getById(int id);
        Task<Pagamento> Add(Pagamento param);
        Task<Pagamento> Update(int id, Pagamento param);
        Task Delete(int id);
    }
}
