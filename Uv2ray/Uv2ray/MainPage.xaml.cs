using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uv2ray.Pages;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace Uv2ray
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly List<(string Name, Type Page)> _pages = new List<(string Name, Type Page)>
        {
            ("Home",typeof(HomePage)),
            ("Server",typeof(ServerPage)),
            ("Subscription",typeof(SubscriptionPage)),
            ("Help",typeof(HelpPage)),
            ("Settings",typeof(SettingPage)),
        };

        public MainPage()
        {
            InitializeComponent();
        }

        private void MyNavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.InvokedItemContainer != null)
            {
                (string Name, Type Page) item = _pages.FirstOrDefault(x => x.Name.Equals(((NavigationViewItem)args.InvokedItemContainer).Content.ToString()));

                if (!item.Page.Equals(ContentFrame.CurrentSourcePageType))
                {
                    TitleTextBlock.Text = item.Name;
                    _ = ContentFrame.Navigate(item.Page);
                }
            }
        }

        private void ContentFrame_Loaded(object sender, RoutedEventArgs e)
        {
            TitleTextBlock.Text = "Home";
            MyNavigationView.SelectedItem = MyNavigationView.MenuItems.OfType<NavigationViewItem>().FirstOrDefault(n => n.Name.Equals("Home"));
            _ = ContentFrame.Navigate(typeof(HomePage));
        }

        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load page: " + e.SourcePageType.FullName);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _ = Global.AddServers();
            Global.CurrentServer = Global.Servers[0];
        }
    }
}
