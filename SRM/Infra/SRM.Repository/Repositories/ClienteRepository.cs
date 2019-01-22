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
            #region [ MOCK ]

            var mock = new List<Cliente>();

            mock.Add(new Cliente
            {
                Id = 1,
                Nome = "Felix 1",
                Email = "felixrmjr@gmail.com",
                Telefone = "11 980179185",
                LimiteCompra = 300,
                DataCadastro = DateTime.Now
            });

            mock.Add(new Cliente
            {
                Id = 2,
                Nome = "Felix 2",
                Email = "felixrmjr@gmail.com",
                Telefone = "11 980179185",
                LimiteCompra = 300,
                DataCadastro = DateTime.Now
            });

            mock.Add(new Cliente
            {
                Id = 3,
                Nome = "Felix 3",
                Email = "felixrmjr@gmail.com",
                Telefone = "11 980179185",
                LimiteCompra = 300,
                DataCadastro = DateTime.Now
            });

            #endregion

            //var dados = mock.Where(c => c.Nome.ToLowerInvariant().Contains(nome.ToLowerInvariant())).ToList();
            var dados = DbSet.Where(c => c.Nome.Contains(nome)).ToList();

            return dados;            
        }
    }
}
