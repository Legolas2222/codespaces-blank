using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using TodoistClone.Application.Common.Interfaces.Authentication;
using TodoistClone.Application.Common.Interfaces.Persistence;
using TodoistClone.Application.Common.Interfaces.Services;
using TodoistClone.Infrastructure.Authentication;
using TodoistClone.Infrastructure.Persistence;
using TodoistClone.Infrastructure.Persistence.DbModels;
using TodoistClone.Infrastructure.Services;

namespace TodoistClone.Infrastructure
{

    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.AddScoped<IUserRepository, UserRepositoryInMemory>();
            //services.AddDbContext<TodoItemContext>(options => options.UseMongoDB(new MongoClient("mongodb://localhost:27017"), "TodoistClone"));
            services.AddScoped<ITodoItemRepository, TodoItemRepositoryInMemory>();
            return services;
        }

    }
}