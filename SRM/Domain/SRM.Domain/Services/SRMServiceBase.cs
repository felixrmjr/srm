using SRM.Domain.Interfaces;
using SRM.Domain.Repository;
using SRM.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using SRM.Domain.Entities;

namespace SRM.Domain.Services
{
    public class SRMServiceBase<TContexto, TEntity, TIdentity> : ISRMServiceBase<TContexto, TEntity, TIdentity>
            where TEntity : EntityBase
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
    }
}