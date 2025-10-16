namespace AlunosApi.ExtensionsClass
{
    public static class CorsExtension
    {
        public static WebApplication AddCorsConfiguration(this WebApplication application)
        {

            application.UseCors(options =>
            {
                options.WithOrigins("http://localhost:3000", "http://localhost:5173")
                       .AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });

            return application;
        }
    }
}
