using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repositorio;
using Repositorio.Crud;
using Repositorio.Crud.Interfaces;

namespace SecondHandProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddTransient<ICrudAnuncio, CrudAnuncio>();
            services.AddTransient<ICrudAvaliacao, CrudAvaliacao>();
            services.AddTransient<ICrudCategoria, CrudCategoria>();
            services.AddTransient<ICrudImagem, CrudImagem>();
            services.AddTransient<ICrudPergunta, CrudPergunta>();
            services.AddTransient<ICrudResposta, CrudResposta>();
            services.AddTransient<ICrudUsuario, CrudUsuario>();

            services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                using (var context = new Context((DbContextOptions<Context>)options.Options))
                    DatabaseInitializer.Initializer(context);
                services.AddSession();
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
