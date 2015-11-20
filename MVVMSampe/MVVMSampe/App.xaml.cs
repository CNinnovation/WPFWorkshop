using Microsoft.Framework.DependencyInjection;
using MVVMSampe.Services;
using MVVMSampe.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMSampe
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            RegisterServices();
        }

        private void RegisterServices()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<IBooksService, BooksService>();
            services.AddSingleton<IMessagingService, WPFMessagingService>();
            services.AddTransient<BooksViewModel>();
            services.AddTransient<BookViewModel>();

            Container = services.BuildServiceProvider();
        }

        public IServiceProvider Container { get; private set; }
    }
}
