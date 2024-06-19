using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IPessoaRepositorio
    {
        Task<List<Pessoa>> GetAll();

        Task<Pessoa> GetById(int id);

        Task<Pessoa> InsertPessoa(Pessoa pessoa);

        Task<Pessoa> UpdatePessoa(Pessoa pessoa, int id);

        Task<bool> DeletePessoa(int id);
    }
}
