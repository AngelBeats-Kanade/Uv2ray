using System;
using System.Collections.Generic;
using System.Text;

namespace Uv2ray.Core.Models
{
    public class BlackHoleOutBoundConfiguration
    {
        public Response Response { get; set; }
    }

    public class BlackHole
    {
        public BlackHoleOutBoundConfiguration OutBoundConfiguration { get; set; }
    }

    public class DNSOutBoundConfiguration
    {
        public string Network { get; set; }
        public string Address { get; set; }
        public int Port { get; set; }
    }

    public class DNS
    {
        public DNSOutBoundConfiguration OutBoundConfiguration { get; set; }
    }

    public class Dokodemo_doorInboundConfiguration
    {
        public string Network { get; set; }
        public string Address { get; set; }
        public int Port { get; set; }
    }

    public class Dokodemo_door
    {
        public Dokodemo_doorInboundConfiguration InboundConfiguration { get; set; }
    }

    public class FreedomOutboundConfiguration
    {
        public string DomainStrategy { get; set; }
        public string Redirect { get; set; }
        public int UserLevel { get; set; }
    }

    public class Freedom
    {
        public FreedomOutboundConfiguration OutboundConfiguration { get; set; }
    }

    public class HttpAccount
    {
        public string User { get; set; }
        public string Pass { get; set; }
    }

    public class HttpInboundConfiguration
    {
        public int Timeout { get; set; }
        public List<HttpAccount> Accounts { get; set; }
        public bool AllowTransparent { get; set; }
        public int UserLevel { get; set; }
    }

    public class HttpUser
    {
        public string User { get; set; }
        public string Pass { get; set; }
    }

    public class HttpServer
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public List<HttpUser> Users { get; set; }
    }

    public class HttpOutboundConfiguration
    {
        public List<HttpServer> Servers { get; set; }
    }

    public class Http
    {
        public HttpInboundConfiguration InboundConfiguration { get; set; }
        public HttpOutboundConfiguration OutboundConfiguration { get; set; }
    }

    public class SocksAccount
    {
        public string User { get; set; }
        public string Pass { get; set; }
    }

    public class SocksInboundConfiguration
    {
        public string Auth { get; set; }
        public List<SocksAccount> Accounts { get; set; }
        public bool Udp { get; set; }
        public string Ip { get; set; }
        public int UserLevel { get; set; }
    }

    public class SocksUser
    {
        public string User { get; set; }
        public string Pass { get; set; }
        public int Level { get; set; }
    }

    public class SocksServer
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public List<SocksUser> Users { get; set; }
    }

    public class SocksOutboundConfiguration
    {
        public List<SocksServer> Servers { get; set; }
    }

    public class Socks
    {
        public SocksInboundConfiguration InboundConfiguration { get; set; }
        public SocksOutboundConfiguration OutboundConfiguration { get; set; }
    }

    public class VmessClient
    {
        public string Id { get; set; }
        public int Level { get; set; }
        public int AlterId { get; set; }
        public string Email { get; set; }
    }

    public class VmessDefault
    {
        public int Level { get; set; }
        public int AlterId { get; set; }
    }

    public class VmessDetour
    {
        public string To { get; set; }
    }

    public class VmessInboundConfiguration
    {
        public List<VmessClient> Clients { get; set; }
        public VmessDefault Default { get; set; }
        public VmessDetour Detour { get; set; }
        public bool DisableInsecureEncryption { get; set; }
    }

    public class VMessUser
    {
        public string Id { get; set; }
        public int AlterId { get; set; }
        public string Security { get; set; }
        public int Level { get; set; }
    }

    public class VMessServer
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public List<VMessUser> Users { get; set; }
    }

    public class VmessOutboundConfiguration
    {
        public List<VMessServer> Vnext { get; set; }
    }

    public class Vmess
    {
        public VmessInboundConfiguration InboundConfiguration { get; set; }
        public VmessOutboundConfiguration OutboundConfiguration { get; set; }
    }

    public class ShadowsocksInboundConfiguration
    {
        public string Email { get; set; }
        public string Method { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }
        public string Network { get; set; }
        public bool IvCheck { get; set; }
    }

    public class ShadowsocksServer
    {
        public string Email { get; set; }
        public string Address { get; set; }
        public int Port { get; set; }
        public string Method { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }
        public bool IvCheck { get; set; }
    }

    public class ShadowsocksOutboundConfigurations
    {
        public List<ShadowsocksServer> Servers { get; set; }
    }

    public class Shadowsocks
    {
        public ShadowsocksInboundConfiguration InboundConfiguration { get; set; }
        public ShadowsocksOutboundConfigurations OutboundConfigurations { get; set; }
    }

    public class TrojanClient
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public int Level { get; set; }
    }

    public class TrojanFallback
    {
        public string Alpn { get; set; }
        public string Path { get; set; }
        public int Dest { get; set; }
        public int Xver { get; set; }
    }

    public class TrojanInboundConfiguration
    {
        public List<TrojanClient> Clients { get; set; }
        public List<TrojanFallback> Fallbacks { get; set; }
    }

    public class TrojanServer
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Level { get; set; }
    }

    public class TrojanOutboundConfiguration
    {
        public List<TrojanServer> Servers { get; set; }
    }

    public class Trojan
    {
        public TrojanInboundConfiguration InboundConfiguration { get; set; }
        public TrojanOutboundConfiguration OutboundConfiguration { get; set; }
    }

    public class VLESSClient
    {
        public string Id { get; set; }
        public int Level { get; set; }
        public string Email { get; set; }
    }

    public class VLESSFallback
    {
        public string Alpn { get; set; }
        public string Path { get; set; }
        public int Dest { get; set; }
        public int Xver { get; set; }
    }

    public class VLESSInboundConfiguration
    {
        public List<VLESSClient> Clients { get; set; }
        public string Decryption { get; set; }
        public List<VLESSFallback> Fallbacks { get; set; }
    }

    public class VLESSUser
    {
        public string Id { get; set; }
        public string Encryption { get; set; } = "none";
        public int Level { get; set; }
    }

    public class VLESSServer
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public List<VLESSUser> Users { get; set; }
    }

    public class VLESSOutboundConfiguration
    {
        public List<VLESSServer> Vnext { get; set; }
    }

    public class VLESS
    {
        public VLESSInboundConfiguration InboundConfiguration { get; set; }
        public VLESSOutboundConfiguration OutboundConfiguration { get; set; }
    }

    public class LoopbackOutboundConfiguration
    {
        public string InboundTag { get; set; }
    }

    public class Loopback
    {
        public LoopbackOutboundConfiguration OutboundConfiguration { get; set; }
    }

    public class Protocol
    {
        public BlackHole BlackHole { get; set; }
        public DNS DNS { get; set; }
        public Dokodemo_door Dokodemo_Door { get; set; }
        public Freedom Freedom { get; set; }
        public Http Http { get; set; }
        public Socks Socks { get; set; }
        public Vmess Vmess { get; set; }
        public Shadowsocks Shadowsocks { get; set; }
        public Trojan Trojan { get; set; }
        public VLESS VLESS { get; set; }
        public Loopback Loopback { get; set; }
    }
}
