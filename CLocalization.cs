using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;

namespace GOR_Launcher
{
    public static class CLocalization
    {
        static ResourceManager resMan;

        public static void Initialize()
        {
            SwapLanguage(Constants.DEFAULT_LANGUAGE);
        }

        public static void SwapLanguage(string langName)
        {
            resMan = new ResourceManager("GOR_Launcher." + langName, Assembly.GetExecutingAssembly());
        }

        public static string Get(string name)
        {
            return resMan.GetString(name);
        }
    }

}
