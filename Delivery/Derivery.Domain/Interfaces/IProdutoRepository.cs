using Derivery.Domain.Entities;

namespace Derivery.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<Produto> getById(int id);
        Task<Produto> Add(Produto param);
        Task<Produto> Update(Produto param);
        Task Delete(Produto param);
    }
}
