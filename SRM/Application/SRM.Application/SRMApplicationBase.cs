using SRM.Domain.Entities;
using SRM.Domain.Interfaces;
using SRM.Domain.Repository;

namespace SRM.Application
{
    public class SRMApplicationBase<TContext, TEntity, TIdentity>
        where TEntity  : EntityBase
        where TContext : IUnitOfWork<TContext>
    {

        protected readonly ISRMServiceBase<TContext, TEntity, TIdentity> _service;
        protected readonly IUnitOfWork<TContext> _unitOfWork;

        public SRMApplicationBase(IUnitOfWork<TContext> context, ISRMServiceBase<TContext, TEntity, TIdentity> service)
        {
            _service = service;
            _unitOfWork = context;
        }

        public virtual TEntity Save(TEntity entity)
        {
            _service.Save(entity);
            _unitOfWork.Commit();

            return entity;
        }

        public virtual TEntity Update(TEntity entity)
        {
            _service.Update(entity);
            _unitOfWork.Commit();

            return entity;
        }

        public virtual void Delete(TIdentity chave)
        {
            _service.Delete(chave);
            _unitOfWork.Commit();
        }

        public virtual TEntity Get(TIdentity id)
        {
            var entidade = _service.Get(id);
            return entidade;
        }

        //public virtual ICollection<TEntity> GetAll(QueryFilter filter = null)
        //{
        //    return _service.GetAll(filter);
        //}

        //public virtual IPagedList<TEntity> GetPaginated(QueryFilter filter, int start = 0, int limit = 10, bool orderByDescending = true)
        //{
        //    return _service.GetPaginated(filter, start, limit);
        //}

        //public virtual void Ativar(TIdentity id)
        //{
        //    _service.Ativar(id);
        //    _unitOfWork.Commit();
        //}

        //public virtual void Inativar(TIdentity id)
        //{
        //    _service.Inativar(id);
        //    _unitOfWork.Commit();
        //}
    }
}