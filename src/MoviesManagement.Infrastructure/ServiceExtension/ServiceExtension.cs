using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoviesManagement.Infrastructure.Context;

namespace MoviesManagement.Infrastructure.ServiceExtension;

public static class ServiceExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DatabaseContext>(x=> x.UseSqlServer(configuration.GetConnectionString("sqlserver")));
        return services;
    }
    
}