using Microsoft.EntityFrameworkCore;
using TodoistClone.Application.Common.Interfaces.Persistence;
using TodoistClone.Domain.Primitives;
namespace TodoistClone.Infrastructure.Persistence
{
    internal abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Entity
    {
        protected readonly DbContext dbContext;

        public BaseRepository(DbContext context)
        {
            dbContext = context;
        }

        public void Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            dbContext.Set<TEntity>().Update(entity);
        }
    }
}
