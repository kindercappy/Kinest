using KinestInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinestOps;
using System.Threading;
using System.Windows.Forms;

namespace KinestFactory
{
    public class URLOpsFac : IURLOps
    {
        URLOps urlOps;
        private string protocol;
        private string url;
        string meessage;
        Thread urlOpsThread;

        public string currProtocol { get => protocol; set => protocol = value; }
        public string currUrl { get => url; set => url = value; }

        public URLOpsFac(string protocol, string url)
        {
            currProtocol = protocol;
            currUrl = url;
        }

        public string AddUrl()
        {
            urlOps = new URLOps(protocol, currUrl);
            if (urlOpsThread == null)
            {
                urlOpsThread = new Thread(AddUrlOnThread);
                urlOpsThread.Start();
            }
            return meessage;
        }

        private void AddUrlOnThread()
        {
            meessage = urlOps.AddUrl();
            MessageBox.Show(meessage);
            urlOpsThread.Abort();
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
