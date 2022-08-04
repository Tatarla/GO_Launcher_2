using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MaterialSkin;

namespace GOR_Launcher
{
    public static class Constants
    {
        public static string DEFAULT_LANGUAGE               = "en_US";

        public static string BANNER_URL                     = "http://g2-mp.ru/files/";
        public static string FILE_LIST_URL                  = "http://g2-mp.ru/files/";
        public static string VERSION_FILE_URL               = "http://g2-mp.ru/files/version.xml";
        public static string REMOTE_CONFIG_URL              = "http://g2-mp.ru/files/config.xml";

        public static string ADDFILES_DX11                  = "http://g2-mp.ru/files/additional_files/DX11/";
        public static string ADDFILES_CUSTOMFONTS           = "http://g2-mp.ru/files/additional_files/Fonts/";
        public static string ADDFILES_NOGRASS               = "http://g2-mp.ru/files/additional_files/NoGrass/";

        public static string DISCORD_LINK                   = "https://discord.gg/JNqbr3TBjH";
        public static string WEBSITE_LINK                   = "https://g2-mp.ru/";

        // DO NOT change that if you dont know what it is
        public static string G2O_API_URL                    = "http://api.gothic-online.com.pl/master/server/{0}/";

        public static string CONFIG_FOLDER_PATH             = ".launcher/";
        public static string VERSION_FILE_NAME              = "version.xml";
        public static string GAME_CONFIG_PATH               = "System/Gothic.ini";
        public static string GAME_EXEC                      = "System/Gothic2.exe"; 
        public static string G2O_EXEC                       = "G2O_Proxy.dll"; 

        public static Color LINKS_PANEL_COLOR               = Color.FromArgb(100, 40, 47, 99);
        public static Color NEWS_PANEL_COLOR                = Color.FromArgb(100, 0, 0, 0);
        public static Color SERVER_STATUS_OK_COLOR          = Color.FromArgb(50, 0, 255, 0);
        public static Color SERVER_STATUS_OFF_COLOR         = Color.FromArgb(50, 255, 255, 0);
        public static Color PLAY_BUTTON_COLOR               = Color.FromArgb(255, 40, 47, 99);
        public static ColorScheme MATERIAL_DEFAULT_COLOR    = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue500, Accent.Blue400, TextShade.WHITE);
    }
}
