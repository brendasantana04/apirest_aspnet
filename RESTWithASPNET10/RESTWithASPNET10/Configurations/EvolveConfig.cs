using EvolveDb;
using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace RESTWithASPNET10.Configurations
{
    public static class EvolveConfig
    {
        public static IServiceCollection AddEvolveConfiguration(
        this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                var connectionString = configuration.GetConnectionString("MSSQLServerSQLConnection");

                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new ArgumentNullException(
                        "ConnectionString não encontrada");
                }

                try
                {
                    using var evolveConnection = new SqlConnection(connectionString);
                    var evolve = new Evolve(
                        evolveConnection, msg => Console.WriteLine(msg))
                    {
                        Locations = new List<string> { "db/migrations", "db/dataset" },
                        IsEraseDisabled = true
                    };
                    evolve.Migrate();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Evolve migration failed", ex);
                }
            }
            return services;
        }
    }
}
