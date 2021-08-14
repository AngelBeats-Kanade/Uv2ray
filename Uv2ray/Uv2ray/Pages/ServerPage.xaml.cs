using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uv2ray.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace Uv2ray.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ServerPage : Page
    {
        public ServerPage()
        {
            InitializeComponent();
        }

        private void SetButton_Click(object sender, RoutedEventArgs e)
        {
            Global.CurrentServer = (Server)ServerPageListView.SelectedItem;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Global.Servers.Add(new Server { Address = "", Name = "", Encryption = "", Port = 1, Protocol = "", Transport = "" });
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Server> selectedServer = from server in Global.Servers
                                                 where server.Address.Equals(((Server)ServerPageListView.SelectedItem).Address)
                                                 select server;
            foreach (Server server in selectedServer.ToList())
            {
                _ = Global.Servers.Remove(server);
            }
        }
    }
}
