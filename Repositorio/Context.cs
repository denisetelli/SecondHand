using Microsoft.EntityFrameworkCore;
using Repositorio.Models;

namespace Repositorio
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Anuncio> Anuncios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>().HasKey(_ => _.Id);
            builder.Entity<Anuncio>().HasKey(_ => _.Id);
            builder.Entity<Categoria>().HasKey(_ => _.Id);
            builder.Entity<Imagem>().HasKey(_ => _.Id);
            builder.Entity<Pergunta>().HasKey(_ => _.Id);
            builder.Entity<Resposta>().HasKey(_ => _.Id);
            builder.Entity<Avaliacao>().HasKey(_ => _.Id);
        }
    }
}
