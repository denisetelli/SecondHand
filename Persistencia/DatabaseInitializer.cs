using Persistencia.Repositorio;

namespace Persistencia
{
    public static class DatabaseInitializer
    {
        public static void Initializer(Context context)
        {
            context.Database.EnsureCreated();
            context.SaveChanges();
        }
    }
}
