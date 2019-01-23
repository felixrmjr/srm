using SRM.Domain.Entities;
using SRM.Domain.Interfaces.Repositories;
using SRM.Domain.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SRM.Repository
{
    public class SRMRepositoryBase<TContext, TEntity, TIdentity> : ISRMRepositoryBase<TContext, TEntity, TIdentity>
        where TEntity : EntityBase
        where TContext : IUnitOfWork<TContext>
    {

        public IUnitOfWork<TContext> UnitOfWork { get; }

        public SRMRepositoryBase(IUnitOfWork<TContext> unitOfWork) => this.UnitOfWork = unitOfWork;

        protected DbSet<TEntity> DbSet => ((DbContext)UnitOfWork).Set<TEntity>();

        public virtual TEntity Save(TEntity entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        public virtual TEntity Update(TEntity entity)
        {
            var result = DbSet.Attach(entity);
            return entity;
        }

        public virtual void Delete(TIdentity id)
        {
            TEntity entity = Get(id);
            DbSet.Remove(entity);
        }

        public virtual TEntity Get(TIdentity id) => DbSet.Find(id);
        public virtual List<TEntity> GetAll()
        {
            var result = DbSet.AsQueryable();
            return result.ToList();
        }
    }
}
