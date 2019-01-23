using SRM.Domain.Dtos;
using SRM.Domain.Entities;
using SRM.Domain.Exceptions;
using SRM.Domain.Interfaces.Repositories;
using SRM.Domain.Interfaces.Service;
using SRM.Domain.Repository;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

        public void Salvar(List<Cliente> model)
        {
            foreach (var item in model)
                Salvar(item);
        }

        public ArquivoLido<Cliente> LerArquivo(string caminho)
        {
            var linhas = File.ReadAllLines(caminho).Skip(1).Select(x => x.Split(';'));

            var clientes = new List<Cliente>();
            int sucessos = 0;
            int falhas = 0;

            foreach (var item in linhas)
            {
                try
                {
                    var cliente = new Cliente(item[0], item[1], item[2], item[3]);
                    cliente.Validate();
                    clientes.Add(cliente);
                    sucessos++;
                }
                catch (DomainSummaryException)
                {
                    falhas++;
                }
            }

            return new ArquivoLido<Cliente>(clientes, sucessos, falhas);
        }
    }
}
