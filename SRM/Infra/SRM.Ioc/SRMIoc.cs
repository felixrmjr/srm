using Microsoft.Extensions.DependencyInjection;
using SRM.Application.ServiceApplication;
using SRM.Domain.Interfaces.Applications;
using SRM.Domain.Interfaces.Repositories;
using SRM.Domain.Interfaces.Service;
using SRM.Domain.Repository;
using SRM.Domain.Services;
using SRM.Repository;
using SRM.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRM.Ioc
{
    public static class SRMIoc
    {
        //public static void Register(IServiceCollection services)
        //{

        //}


        public static void Register(IServiceCollection services)
        {
            //services.AddScoped<IUnitOfWork<CoreContext>, CoreContext>();

            services.AddScoped(typeof(IUnitOfWork<SRMContext>), typeof(SRMContext));

            services.AddScoped(typeof(IClienteApplication<>), typeof(ClienteApplication<>));
            services.AddScoped(typeof(IClienteService<>), typeof(ClienteService<>));
            services.AddScoped(typeof(IClienteRepository<>), typeof(ClienteRepository<>));
            //services.AddTransient<ISomeThing, SomeThing>();

            //ServiceProvider = services.BuildServiceProvider();
        }
    }
}
