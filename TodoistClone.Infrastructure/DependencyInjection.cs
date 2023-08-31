using Microsoft.Extensions.DependencyInjection;
using TodoistClone.Application.Common.Interfaces.Authentication;
using TodoistClone.Infrastructure.Authentication;

namespace TodoistClone.Infrastructure
{

    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            return services;
        }

    }
}