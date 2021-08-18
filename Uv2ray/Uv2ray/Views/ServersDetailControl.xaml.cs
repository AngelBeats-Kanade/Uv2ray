using System;

using Uv2ray.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Uv2ray.Views
{
    public sealed partial class ServersDetailControl : UserControl
    {
        public SampleOrder ListMenuItem
        {
            get { return GetValue(ListMenuItemProperty) as SampleOrder; }
            set { SetValue(ListMenuItemProperty, value); }
        }

        public static readonly DependencyProperty ListMenuItemProperty = DependencyProperty.Register("ListMenuItem", typeof(SampleOrder), typeof(ServersDetailControl), new PropertyMetadata(null, OnListMenuItemPropertyChanged));

        public ServersDetailControl()
        {
            InitializeComponent();
        }

        private static void OnListMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ServersDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
