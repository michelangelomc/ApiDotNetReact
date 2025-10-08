
var builder = WebApplication.CreateBuilder(args);

//Connection String - BD
//string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? "";

//builder.Services.AddDbContext<AppDbContext>(options =>
//                                                     options.UseMySql(
//                                                         connectionString,
//                                                         ServerVersion.AutoDetect(connectionString)));
;

var app = builder.Build();

app.Run();
