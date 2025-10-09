using Infrastructure.InjectionDependecy;
using Microsoft.AspNetCore.Builder;
using ModelORM.ExtensionConnDB;
using ModelORM.InjectionDependence;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

#region Extensions
string strConnection = builder.Configuration.GetConnectionString("DefaulConnection")!;
DBExtensionsProgram.UseMySqlConfiguration(builder.Services, builder);
#endregion

// Add services to the container.
ModelsDI.RegModelsServices(builder.Services);
InfrasDI.RegInfrasServices(builder.Services);

builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
///TODO app.UseAuthorization();

app.MapControllers();
app.Run();
