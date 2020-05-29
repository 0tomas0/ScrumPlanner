using Microsoft.Extensions.DependencyInjection;
using ScrumPlanner.Helpers;
using System;
using System.Windows;

namespace ScrumPlanner
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var navigationService = ServiceProvider.GetRequiredService<NavigationService>();
            var task = navigationService.ShowAsync<MainWindow>();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<NavigationService>();

            services.AddTransient<MainWindow>();
            services.AddTransient<HistoryPage>();
            services.AddTransient<VelocityPage>();
        }
    }
}
