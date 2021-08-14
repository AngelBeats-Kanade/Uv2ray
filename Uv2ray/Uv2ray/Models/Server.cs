using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uv2ray.Models
{
    public class Server
    {
        public string Protocol {  get; set; }
        public string Name {  get; set; }
        public string Address {  get; set; }
        public int Port {  get; set; }
        public string Encryption {  get; set; }
        public string Transport {  get; set; }

        public static List<Server> GetServers()
        {
            List<Server> list = new List<Server>
            {
                new Server { Protocol="Vmess", Name="Vultr0", Address = "158.247.206.1", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr1", Address = "50.2.1.4", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr2", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr3", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr4", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr5", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr6", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr7", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr8", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr9", Address = "192.43.222.31", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr10", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr11", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr12", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr13", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr14", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr15", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr16", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr17", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr18", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr19", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr20", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
                new Server { Protocol="Vmess", Name="Vultr21", Address = "158.247.206.253", Port = 12345, Encryption = "auto", Transport = "tcp" },
            };

            return list;
        }
    }
}
