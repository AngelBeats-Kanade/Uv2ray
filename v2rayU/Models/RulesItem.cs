using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2rayU.Models
{
    [Serializable]
    public class RulesItem
    {
        public string type { get; set; }

        public string port { get; set; }

        public List<string> inboundTag { get; set; }

        public string outboundTag { get; set; }

        public List<string> ip { get; set; }

        public List<string> domain { get; set; }

        public List<string> protocol { get; set; }
    }
}
