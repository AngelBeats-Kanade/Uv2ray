using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

using Uv2ray.Core.Models;

namespace Uv2ray.Core.Services
{
    public class V2rayFacade
    {
        public static V2rayConfig GetV2rayConfig()
        {
            FileStream fs = new FileStream("./template.json", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string json = sr.ReadToEnd().ToString();
            var result = JsonConvert.DeserializeObject<V2rayConfig>(json);
            return result;
        }

        public static ObservableCollection<V2rayConfig> Servers { get; set; } = new ObservableCollection<V2rayConfig>();

        public static ObservableCollection<V2rayConfig> AllServers()
        {
            ObservableCollection<V2rayConfig> servers = new ObservableCollection<V2rayConfig>
            {
                GetV2rayConfig(),
                GetV2rayConfig(),
                GetV2rayConfig(),
                GetV2rayConfig(),
                GetV2rayConfig(),
                GetV2rayConfig(),
                GetV2rayConfig(),
                GetV2rayConfig(),
                GetV2rayConfig(),
                GetV2rayConfig()
            };

            return servers;
        }

        public static ObservableCollection<V2rayConfig> GetAllServers(ObservableCollection<V2rayConfig> servers)
        {
            foreach (var server in AllServers())
            {
                servers.Add(server);
            }

            return servers;
        }
    }
}
