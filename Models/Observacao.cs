namespace Api.Models
{
    public class Observacao
    {
        public int ObservacaoId { get; set; }
        public string ObservacaoDescricao { get; set; } = string.Empty;
        public string ObservacaoLocal { get; set; } = string.Empty;
        public DateTime ObservacaoData { get; set; }
        public int PessoaId { get; set; }
        public int UsuarioId { get; set; }

        public static implicit operator List<object>(Observacao v)
        {
            throw new NotImplementedException();
        }

    }
}