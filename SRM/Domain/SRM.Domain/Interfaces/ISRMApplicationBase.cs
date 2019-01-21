using SRM.Domain.Repository;

namespace SRM.Domain.Interfaces
{
    public interface ISRMApplicationBase<TContext, TEntity, TIdentity> where TContext : IUnitOfWork<TContext>
    {
        TEntity Save(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TIdentity chave);
        TEntity Get(TIdentity id);
        //ICollection<TEntity> GetAll(QueryFilter filter = null);
        //IPagedList<TEntity> GetPaginated(QueryFilter filter, int start = 0, int limit = 10, bool orderByDescending = true);
        //void Ativar(TIdentity id);
        //void Inativar(TIdentity id);
    }
}