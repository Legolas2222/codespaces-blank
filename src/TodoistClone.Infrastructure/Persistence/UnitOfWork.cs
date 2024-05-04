using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoistClone.Application.Common.Interfaces.Persistence;
using TodoistClone.Domain.Primitives;

namespace TodoistClone.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private Dictionary<Type, object> _repositories; 
        private readonly DbContext _context;
        public UnitOfWork(DbContext context)
        {
            _repositories = new Dictionary<Type, object>();
            _context = context;
            
        }
        public Task Commit(CancellationToken cancellationToken = default)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }

        public IBaseRepository<TEntity> GetBaseRepository<TEntity>() where TEntity : Entity
        {
            if (this._repositories.ContainsKey(typeof(TEntity)))
            {
                return (BaseRepository<TEntity>)this._repositories[typeof(TEntity)];
            }
            var repository = new BaseRepository<TEntity>(_context); 
            this._repositories.Add(typeof(TEntity), repository);
            return repository;
        }

        public void Rollback()
        {
            _context.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
        }

        public void Dispose() {
            _context.Dispose();
        }
    }
}