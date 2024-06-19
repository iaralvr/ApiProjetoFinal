using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IObservacaoRepositorio
    {
        Task<List<Observacao>> GetAll();

        Task<Observacao> GetById(int id);

        Task<Observacao> InsertObservacao(Observacao observacao);

        Task<Observacao> UpdateObservacao(Observacao observacao, int id);

        Task<bool> DeleteObservacao(int id);
    }
}
