using API.Services;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer("Server=.\\MSSQLSERVER_DEV;Database=CoffeeShopDb;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true");
});

builder.Services.AddScoped<ICoffeeShopService, CoffeeShopService>();


var app = builder.Build();

app.MapControllers();

//app.MapGet("/", () => "Hello World!");

app.Run();
