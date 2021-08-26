using Newtonsoft.Json;

using System;
using System.Collections.Generic;
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
    }
}
