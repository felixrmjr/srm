using SRM.Domain.Dtos;
using SRM.Domain.Entities;
using SRM.Domain.Repository;
using System.Collections.Generic;

namespace SRM.Domain.Interfaces.Applications
{
    public interface IClienteApplication<TContext> : ISRMApplicationBase<TContext, Cliente, int> 
        where TContext : IUnitOfWork<TContext>
    {
        List<Cliente> GetClientes(string nome);

        void Salvar(Cliente model);

        void Salvar(List<Cliente> model);

        ArquivoLido<Cliente> LerArquivo(string caminho);
    }
}