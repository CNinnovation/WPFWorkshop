using BooksViewModelsLib.ViewModels;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Practices.Prism.PubSubEvents;
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
            EventAggregator = new EventAggregator();
        }

        private void RegisterServices()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<IBooksService, BooksService>();
            services.AddSingleton<IMessagingService, WPFMessagingService>();
            services.AddTransient<BooksViewModel>();
            services.AddTransient<BookViewModel>();
            services.AddTransient<RandomViewModel>();

            Container = services.BuildServiceProvider();
        }

        public EventAggregator EventAggregator { get; private set; }

        public IServiceProvider Container { get; private set; }
    }
}
