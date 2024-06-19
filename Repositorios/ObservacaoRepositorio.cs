using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class ObservacaoRepositorio : IObservacaoRepositorio
    {
        private readonly Contexto _dbContext;

    public ObservacaoRepositorio(Contexto dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Observacao>> GetAll()
    {
        return await _dbContext.Observacao.ToListAsync();
    }

    public async Task<Observacao> GetById(int id)
    {
        return await _dbContext.Observacao.FirstOrDefaultAsync(x => x.ObservacaoId == id);
    }

    public async Task<Observacao> InsertObservacao(Observacao observacao)
    {
        await _dbContext.Observacao.AddAsync(observacao);
        await _dbContext.SaveChangesAsync();
        return observacao;
    }

    public async Task<Observacao> UpdateObservacao(Observacao observacao, int id)
    {
        Observacao Observacoes = await GetById(id);
        if (observacao == null)
        {
            throw new Exception("Não encontrado");
        }
        else
        {
            Observacoes.ObservacaoId = observacao.ObservacaoId;
            Observacoes.ObservacaoDescricao = observacao.ObservacaoDescricao;
            Observacoes.ObservacaoLocal = observacao.ObservacaoLocal;
            Observacoes.ObservacaoData = observacao.ObservacaoData;
            Observacoes.PessoaId = observacao.PessoaId;
            Observacoes.UsuarioId = observacao.UsuarioId;



            _dbContext.Observacao.Update(Observacoes);
            await _dbContext.SaveChangesAsync();
        }
        return observacao;
    }
    public async Task<bool> DeleteObservacao(int id)
    {
        Observacao observacao = await GetById(id);
        if (observacao == null)
        {
            throw new Exception("Não encontrado");
        }
        _dbContext.Observacao.Remove(observacao);
        await _dbContext.SaveChangesAsync();
        return true;
    }

}
}