using SRM.Domain.Entities;
using SRM.Domain.Repository;
using System.Collections.Generic;

namespace SRM.Domain.Interfaces.Service
{
    public interface IClienteService<TContext> : ISRMServiceBase<TContext, Cliente, int> 
        where TContext : IUnitOfWork<TContext>
    {
        List<Cliente> GetClientes(string nome);

        void Salvar(Cliente model);
    }
}
