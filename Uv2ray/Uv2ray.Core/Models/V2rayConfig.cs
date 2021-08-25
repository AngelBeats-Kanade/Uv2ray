using System;
using System.Collections.Generic;
using System.Text;

namespace Uv2ray.Core.Models
{
    #region Log

    public class Log
    {
        public string Access { get; set; }
        public string Error { get; set; }
        public string Loglevel { get; set; }
    }

    #endregion

    #region Api

    public class Api
    {
        public string Tag { get; set; }
        public List<string> Services { get; set; }
    }

    #endregion

    #region Server

    public class Server
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public string ClientIp { get; set; }
        public bool SkipFallback { get; set; }
        public List<string> Domains { get; set; }
        public List<string> ExpectIPs { get; set; }
    }

    #endregion

    #region Dns

    public class Dns
    {
        public Dictionary<string, List<string>> Hosts { get; set; }
        public List<Server> Servers { get; set; }
        public string ClientIp { get; set; }
        public string QueryStrategy { get; set; }
        public bool DisableCache { get; set; }
        public bool DisableFallback { get; set; }
        public string Tag { get; set; }
    }

    #endregion

    #region Routing

    public class Rule
    {
        public string DomainMatcher { get; set; }
        public string Type { get; set; }
        public List<string> Domains { get; set; }
        public List<string> Ip { get; set; }
        public string Port { get; set; }
        public int SourcePort { get; set; }
        public string Network { get; set; }
        public List<string> Source { get; set; }
        public List<string> User { get; set; }
        public List<string> InboundTag { get; set; }
        public List<string> Protocol { get; set; }
        public string Attrs { get; set; }
        public string OutboundTag { get; set; }
        public string BalancerTag { get; set; }
    }

    public class Strategy
    {
        public string Type { get; set; }
    }

    public class Balancer
    {
        public string Tag { get; set; }
        public List<string> Selector { get; set; }
        public Strategy Strategy { get; set; }
    }

    public class Routing
    {
        public string DomainStrategy { get; set; }
        public string DomainMatcher { get; set; }
        public List<Rule> Rules { get; set; }
        public List<Balancer> Balancers { get; set; }
    }

    #endregion

    #region Policy

    public class LevelPolicy
    {
        public int Handshake { get; set; }
        public int ConnIdle { get; set; }
        public int UplinkOnly { get; set; }
        public int DownlinkOnly { get; set; }
        public bool StatsUserUplink { get; set; }
        public bool StatsUserDownlink { get; set; }
        public int BufferSize { get; set; }
    }

    public class SystemPolicy
    {
        public bool StatsInboundUplink { get; set; }
        public bool StatsInboundDownlink { get; set; }
        public bool StatsOutboundUplink { get; set; }
        public bool StatsOutboundDownlink { get; set; }
    }

    public class Policy
    {
        public Dictionary<string, LevelPolicy> Levels { get; set; }
        public SystemPolicy System { get; set; }
    }

    #endregion

    #region Inbound

    public class User
    {
        public string Id { get; set; }
        public int AlterId { get; set; }
        public string Email { get; set; }
        public string Security { get; set; }
        public string Encryption { get; set; }
        public string Flow { get; set; }
    }

    public class InboundSettings
    {
        public string Auth { get; set; }
        public bool Udp { get; set; }
        public string Ip { get; set; }
        public string Address { get; set; }
        public List<User> Clients { get; set; }
        public string Decryption { get; set; }
        public bool AllowTransparent { get; set; }
    }

    public class Sniffing
    {
        public bool Enabled { get; set; }
        public List<string> DestOverride { get; set; }
        public bool MetadataOnly { get; set; }
    }

    public class Allocate
    {
        public string Strategy { get; set; }
        public int Refresh { get; set; }
        public int Concurrency { get; set; }
    }

    public class Inbound
    {
        public string Listen { get; set; }
        public int Port { get; set; }
        public string Protocol { get; set; }
        public InboundSettings Settings { get; set; }
        public StreamSettings StreamSettings { get; set; }
        public string Tag { get; set; }
        public Sniffing Sniffing { get; set; }
        public Allocate Allocate { get; set; }
    }

    #endregion

    #region Outbound

    public class VnextItem
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public List<User> Users { get; set; }
    }

    public class ServerItem
    {
        public string Email { get; set; }
        public string Address { get; set; }
        public string Method { get; set; }
        public string Password { get; set; }
        public bool Ota { get; set; }
        public bool IvCheck { get; set; } = false;
        public int Port { get; set; }
        public int Leverl { get; set; }
        public List<SocksUser> Users { get; set; }
    }

    public class OutboundSettings
    {
        public List<VnextItem> Vnext { get; set; }
        public List<ServerItem> Servers { get; set; }
        public Response Response { get; set; }
    }

    public class ProxySettings
    {
        public string Tag { get; set; }
        public bool TransportLayer { get; set; }
    }

    public class Mux
    {
        public bool Enabled { get; set; }
        public int Concurrency { get; set; }
    }

    public class Outbound
    {
        public string SendThrough { get; set; }
        public string Protocol { get; set; }
        public OutboundSettings Settings { get; set; }
        public string Tag { get; set; }
        public StreamSettings StreamSettings { get; set; }
        public ProxySettings ProxySettings { get; set; }
        public Mux Mux { get; set; }
    }

    #endregion

    #region Stat

    public class Stat
    {

    }

    #endregion

    #region Reverse

    public class Bridge
    {
        public string Tag { get; set; }
        public string Domain { get; set; }
    }

    public class Portal
    {
        public string Tag { get; set; }
        public string Domain { get; set; }
    }

    public class Reverse
    {
        public List<Bridge> Bridges { get; set; }
        public List<Portal> Portals { get; set; }
    }

    #endregion

    #region FakeDns

    public class FakeDns
    {
        public string IpPool { get; set; }
        public int PoolSize { get; set; }
    }

    #endregion

    #region BrowserForwarder

    public class BrowserForwarder
    {
        public string ListenAddr { get; set; }
        public int ListenPort { get; set; }
    }

    #endregion

    #region Observatory

    public class Observatory
    {
        public List<string> SubjectSelector { get; set; }
    }

    #endregion

    #region V2rayConfig

    public class V2rayConfig
    {
        public Log Log { get; set; }
        public Api Api { get; set; }
        public Dns Dns { get; set; }
        public Routing Routing { get; set; }
        public Policy Policy { get; set; }
        public List<Inbound> Inbounds { get; set; }
        public List<Outbound> Outbounds { get; set; }
        public Transport Transport { get; set; }
        public Stat Stats { get; set; }
        public Reverse Reverse { get; set; }
        public FakeDns FakeDns { get; set; }
        public BrowserForwarder BrowserForwarder { get; set; }
        public Observatory Observatory { get; set; }
    }

    #endregion
}
