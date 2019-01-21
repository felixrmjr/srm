using SRM.Domain.Entities;
using SRM.Domain.Interfaces.Repositories;
using SRM.Domain.Interfaces.Service;
using SRM.Domain.Repository;
using System.Collections.Generic;

namespace SRM.Domain.Services
{
    public class ClienteService<TContext> : SRMServiceBase<TContext, Cliente, int>, IClienteService<TContext>
         where TContext : IUnitOfWork<TContext>
    {
        private readonly IClienteRepository<TContext> _repository;

        public ClienteService(IClienteRepository<TContext> repository) : base(repository)
        {
            _repository = repository;
        }

        public List<Cliente> GetClientes(string nome)
        {
            if (!string.IsNullOrWhiteSpace(nome))
                return _repository.GetByName(nome);

            return _repository.GetAll();
        }

        public override Cliente Get(int id)
        {
            return _repository.Get(id);
        }

        public void Salvar(Cliente model)
        {
            if (model.Id <= 0)
                _repository.Save(model);
            else
                _repository.Update(model);
        }
    }
}
