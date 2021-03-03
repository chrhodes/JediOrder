
using IntroToLogging.Presentation.ViewModels;

using VNC;

namespace IntroToLogging.Presentation.Views
{
    public partial class Main     {
        public MainViewModel _viewModel;

        public Main()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            Log.Info("Hello From Logging", Common.LOG_APPNAME);
        }
    }
}
