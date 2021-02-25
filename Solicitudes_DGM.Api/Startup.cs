namespace Solicitudes_DGM.Api
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.OpenApi.Models;
    using Solicitudes_DGM.Application.Persona;
    using Solicitudes_DGM.Persistence;
    using Solicitudes_DGM.Persistence.Persona;
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Solicitudes_DGM.Api", Version = "v1" });
            });

            services.AddDbContext<SolicitudesDBContext>(options =>
            options.UseSqlServer(this.Configuration.GetConnectionString("dbConnection")));

            //Repositorios
            services.AddScoped<IPersonaRepository, PersonaRepository>();

            //Servicios
            services.AddScoped<IPersonaService, PersonaService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Solicitudes_DGM.Api v1"));
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
