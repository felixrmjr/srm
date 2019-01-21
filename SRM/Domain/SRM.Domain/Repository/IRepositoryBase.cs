using System.Collections.Generic;
using System.Threading.Tasks;

namespace SRM.Domain.Repository
{
    public interface IRepositoryBase<TContext, TEntity, TIdentity>
      where TContext : IUnitOfWork<TContext>
    {
        IUnitOfWork<TContext> UnitOfWork { get; }
        TEntity Save(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TIdentity id);
        TEntity Get(TIdentity id);
        List<TEntity> GetAll();
        //IPagedList<TEntity> GetPaginated(QueryFilter filter, int start = 0, int limit = 10, bool orderByDescending = true, params Expression<Func<TEntity, object>>[] includes);
        Task BulkInsertAsync(ICollection<TEntity> dados, string[] colunas, string table);
        void BulkInsert(ICollection<TEntity> dados, string[] colunas, string table);
    }
}
