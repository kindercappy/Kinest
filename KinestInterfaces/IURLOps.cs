using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinestInterfaces
{
    /** <summary>
     * Interface to perform all the URL Operations <para/>
     * AddUrl - Will contain the OPS to add the URL <para/>
     * GetUrlData - Will get all the URL's <para/>
     * GetMatchingUrls(string urlInitia) - Will get the matching url
     * </summary>   
     **/
    public interface IURLOps
    {
        string AddUrl();
        List<string> GetUrlData();
        List<string> GetMatchingUrls(string urlInitial);
    }
}
