using ScrumPlanner.Helpers;
using System.Windows;

namespace ScrumPlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly NavigationService _navigationService;

        public MainWindow(NavigationService navigationService)
        {
            InitializeComponent();

            this._navigationService = navigationService;
        }

        private async void VelocityItem_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = await this._navigationService.ShowPageAsync<VelocityPage>();
        }

        private async void HistoryItem_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = await this._navigationService.ShowPageAsync<HistoryPage>();
        }

        private void ExitItem_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
