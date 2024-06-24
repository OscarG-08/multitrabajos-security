using Microsoft.EntityFrameworkCore;
using multitrabajos_security.Repositories;
using multitrabajos_security.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<Contexto>(options => 
options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<IServiceLogin, ServiceLogin>();



var app = builder.Build();



// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
