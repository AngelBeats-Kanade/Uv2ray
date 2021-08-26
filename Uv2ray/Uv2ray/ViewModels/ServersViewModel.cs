using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Uwp.UI.Controls;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Uv2ray.Behaviors;
using Uv2ray.Core.Models;
using Uv2ray.Core.Services;

namespace Uv2ray.ViewModels
{
    public class ServersViewModel : ObservableObject
    {
        private SampleOrder _selected;

        public SampleOrder Selected
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

        public ObservableCollection<SampleOrder> SampleItems { get; private set; } = new ObservableCollection<SampleOrder>();

        public ServersViewModel()
        {
            NavigationViewHeaderMode = GetNavigationViewHeaderMode();
        }

        public async Task InitializeAsync(ListDetailsViewState viewState)
        {
            await LoadDataAsync(viewState);
            await Task.CompletedTask;
        }

        private async Task LoadDataAsync(ListDetailsViewState viewState)
        {
            SampleItems.Clear();

            var data = await SampleDataService.GetListDetailsDataAsync();

            foreach (var item in data)
            {
                SampleItems.Add(item);
            }

            if (viewState == ListDetailsViewState.Both)
            {
                Selected = SampleItems.First();
            }
        }

        private NavigationViewHeaderMode GetNavigationViewHeaderMode()
        {
            return NavigationViewHeaderMode.Never;
        }
    }
}
