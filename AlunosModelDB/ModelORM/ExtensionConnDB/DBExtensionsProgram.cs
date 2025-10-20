using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModelORM.Infrastructure;
using MySqlConnector;

namespace ModelORM.ExtensionConnDB
{
    public static class DBExtensionsProgram
    {
        public static void UseMySqlConfiguration(IServiceCollection services, WebApplicationBuilder builder)
        {
            string strConnection = builder.Configuration.GetConnectionString("DefaulConnection")!;
            
            services.AddDbContext<AppDbContext>(optionsDb => optionsDb.UseMySql(strConnection, ServerVersion.AutoDetect(strConnection)));
            
            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<AppDbContext>()
                    .AddDefaultTokenProviders();
        }
    }
}
