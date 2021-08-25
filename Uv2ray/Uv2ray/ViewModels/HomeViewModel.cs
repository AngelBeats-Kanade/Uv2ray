using System;
using System.Threading.Tasks;

using Uv2ray.Behaviors;

using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Uv2ray.ViewModels
{
    public class HomeViewModel : ObservableObject
    {
        private NavigationViewHeaderMode _navigationViewHeaderMode;

        public NavigationViewHeaderMode NavigationViewHeaderMode
        {
            get => _navigationViewHeaderMode;
            set => SetProperty(ref _navigationViewHeaderMode, value);
        }
        public HomeViewModel()
        {
        }

        public void Initialize()
        {
            NavigationViewHeaderMode = GetNavigationViewHeaderMode();
        }

        private NavigationViewHeaderMode GetNavigationViewHeaderMode()
        {
            return NavigationViewHeaderMode.Minimal;
        }
    }
}
