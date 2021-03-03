
using IntroToLogging.Presentation.ViewModels;

namespace IntroToLogging.Presentation.Views
{
    public partial class Main     {
        public MainViewModel _viewModel;

        public Main()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
