using System.Threading.Tasks;

namespace Auxidus.Framework.CQRS
{
    public interface ICommand<TRepository>
    {
        void Execute(TRepository context);
    }
    public interface ICommand<TRepository, TEntity>
    {
        TEntity Execute(TRepository context);
    }

    public interface IAsyncCommand<TRepository>
    {
        Task ExecuteAsync(TRepository context);
    }
    public interface IAsyncCommand<TRepository, TEntity>
    {
        Task<TEntity> ExecuteAsync(TRepository context);
    }
}
