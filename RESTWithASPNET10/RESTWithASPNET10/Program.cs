using RESTWithASPNET10.Configurations;
using RESTWithASPNET10.Repositories;
using RESTWithASPNET10.Repositories.Impl;
using RESTWithASPNET10.Service;
using RESTWithASPNET10.Service.Impl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton<CalculatorService>();
builder.Services.AddScoped<IPersonServices, PersonServicesImpl>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();

builder.Services.AddDatabaseConfiguration(builder.Configuration);
builder.Services.AddEvolveConfiguration(builder.Configuration, builder.Environment);
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
