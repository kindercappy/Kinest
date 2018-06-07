using KinestInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinestOps;

namespace KinestFactory
{
    public class URLOpsFac : IURLOps
    {
        URLOps urlOps;
        private string protocol;
        private string url;

        public string currProtocol { get => protocol; set => protocol = value; }
        public string currUrl { get => url; set => url = value; }

        public URLOpsFac(string protocol, string url)
        {
            currProtocol = protocol;
            currUrl = url;
        }

        public string AddUrl()
        {
            urlOps = new URLOps(protocol,currUrl);
            string meessage = urlOps.AddUrl();
            return meessage;
        }

        public List<string> GetMatchingUrls(string urlInitial)
        {
            return urlOps.GetMatchingUrls(urlInitial);
        }

        public List<string> GetUrlData()
        {
            return urlOps.GetUrlData();
        }
    }
}
