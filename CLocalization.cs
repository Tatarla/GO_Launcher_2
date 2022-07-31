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
        static Dictionary<string, string> langMap;

        public static void Initialize()
        {
            RegisterLanguage("en_US", "English (US)");
            RegisterLanguage("ru_RU", "Русский");

            SwapLanguage(Constants.DEFAULT_LANGUAGE);
        }

        public static void RegisterLanguage(string code, string name)
        {
            // Initializing langMap if its first language
            if (langMap == null)
                langMap = new Dictionary<string, string>();

            langMap.Add(code, name);
        }

        public static bool IsLanguageExist(string code)
        {
            return langMap.ContainsKey(code);
        }

        public static bool SwapLanguage(string langName)
        {
            if (IsLanguageExist(langName))
            {
                resMan = new ResourceManager("GOR_Launcher." + langName, Assembly.GetExecutingAssembly());
                return true;
            }

            return false;
        }

        public static string Get(string name)
        {
            return resMan.GetString(name);
        }
    }

}
