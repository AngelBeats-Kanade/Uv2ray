﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Uwp.UI.Controls;

using Uv2ray.Core.Models;
using Uv2ray.Core.Services;

namespace Uv2ray.ViewModels
{
    public class ServersViewModel : ObservableObject
    {
        private SampleOrder _selected;

        public SampleOrder Selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }

        public ObservableCollection<SampleOrder> SampleItems { get; private set; } = new ObservableCollection<SampleOrder>();

        public ServersViewModel()
        {
        }

        public async Task LoadDataAsync(ListDetailsViewState viewState)
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
    }
}
