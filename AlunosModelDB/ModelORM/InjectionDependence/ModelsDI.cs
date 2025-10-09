using Microsoft.Extensions.DependencyInjection;
using ModelORM.Repository;
using ModelORM.Repository.UnitOfWork;

namespace ModelORM.InjectionDependence
{
    public static class ModelsDI
    {
        public static void RegModelsServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IMainRepositoy<>), typeof(MainRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAlunoRepositroy, AlunoRepository>();
        }
    }
}
