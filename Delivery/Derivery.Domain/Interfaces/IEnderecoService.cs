using Derivery.Domain.Entities;

namespace Derivery.Domain.Interfaces
{
    public interface IEnderecoService
    {
        Task<Endereco> getById(int id);
        Task<Endereco> Add(Endereco param);
        Task<Endereco> Update(int id, Endereco param);
        Task Delete(int id);
    }
}
