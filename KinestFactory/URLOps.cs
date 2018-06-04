using KinestInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinestFactory
{
    public class URLOps : IURLOps
    {
        private string protocol;
        private string url;

        public string currProtocol { get => protocol; set => protocol = value; }
        public string currUrl { get => url; set => url = value; }

        public URLOps(string protocol, string url)
        {
            currProtocol = protocol;
            currUrl = url;
        }

        public URLOps()
        {

        }

        public string AddUrl()
        {
            throw new NotImplementedException();
        }

        public List<string> getMatchingUrls(string urlInitial)
        {
            throw new NotImplementedException();
        }

        public List<string> getUrlData()
        {
            throw new NotImplementedException();
        }
    }
}
