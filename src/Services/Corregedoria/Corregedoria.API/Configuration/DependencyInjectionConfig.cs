
using Corregedoria.Domain.Interfaces;
using Corregedoria.Infra.Data;
using Corregedoria.Infra.Repositories;
using Corregedoria.Infra.RepositoriesRead;
using Microsoft.Extensions.DependencyInjection;


namespace Corregedoria.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IInstauracaoRepository, InstauracaoRepository>();
            services.AddScoped<IInstauracaoRepositoryRead, InstauracaoRepositoryRead>();
            services.AddScoped<CorregedoriaContext>();
        }
    }
}
