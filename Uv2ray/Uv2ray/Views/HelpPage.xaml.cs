using System;

using Uv2ray.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Uv2ray.Views
{
    public sealed partial class HelpPage : Page
    {
        public HelpViewModel ViewModel { get; } = new HelpViewModel();

        public HelpPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
