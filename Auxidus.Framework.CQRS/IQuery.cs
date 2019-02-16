using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auxidus.Framework.CQRS
{
    public interface IQuery<TRepository>
    {
        void Execute(TRepository context);
    }
    public interface IQuery<TRepository, TEntity>
    {
        TEntity Execute(TRepository context);
    }
    public interface IAsyncQuery<TRepository>
    {
        Task ExecuteAsync(TRepository context);
    }
    public interface IAsyncQuery<TRepository, TEntity>
    {
        Task<TEntity> ExecuteAsync(TRepository context);
    }
}
