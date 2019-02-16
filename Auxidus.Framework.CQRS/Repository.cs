using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auxidus.Framework.CQRS
{
    public class Repository<TRepository>
    {
        public Repository(TRepository ctx)
        {
            _context = ctx;
        }
        public TRepository _context { get; }

        public TEntity Execute<TEntity>(ICommand<TRepository, TEntity> command)
        {
            return command.Execute(_context);
        }

        public async Task ExecuteAsync(IAsyncCommand<TRepository> command)
        {
            await command.ExecuteAsync(_context);
        }

        public async Task<TEntity> ExecuteAsync<TEntity>(IAsyncCommand<TRepository, TEntity> command)
        {
            return await command.ExecuteAsync(_context);
        }

        public TEntity Find<TEntity>(IQuery<TRepository, TEntity> query)
        {
            return query.Execute(_context);
        }

        public async Task<TEntity> FindAsync<TEntity>(IAsyncQuery<TRepository, TEntity> query)
        {
            return await query.ExecuteAsync(_context);
        }
    }
}
