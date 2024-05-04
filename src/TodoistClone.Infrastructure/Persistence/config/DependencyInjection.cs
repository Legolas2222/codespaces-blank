using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoistClone.Infrastructure.Persistence.DbModels;

namespace TodoistClone.Infrastructure.Persistence.config
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDatabaseConnection(this IServiceCollection services, string connectionString, string databaseName)
        {
            services.AddDbContext<TodoistContext>(options => options.UseMongoDB(connectionString, databaseName));
            return services;
        }   
    }
}
