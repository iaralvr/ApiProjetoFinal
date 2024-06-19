using Api.Models;
using Api.Repositorios;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet("GetAllUsuario")]
        public async Task<ActionResult<List<Usuario>>> GetAllUsuario()
        {
            List<Usuario> usuario = await _usuarioRepositorio.GetAll();
            return Ok(usuario);
        }
        [HttpPost("Login")]
        public async Task<ActionResult<Usuario>> Login([FromBody] Usuario usuarioModel)
        {
            Usuario usuario = await _usuarioRepositorio.Login(usuarioModel.UsuarioEmail, usuarioModel.UsuarioSenha);
            return Ok(usuario);
        }

        [HttpGet("GetUsuarioId/{id}")]
        public async Task<ActionResult<Usuario>> GetUsuarioId(int id)
        {
            Usuario usuario = await _usuarioRepositorio.GetById(id);
            return Ok(usuario);
        }

        [HttpPost("CreateUsuario")]
        public async Task<ActionResult<Usuario>> InsertUsuario([FromBody] Usuario usuarioModel)
        {
            Usuario usuario = await _usuarioRepositorio.InsertUsuario(usuarioModel);
            return Ok(usuario);
        }
        [HttpPut("UpdateUser/{id:int}")]
        public async Task<ActionResult<Usuario>> UpdateUser(int id, [FromBody] Usuario userModel)
        {
            userModel.UsuarioId = id;
            Usuario user = await _usuarioRepositorio.UpdateUsuario(userModel, id);
            return Ok(user);
        }

        [HttpDelete("DeleteUsuario/{id:int}")]
        public async Task<ActionResult<Usuario>> DeleteUsuario(int id)
        {
            bool deleted = await _usuarioRepositorio.DeleteUsuario(id);
            return Ok(deleted);
        }

    }
}