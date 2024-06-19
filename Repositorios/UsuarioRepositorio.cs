using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Contexto _dbContext;

        public UsuarioRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Usuario>> GetAll()
        {
            return await _dbContext.Usuario.ToListAsync();
        }

        public async Task<Usuario> GetById(int id)
        {
            return await _dbContext.Usuario.FirstOrDefaultAsync(x => x.UsuarioId == id);
        }
        public async Task<Usuario> Login(string email, string password)
        {
            return await _dbContext.Usuario.FirstOrDefaultAsync(x => x.UsuarioEmail == email && x.UsuarioSenha == password);
        }
        public async Task<Usuario> InsertUsuario(Usuario usuario)
        {
            await _dbContext.Usuario.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> UpdateUsuario(Usuario usuario, int id)
        {
            Usuario usuarios = await GetById(id);
            if (usuario == null)
            {
                throw new Exception("Não encontrado");
            }
            else
            {
                usuarios.UsuarioNome = usuario.UsuarioNome;
                usuarios.UsuarioEmail = usuario.UsuarioEmail;
                usuarios.UsuarioSenha = usuario.UsuarioSenha;
                _dbContext.Usuario.Update(usuarios);
                await _dbContext.SaveChangesAsync();
            }
            return usuario;
        }
        public async Task<bool> DeleteUsuario(int id)
        {
            Usuario usuario = await GetById(id);
            if (usuario == null)
            {
                throw new Exception("Não encontrado");
            }
            _dbContext.Usuario.Remove(usuario);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}