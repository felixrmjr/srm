using SRM.Domain.Repository;

namespace SRM.Domain.Interfaces
{
    public interface ISRMApplicationBase<TContext, TEntity, TIdentity> where TContext : IUnitOfWork<TContext>
    {
        TEntity Save(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TIdentity chave);
        TEntity Get(TIdentity id);
    }
}