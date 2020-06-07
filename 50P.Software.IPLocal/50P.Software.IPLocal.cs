using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _50P.Software.IPLocal
{
    public class getIP
    {
        List<string> ips;
        private string ipAdresa;
        private string ipAdresy;
        private string[] IpAdresy;
        private string hostname;
        private string oddělovač;
        public void HOST(string HostName)
        {
            hostname = HostName;
            ips = new List<string>();
            foreach (IPAddress ipadrress in Dns.GetHostAddresses(hostname))
            {
                if (ipadrress.AddressFamily == AddressFamily.InterNetwork)
                {
                    ips.Add(ipadrress.ToString());
                }
            }
            int i = 0;
            int index = 0;
            IpAdresy = new string[ips.Count];
            while (i < ips.Count)
            {
                IpAdresy[index] = ips[i];
                index++;
                i++;
            }
        }
        public string IPAdresy
        {
            get
            {
                ipAdresy = null;
                int i = 0;
                while (i < ips.Count)
                {
                    if (i == ips.Count - 1)
                    {
                        ipAdresy += IpAdresy[i];
                    }
                    else
                    {
                        ipAdresy += IpAdresy[i] + oddělovač;
                    }
                    i++;
                }
                return ipAdresy;
            }
        }
        public void Oddělovač(string Oddělovač)
        {
            oddělovač = Oddělovač;
        }
        public string IP
        {
            get
            {
                ipAdresa = IpAdresy[0];
                return ipAdresa;
            }
        }
        public getIP(bool Rozdělit, string HostName)
        {
            if (Rozdělit)
            {
                hostname = HostName;
                ips = new List<string>();
                foreach (IPAddress ipadrress in Dns.GetHostAddresses(hostname))
                {
                    if (ipadrress.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ips.Add(ipadrress.ToString());
                    }
                }
                int i = 0;
                int index = 0;
                IpAdresy = new string[ips.Count];
                while (i < ips.Count)
                {
                    IpAdresy[index] = ips[i];
                    index++;
                    i++;
                }
            }
        }
        public getIP()
        {
        }
    }
}
