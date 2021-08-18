using System;

using Uv2ray.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Uv2ray.Views
{
    public sealed partial class ServersPage : Page
    {
        public ServersViewModel ViewModel { get; } = new ServersViewModel();

        public ServersPage()
        {
            InitializeComponent();
            Loaded += ServersPage_Loaded;
        }

        private async void ServersPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.InitializeAsync(ListDetailsViewControl.ViewState);
        }
    }
}
