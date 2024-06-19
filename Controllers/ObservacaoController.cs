using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObservacaoController : ControllerBase
    {
        private readonly IObservacaoRepositorio _observacaoRepositorio;

        public ObservacaoController(IObservacaoRepositorio observacaoRepositorio)
        {
            _observacaoRepositorio = observacaoRepositorio;
        }
        [HttpGet("GetAllObservacao")]
        public async Task<ActionResult<List<Observacao>>> GetAllObservacao()
        {
            List<Observacao> observacao = await _observacaoRepositorio.GetAll();
            return Ok(observacao);
        }
        [HttpGet("GetObservacaoId/{id}")]
        public async Task<ActionResult<Observacao>> GetObservacaoId(int id)
        {
            Observacao observacao = await _observacaoRepositorio.GetById(id);
            return Ok(observacao);
        }
        [HttpPost("InsertObservacao")]
        public async Task<ActionResult<Observacao>> InsertObservacao([FromBody] Observacao Observacao)
        {
            Observacao observacao = await _observacaoRepositorio.InsertObservacao(Observacao);
            return Ok(observacao);
        }
        [HttpPut("UpdateObservacao/{id:int}")]
        public async Task<ActionResult<Observacao>> UpdateObservacoes(int id, [FromBody] Observacao Observacao)
        {
            Observacao.ObservacaoId = id;
            Observacao observacao = await _observacaoRepositorio.UpdateObservacao(Observacao, id);
            return Ok(observacao);
        }
        [HttpDelete("DeleteObservacao/{id:int}")]
        public async Task<ActionResult<Observacao>> DeleteObservacao(int id)
        {
            bool deleted = await _observacaoRepositorio.DeleteObservacao(id);
            return Ok(deleted);
        }

    }
}