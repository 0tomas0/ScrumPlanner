using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ScrumPlanner.Helpers
{
    public interface IActivable
    {
        Task ActivateAsync(object parameter);
    }

    public class NavigationService
    {
        private readonly IServiceProvider serviceProvider;

        public NavigationService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public async Task ShowAsync<T>(object parameter = null) where T : Window
        {
            var window = serviceProvider.GetRequiredService<T>();
            if (window is IActivable activableWindow)
            {
                await activableWindow.ActivateAsync(parameter);
            }
            window.Show();
        }

        public async Task<T> ShowPageAsync<T>(object parameter = null) where T : Page
        {
            var window = serviceProvider.GetRequiredService<T>();
            if (window is IActivable activableWindow)
            {
                await activableWindow.ActivateAsync(parameter);
            }
            return window;
        }

        public async Task<bool?> ShowDialogAsync<T>(object parameter = null) where T : Window
        {
            var window = serviceProvider.GetRequiredService<T>();
            if (window is IActivable activableWindow)
            {
                await activableWindow.ActivateAsync(parameter);
            }
            return window.ShowDialog();
        }
    }
}
