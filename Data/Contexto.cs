using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Observacao> Observacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoasMap());
            modelBuilder.ApplyConfiguration(new ObservacoesMap());
            modelBuilder.ApplyConfiguration(new UsuariosMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
