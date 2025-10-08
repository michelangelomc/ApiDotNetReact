
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ModelORM.Infrastructure
{
    class CreateDataBase : IDesignTimeDbContextFactory<AppDbContext>
    {
        const string CONNECT_STRING = "Server=localhost;Port=3306;Database=ApiAlunosCA;Uid=root;Password=root2025;";

        public AppDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<AppDbContext> optBuilder = new();
            ServerVersion serverVersion = ServerVersion.AutoDetect(CONNECT_STRING);
            optBuilder.UseMySql(CONNECT_STRING, serverVersion);

            return new AppDbContext(optBuilder.Options);
        }
    }
}