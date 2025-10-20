using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AlunosApi.ExtensionsClass
{
    public static class JwtExtension
    {
        public static IServiceCollection AddJwtConfiguration(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
             {
                 opt.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidateIssuerSigningKey = true,
                     ValidIssuer = builder.Configuration["Jwt:Issuer"],
                     ValidAudience = builder.Configuration["Jwt:Audience"],
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!))
                 };
             });

            return services;
        }
    }
}
