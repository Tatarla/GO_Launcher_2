using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace GOR_Launcher
{
    public static class CUrlManager
    {
        public static bool IsAlternative = false;

        public static void CheckConnection()
        {
            using (var wc = new WebClient())
            {
                try
                {
                    wc.DownloadString(Constants.DEFAULT_ADDRESS);
                }
                catch (WebException er) when (er.Status == WebExceptionStatus.NameResolutionFailure)
                {
                    IsAlternative = true;
                }
            }
        }

        public static string Get(string url)
        {
            if (IsAlternative)
                return string.Format(url, Constants.ALTERNATIVE_ADDRESS);
            else
                return string.Format(url, Constants.DEFAULT_ADDRESS);
        }
    }
}
