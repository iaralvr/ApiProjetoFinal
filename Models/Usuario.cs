namespace Api.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string UsuarioNome { get; set; } = string.Empty;

        public string UsuarioEmail { get; set; } = string.Empty;

        public string UsuarioSenha { get; set; } = string.Empty;

        public static implicit operator List<object>(Usuario v)
        {
            throw new NotImplementedException();
        }

    }
}
