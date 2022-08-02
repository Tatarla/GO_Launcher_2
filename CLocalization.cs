using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;
using MaterialSkin.Controls;

namespace GOR_Launcher
{
    public static class CLocalization
    {
        static ResourceManager              resMan;
        static Dictionary<string, string>   langMap;
        static string                       currentLanguage;

        static SettingsForm                 settingsForm;
        static AddFilesForm                 addFilesForm;
        static MainForm                     launcherForm;

        public static void Initialize()
        {
            RegisterLanguage("en_US", "English (US)");
            RegisterLanguage("ru_RU", "Русский");

            if (CSettings.Get("language").ToString() == "null")
                Translate(Constants.DEFAULT_LANGUAGE);
            else
                Translate(CSettings.Get("language").ToString());

        }

        public static void UpdateMainForm(MainForm form)
        {
            launcherForm = form;
        }

        public static void UpdateSettingsForm(SettingsForm form)
        {
            settingsForm = form;
        }

        public static void UpdateAddFilesForm(AddFilesForm form)
        {
            addFilesForm = form;
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
                resMan          = new ResourceManager("GOR_Launcher." + langName, Assembly.GetExecutingAssembly());
                currentLanguage = langName;
                return true;
            }

            return false;
        }

        public static string Get(string name)
        {
            return resMan.GetString(name);
        }

        public static string GetLanguage()
        {
            return currentLanguage;
        }

        public static List<string> GetLanguageList()
        {
            List<string> returnList = new List<string>();

            foreach (KeyValuePair<string, string> kvp in langMap)
                returnList.Add(kvp.Value);

            return returnList;
        }

        public static string GetLanguageByName(string name)
        {
            foreach (KeyValuePair<string, string> kvp in langMap)
                if (kvp.Value == name)
                    return kvp.Key;

            return "none";
        }

        public static string GetLanguageByCode(string code)
        {
            foreach (KeyValuePair<string, string> kvp in langMap)
                if (kvp.Key == code)
                    return kvp.Value;

            return "none";
        }

        public static void Translate(string langCode)
        {
            SwapLanguage(langCode);

            CSettings.Set("language", langCode);

            if (launcherForm != null) launcherForm.Translate();
            if (settingsForm != null) settingsForm.Translate();
            if (addFilesForm != null) addFilesForm.Translate();
        }

    }

}
