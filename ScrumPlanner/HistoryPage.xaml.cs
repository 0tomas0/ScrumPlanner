using ScrumPlanner.Helpers;
using ScrumPlanner.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ScrumPlanner
{
    /// <summary>
    /// Interaction logic for HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page, IActivable
    {
        public HistoryPage()
        {
            InitializeComponent();

            this.HistoryDG.DataContext = new List<HistoryVelocity>()
            {
                new HistoryVelocity(),
                new HistoryVelocity(),
                new HistoryVelocity(),
            };
        }

        public Task ActivateAsync(object parameter)
        {
            return Task.CompletedTask;
        }
    }
}
