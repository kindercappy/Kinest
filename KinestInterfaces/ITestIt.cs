using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinestInterfaces
{
    /** <summary>
     * Interface to browser specific Operations <para/>
     * OpenUrl(string url) - Will Open the URL Provided <para/>
     * closeBrowsers - Will close all browsers <para/>
     * </summary>
     **/
    public interface ITestIt
    {
        void OpenUrl(string url);
        void closeBrowsers();
    }
}
