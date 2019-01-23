using Microsoft.Extensions.DependencyInjection;
using SRM.Application.ServiceApplication;
using SRM.Domain.Interfaces.Applications;
using SRM.Domain.Interfaces.Repositories;
using SRM.Domain.Interfaces.Service;
using SRM.Domain.Repository;
using SRM.Domain.Services;
using SRM.Repository;
using SRM.Repository.Repositories;

namespace SRM.Ioc
{
    public static class SRMIoc
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped(typeof(IUnitOfWork<SRMContext>), typeof(SRMContext));
            services.AddScoped(typeof(IClienteApplication<>), typeof(ClienteApplication<>));
            services.AddScoped(typeof(IClienteService<>), typeof(ClienteService<>));
            services.AddScoped(typeof(IClienteRepository<>), typeof(ClienteRepository<>));
        }
    }
}
