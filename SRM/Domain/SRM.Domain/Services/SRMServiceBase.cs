using SRM.Domain.Interfaces;
using SRM.Domain.Repository;
using SRM.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace SRM.Domain.Services
{
    public class SRMServiceBase<TContexto, TEntity, TIdentity> : ISRMServiceBase<TContexto, TEntity, TIdentity>
         where TContexto : IUnitOfWork<TContexto>
    {

        protected readonly IRepositoryBase<TContexto, TEntity, TIdentity> _repository;

        public SRMServiceBase(ISRMRepositoryBase<TContexto, TEntity, TIdentity> repository)
        {
            this._repository = repository;
        }

        public virtual TEntity Save(TEntity entidade)
        {
            _repository.Save(entidade);
            return entidade;
        }

        public virtual TEntity Update(TEntity entidade)
        {
            _repository.Update(entidade);
            return entidade;
        }

        public virtual void Delete(TIdentity chave)
        {
            _repository.Delete(chave);
        }

        public virtual TEntity Get(TIdentity id)
        {
            return _repository.Get(id);
        }

        public virtual List<TEntity> GetAll() => _repository.GetAll();
        //public virtual IPagedList<TEntity> GetPaginated(QueryFilter filter, int start = 0, int limit = 10, bool orderByDescending = true) => _repository.GetPaginated(filter, start, limit, orderByDescending);

        //public virtual void Ativar(TIdentity id)
        //{
        //    var entidade = _repository.Get(id);
        //    entidade();
        //}

        //public virtual void Inativar(TIdentity id)
        //{
        //    var entidade = _repository.Get(id);
        //    entidade.Inativar();
        //}
    }
}