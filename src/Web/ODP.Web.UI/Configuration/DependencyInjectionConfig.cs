using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ODP.Web.UI.Extensions;
using ODP.Web.UI.Services.Identidade;

namespace ODP.Web.UI.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}