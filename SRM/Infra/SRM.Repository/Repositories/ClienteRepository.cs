using SRM.Domain.Entities;
using SRM.Domain.Interfaces.Repositories;
using SRM.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SRM.Repository.Repositories
{
    public class ClienteRepository<TContext> : SRMRepositoryBase<TContext, Cliente, int>, IClienteRepository<TContext>
       where TContext : IUnitOfWork<TContext>
    {
        public ClienteRepository(IUnitOfWork<TContext> unitOfWork) : base(unitOfWork) { }

        public List<Cliente> GetByName(string nome)
        {
            var dados = DbSet.Where(c => c.Nome.Contains(nome)).ToList();

            return dados;            
        }
    }
}
