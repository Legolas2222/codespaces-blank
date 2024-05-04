using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoistClone.Domain.Primitives;

namespace TodoistClone.Application.Common.Interfaces.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        Task Commit(CancellationToken cancellationToken);
        void Rollback();
        IBaseRepository<T> GetBaseRepository<T>() where T : Entity;
    }
}