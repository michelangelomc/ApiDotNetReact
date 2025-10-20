using Infrastructure.DataProvider.Servives.DataBaseServices;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.InjectionDependecy
{
    public static class InfrasDI
    {
        public static void RegInfrasServices(IServiceCollection services)
        {
            services.AddScoped<IAlunoDbService, AlunoDbService>();
            services.AddScoped<IAuthenticate, Authenticate>();
        }
    }
}
