//using DddInPractice.UI.Management;

using DddInPractice.UI.SnackMachines;
using DddInPractice.Logic;

namespace DddInPractice.UI.Common
{
    public class MainViewModel : ViewModel
    {
        //public DashboardViewModel Dashboard { get; private set; }

        public MainViewModel()
        {
            //Dashboard = new DashboardViewModel();
            var viewModel = new SnackMachineViewModel(new SnackMachine());
        }
    }
}
