using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Data
{
    public class PessoasMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(x => x.PessoaId);
            builder.Property(x => x.PessoaNome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PessoaFoto).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PessoaStatus).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PessoaCor).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PessoaRoupa).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PessoaDtDesaparecimento).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PessoaDtEncontro).HasMaxLength(255);
            builder.Property(x => x.PessoaLocalDesaparecimento).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PessoaObservacao).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PessoaSexo).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PessoaStatus).IsRequired().HasMaxLength(255);
            builder.Property(x => x.UsuarioId).IsRequired().HasMaxLength(255);
        }
    }
}