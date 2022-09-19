using Derivery.Domain.Entities;

namespace Derivery.Domain.Interfaces
{
    public interface IProdutoService
    {
        Task<Produto> getById(int id);
        Task<Produto> Add(Produto param);
        Task<Produto> Update(int id, Produto param);
        Task Delete(int id);
    }
}
