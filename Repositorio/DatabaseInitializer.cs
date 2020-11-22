using System.Linq;

namespace Repositorio
{
    public static class DatabaseInitializer
    {
        public static void Initializer(Context context)
        {
            context.Database.EnsureCreated();


            //if (!context.Anuncios.Any())
            //{
            //    context.Anuncios.Add(new Models.Anuncio
            //    {
            //        Id = 0,
            //        Titulo = "TV",
            //        Anunciante = new Models.Usuario { Id = 0, Login = "denise" },
            //        Categoria = new Models.Categoria
            //        {
            //            Id = 0,
            //            Nome = "Eletronicos",
            //            IdadeMinima = 18,
            //        },
            //        Descricao = "TV 42 polegadas LED Full HD",
            //        Valor = 2000
            //    });
            //}
            context.SaveChanges();
        }
    }
}
