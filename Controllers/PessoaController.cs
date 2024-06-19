using Api.Models;
using Api.Repositorios;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public PessoaController(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }

        [HttpGet("GetAllPessoa")]
        public async Task<ActionResult<List<Pessoa>>> GetAllPessoa()
        {
            List<Pessoa> pessoa = await _pessoaRepositorio.GetAll();
            return Ok(pessoa);
        }

        [HttpGet("GetPessoaId/{id}")]
        public async Task<ActionResult<Pessoa>> GetPessoaId(int id)
        {
            Pessoa pessoa = await _pessoaRepositorio.GetById(id);
            return Ok(pessoa);
        }

        [HttpPost("CreatePessoa")]
        public async Task<ActionResult<Pessoa>> InsertUsuario([FromBody] Pessoa pessoaModel)
        {
            Pessoa pessoa = await _pessoaRepositorio.InsertPessoa(pessoaModel);
            return Ok(pessoa);
        }
        [HttpPut("UpdatePessoa/{id:int}")]
        public async Task<ActionResult<Pessoa>> UpdatePessoa(int id, [FromBody] Pessoa pessoaModel)
        {
            pessoaModel.PessoaId = id;
            Pessoa pessoa = await _pessoaRepositorio.UpdatePessoa(pessoaModel, id);
            return Ok(pessoa);
        }

        [HttpDelete("DeletePessoa/{id:int}")]
        public async Task<ActionResult<Pessoa>> DeletePessoa(int id)
        {
            bool deleted = await _pessoaRepositorio.DeletePessoa(id);
            return Ok(deleted);
        }

    }
}