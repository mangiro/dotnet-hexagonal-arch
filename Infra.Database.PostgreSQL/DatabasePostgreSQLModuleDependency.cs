using Domain.Adapters;
using Infra.Database.PostgreSQL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Database.PostgreSQL
{
    public static class DatabasePostgreSQLModuleDependency
    {
        public static void AddDatabasePostgreSQLModule(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
