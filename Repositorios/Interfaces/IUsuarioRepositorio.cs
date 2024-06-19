using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<Usuario>> GetAll();

        Task<Usuario> GetById(int id);
        Task<Usuario> Login(string username, string password);

        Task<Usuario> InsertUsuario(Usuario usuario);

        Task<Usuario> UpdateUsuario(Usuario usuario, int id);

        Task<bool> DeleteUsuario(int id);
    }
}
