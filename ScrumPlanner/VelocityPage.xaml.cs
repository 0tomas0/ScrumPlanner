using ScrumPlanner.Helpers;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ScrumPlanner
{
    /// <summary>
    /// Interaction logic for VelocityPage.xaml
    /// </summary>
    public partial class VelocityPage : Page, IActivable
    {
        public VelocityPage()
        {
            InitializeComponent();
        }

        public Task ActivateAsync(object parameter)
        {
            return Task.CompletedTask;
        }
    }
}
