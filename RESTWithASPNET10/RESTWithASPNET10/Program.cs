using RESTWithASPNET10.Configurations;
using RESTWithASPNET10.Service;
using RESTWithASPNET10.Service.Impl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton<CalculatorService>();
builder.Services.AddScoped<IPersonServices, PersonServicesImpl>();

builder.Services.AddDatabaseConfiguration(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
