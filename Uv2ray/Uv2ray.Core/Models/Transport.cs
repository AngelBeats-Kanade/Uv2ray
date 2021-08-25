using System;
using System.Collections.Generic;
using System.Text;

namespace Uv2ray.Core.Models
{
    public class Request
    {
        public string Version { get; set; }
        public string Method { get; set; }
        public List<string> Path { get; set; }
        public Dictionary<string, List<string>> Headers { get; set; }
    }

    public class Response
    {
        public string Version { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public Dictionary<string, List<string>> Headers { get; set; }
    }

    public class Header
    {
        public string Type { get; set; }
        public Request Request { get; set; }
        public Response Response { get; set; }
    }

    public class Headers
    {
        public string Host { get; set; }
    }

    public class TcpSettings
    {
        public bool AcceptProxyProtocol { get; set; }
        public Header Header { get; set; }
    }

    public class KcpSettings
    {
        public int Mtu { get; set; }
        public int Tti { get; set; }
        public int UplinkCapacity { get; set; }
        public int DownlinkCapacity { get; set; }
        public bool Congestion { get; set; }
        public int ReadBufferSize { get; set; }
        public int WriteBufferSize { get; set; }
        public Header Header { get; set; }
        public string Seed { get; set; }
    }

    public class WsSettings
    {
        public bool AcceptProxyProtocol { get; set; }
        public string Path { get; set; }
        public Headers Headers { get; set; }
        public int MaxEarlyData { get; set; }
        public bool UseBrowserForwarding { get; set; }
        public string EarlyDataHeaderName { get; set; }
    }

    public class HttpSettings
    {
        public List<string> Host { get; set; }
        public string Path { get; set; }
        public string Method { get; set; }
        public Dictionary<string, List<string>> Headers { get; set; }
    }

    public class QuicSettings
    {
        public string Security { get; set; }
        public string Key { get; set; }
        public Header Header { get; set; }
    }

    public class DsSettings
    {
        public string Path { get; set; }
        public bool Abstract { get; set; }
        public bool Padding { get; set; }
    }

    public class GrpcSettings
    {
        public string ServiceName { get; set; }
        public bool MultiMode { get; set; }
    }

    public class Certificates
    {
        public string Usage { get; set; }
        public string CertificateFile { get; set; }
        public string KeyFile { get; set; }
        public List<string> Certificate { get; set; }
        public List<string> Key { get; set; }
    }

    public class TlsSettings
    {
        public string ServerName { get; set; }
        public bool AllowInsecure { get; set; }
        public List<string> Alpn { get; set; }
        public List<Certificates> Certificates { get; set; }
        public bool DisableSystemRoot { get; set; }
        public string PinnedPeerCertificateChainSha256 { get; set; }
    }

    public class Sockopt
    {
        public int Mark { get; set; }
        public bool TcpFastOpen { get; set; }
        public string Tproxy { get; set; }
        public int TcpKeepAliveInterval { get; set; }
    }

    public class StreamSettings
    {
        public string Network { get; set; }
        public string Security { get; set; }
        public TlsSettings TlsSettings { get; set; }
        public TcpSettings TcpSettings { get; set; }
        public KcpSettings KcpSettings { get; set; }
        public WsSettings WsSettings { get; set; }
        public HttpSettings HttpSettings { get; set; }
        public QuicSettings QuicSettings { get; set; }
        public DsSettings DsSettings { get; set; }
        public GrpcSettings GrpcSettings { get; set; }
        public Sockopt Sockopt { get; set; }
    }

    public class Transport
    {
        public TcpSettings TcpSettings { get; set; }
        public KcpSettings KcpSettings { get; set; }
        public WsSettings WsSettings { get; set; }
        public HttpSettings HttpSettings { get; set; }
        public QuicSettings QuicSettings { get; set; }
        public DsSettings DsSettings { get; set; }
        public GrpcSettings GrpcSettings { get; set; }
    }
}
