using TodoistClone.Application.Common.Interfaces.Services;

namespace TodoistClone.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
