using Uv2ray.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Uv2ray.Views
{
    public sealed partial class HomePage : Page
    {
        public HomeViewModel ViewModel { get; } = new HomeViewModel();

        public HomePage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize();
        }
    }
}
