using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

using System.Collections.ObjectModel;
using System.Windows.Input;

using Uv2ray.Behaviors;
using Uv2ray.Core.Models;
using Uv2ray.Core.Services;

namespace Uv2ray.ViewModels
{
    public class HomeViewModel : ObservableObject
    {
        private ObservableCollection<V2rayConfig> _servers = new ObservableCollection<V2rayConfig>();

        public ObservableCollection<V2rayConfig> Servers
        {
            get => _servers;
            set => SetProperty(ref _servers, value);
        }

        private NavigationViewHeaderMode _navigationViewHeaderMode;

        public NavigationViewHeaderMode NavigationViewHeaderMode
        {
            get => _navigationViewHeaderMode;
            set => SetProperty(ref _navigationViewHeaderMode, value);
        }

        private ICommand _addButtonCommand;

        public ICommand AddButtonCommand
        {
            get
            {
                if (_addButtonCommand == null)
                {
                    _addButtonCommand = new RelayCommand(
                    () =>
                    {
                        Servers.Add(V2rayFacade.GetV2rayConfig());
                    });
                }
                return _addButtonCommand;
            }
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
