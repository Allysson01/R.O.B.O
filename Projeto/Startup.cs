using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using R.O.B.O.Servicos.Cabeca;
using R.O.B.O.Servicos.Cabeca.Interface;
using R.O.B.O.Servicos.Cabeca.Rotacionar;
using R.O.B.O.Servicos.Cabeca.Rotacionar.Interface;
using R.O.B.O.Servicos.Membros.Contrair;
using R.O.B.O.Servicos.Membros.Contrair.Esquerdo;
using R.O.B.O.Servicos.Membros.Contrair.Esquerdo.Interface;
using R.O.B.O.Servicos.Membros.Contrair.Interface;
using R.O.B.O.Servicos.Membros.Maos.Direito.Interface;
using R.O.B.O.Servicos.Membros.Maos.Esquerdo;
using R.O.B.O.Servicos.Membros.Maos.Esquerdo.Interface;

namespace R.O.B.O
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
            services.AddTransient<IComandosCabeca, ComandosCabeca>();
            services.AddTransient<IComandoRotacionarCabeca, ComandoRotacionarCabeca>();
            services.AddTransient<IComandosCotoveloDireito, ComandosCotoveloDireito>();
            services.AddTransient<IComandosCotoveloEsquerdo, ComandosCotoveloEsquerdo>();
            services.AddTransient<IComandosMaoDireita, ComandosMaoDireita>();
            services.AddTransient<IComandosMaoEsquerda, ComandosMaoEsquerda>();            

            services.AddControllers();

            #region Cors
            services.AddCors(options =>
            {
                options.AddPolicy("Livre",
                    builder =>
                    {
                        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                    });
            });
            #endregion Cors
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthorization();
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
