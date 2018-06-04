using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinestInterfaces
{
    public interface IURLOps
    {
        string AddUrl();
        List<string> getUrlData();
        List<string> getMatchingUrls(string urlInitial);
    }
}
