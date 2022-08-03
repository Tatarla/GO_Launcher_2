using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOR_Launcher
{
    public static class CGameConfig
    {
        // key - previous, value - present
        private static Dictionary<string, string> settingsList;

        public static bool Initialize()
        {
            settingsList = new Dictionary<string, string>();
            if (!File.Exists(Constants.GAME_CONFIG_PATH))
            {
                MessageBox.Show("Can't find game config file!\nPlease, start your game System/Gothic2.exe for the first time, or contact the developer.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            ParseConfig();

            return true;
        }

        private static void ParseConfig()
        {
            string currentLine;
            settingsList.Clear();

            using (var reader = File.OpenText(Constants.GAME_CONFIG_PATH))
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    // music volume
                    if (currentLine.StartsWith("musicVolume=") ||
                        currentLine.StartsWith("soundVolume=") ||
                        currentLine.StartsWith("zStartupWindowed=") ||
                        currentLine.StartsWith("zVidResFullscreenX=") ||
                        currentLine.StartsWith("zVidResFullscreenY=") ||
                        currentLine.StartsWith("mouseSensitivity="))
                        settingsList.Add(currentLine, currentLine);
                }
            }
        }

        public static string GetValue(string valName)
        {
            foreach(KeyValuePair<string, string> kvp in settingsList)
            {
                if (kvp.Value.StartsWith(valName))
                    return kvp.Value.Substring(valName.Length + 1);
            }

            return "0";
        }

        public static void SetValue(string valName, string value)
        {
            for (int i = 0; i < settingsList.Count; i++)
            {
                var item = settingsList.ElementAt(i);
                if (item.Value.StartsWith(valName))
                    settingsList[item.Key] = string.Format("{0}={1}", valName, value);
            }
        }

        public static void SaveConfig()
        {
            string originText = File.ReadAllText(Constants.GAME_CONFIG_PATH);

            foreach (KeyValuePair<string, string> kvp in settingsList)
                originText = originText.Replace(kvp.Key, kvp.Value);

            File.WriteAllText(Constants.GAME_CONFIG_PATH, originText);
            ParseConfig();
        }
    }
}
