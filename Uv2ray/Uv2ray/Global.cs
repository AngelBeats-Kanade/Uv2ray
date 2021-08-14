using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uv2ray.Models;

namespace Uv2ray
{
    public static class Global
    {
        public static ObservableCollection<Server> Servers { get; set; } = new ObservableCollection<Server>();

        public static Server CurrentServer { get; set; }

        public static ObservableCollection<Server> AddServers()
        {
            foreach (Server server in Server.GetServers())
            {
                Servers.Add(server);
            }

            return Servers;
        }
    }
}
