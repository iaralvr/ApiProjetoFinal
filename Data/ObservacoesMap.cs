using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ObservacoesMap: IEntityTypeConfiguration<Observacao>
    {
        public void Configure(EntityTypeBuilder<Observacao> builder)
    {
        builder.HasKey(x => x.ObservacaoId);
        builder.Property(x => x.ObservacaoDescricao).IsRequired().HasMaxLength(255);
        builder.Property(x => x.ObservacaoLocal).IsRequired().HasMaxLength(255);
        builder.Property(x => x.ObservacaoData).IsRequired().HasMaxLength(255);
        builder.Property(x => x.PessoaId).IsRequired();
        builder.Property(x => x.UsuarioId).IsRequired();
    }
}
}
