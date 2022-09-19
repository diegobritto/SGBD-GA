using Derivery.Domain.Entities;

namespace Derivery.Domain.Interfaces
{
    public interface IEnderecoRepository
    {
        Task<Endereco> getById(int id);
        Task<Endereco> Add(Endereco param);
        Task<Endereco> Update(Endereco param);
        Task Delete(Endereco param);
    }
}
