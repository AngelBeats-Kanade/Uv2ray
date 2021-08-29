using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

using System.Collections.ObjectModel;
using System.Windows.Input;

using Uv2ray.Behaviors;
using Uv2ray.Core.Models;
using Uv2ray.Core.Services;

using Windows.UI.Xaml.Controls;

namespace Uv2ray.ViewModels
{
    public class HomeViewModel : ObservableObject
    {
        private ObservableCollection<V2rayConfig> _servers = V2rayFacade.Servers;

        public ObservableCollection<V2rayConfig> Servers
        {
            get => _servers;
            set => SetProperty(ref _servers, value);
        }

        private V2rayConfig _selected;

        public V2rayConfig Selected
        {
            get => _selected;
            set => SetProperty(ref _selected, value);
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

        private ICommand _deleteButtonCommand;

        public ICommand DeleteButtonCommand
        {
            get
            {
                if (_deleteButtonCommand == null)
                {
                    _deleteButtonCommand = new RelayCommand(
                        () =>
                        {
                            Servers.Remove(Selected);
                        });
                }
                return _deleteButtonCommand;
            }
        }

        public HomeViewModel()
        {
        }

        public void Initialize()
        {
            NavigationViewHeaderMode = GetNavigationViewHeaderMode();
        }

        public void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Selected = e.ClickedItem as V2rayConfig;
        }

        private NavigationViewHeaderMode GetNavigationViewHeaderMode()
        {
            return NavigationViewHeaderMode.Minimal;
        }
    }
}
