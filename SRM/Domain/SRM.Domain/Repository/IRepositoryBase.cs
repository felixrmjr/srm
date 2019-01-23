using System.Collections.Generic;

namespace SRM.Domain.Repository
{
    public interface IRepositoryBase<TContext, TEntity, TIdentity> where TContext : IUnitOfWork<TContext>
    {
        IUnitOfWork<TContext> UnitOfWork { get; }
        TEntity Save(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TIdentity id);
        TEntity Get(TIdentity id);
        List<TEntity> GetAll();
    }
}
