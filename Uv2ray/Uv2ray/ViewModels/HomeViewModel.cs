using System;
using System.Threading.Tasks;

using Uv2ray.Behaviors;

using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Uv2ray.ViewModels
{
    public class HomeViewModel : ObservableObject
    {
        private NavigationViewHeaderMode _navigationViewHeadeerMode;

        public NavigationViewHeaderMode NavigationViewHeaderMode
        {
            get => _navigationViewHeadeerMode;
            set => SetProperty(ref _navigationViewHeadeerMode, value);
        }
        public HomeViewModel()
        {
        }

        public async Task InitializeAsync()
        {
            NavigationViewHeaderMode = GetNavigationViewHeaderMode();
            await Task.CompletedTask;
        }

        private NavigationViewHeaderMode GetNavigationViewHeaderMode()
        {
            return NavigationViewHeaderMode.Minimal;
        }
    }
}
