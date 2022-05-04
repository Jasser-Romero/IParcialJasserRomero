using Autofac;
using IParcialJasserRomero.AppCore.Interfaces;
using IParcialJasserRomero.AppCore.Services;
using IParcialJasserRomero.Domain.Interfaces;
using IParcialJasserRomero.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcialJasserRomero.Presentation
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BinaryWeatherRepository>().As<IWeatherModel>();
            builder.RegisterType<WeatherService>().As<IWeatherService>();

            var container = builder.Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(container.Resolve<IWeatherService>()));
        }
    }
}
