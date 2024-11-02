using EMS.Api.Data;
using EMS.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);


string? connString = builder.Configuration.GetConnectionString("sqlite");
// Add services to the container.
builder.Services.AddSqlite<AppDbContext>(connString); 


var app = builder.Build();


app.MapEmployeesEndpoints();
app.MapDepartmentEndpoints();

await app.MigrateDbAsync();

app.Run();


