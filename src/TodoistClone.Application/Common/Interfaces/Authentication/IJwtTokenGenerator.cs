using TodoistClone.Domain.Entities;

namespace TodoistClone.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
