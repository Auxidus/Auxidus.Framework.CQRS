using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auxidus.Framework.CQRS
{
    public interface IRepository<TRepository>
    {
        TRepository _context { get; }

        Task<TEntity> FindAsync<TEntity>(IAsyncQuery<TRepository, TEntity> query);

        TEntity Find<TEntity>(IQuery<TRepository, TEntity> query);

        Task ExecuteAsync(IAsyncCommand<TRepository> command);

        Task<TEntity> ExecuteAsync<TEntity>(IAsyncCommand<TRepository, TEntity> command);

        TEntity Execute<TEntity>(ICommand<TRepository, TEntity> command);
    }
}
