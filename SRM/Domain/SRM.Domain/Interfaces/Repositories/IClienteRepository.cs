using SRM.Domain.Entities;
using SRM.Domain.Repository;
using System.Collections.Generic;

namespace SRM.Domain.Interfaces.Repositories
{
    public interface IClienteRepository<TContext> : ISRMRepositoryBase<TContext, Cliente, int> where TContext : IUnitOfWork<TContext>
    {
        List<Cliente> GetByName(string nome);
    }
}
