using Microsoft.Extensions.DependencyInjection;
using SRM.Domain.Interfaces.Applications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRM.Ioc;

namespace SRM.App
{
    static class Program
    {
        private static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            SRMIoc.Register(services);
            services.AddTransient<FrmCliente>();
            ServiceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = (FrmCliente)ServiceProvider.GetService(typeof(FrmCliente));
            Application.Run(form);
        }
    }
}
