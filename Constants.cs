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
        public static string DEFAULT_LANGUAGE               = "ru_RU";

        public static string DEFAULT_ADDRESS                = "http://g2-mp.ru/";
        public static string ALTERNATIVE_ADDRESS            = "http://185.200.190.211/";
        public static string BANNER_URL                     = "{0}files/";
        public static string FILE_LIST_URL                  = "{0}files/";
        public static string VERSION_FILE_URL               = "{0}files/version.xml";
        public static string REMOTE_CONFIG_URL              = "{0}files/config.xml";

        public static string ADDFILES_DX11                  = "{0}files/additional_files/DX11/";
        public static string ADDFILES_CUSTOMFONTS           = "{0}files/additional_files/Fonts/";
        public static string ADDFILES_NOGRASS               = "{0}files/additional_files/NoGrass/";

        public static string DISCORD_LINK                   = "https://discord.gg/JNqbr3TBjH";
        public static string WEBSITE_LINK                   = "https://g2-mp.ru/";
        public static string VK_LINK                        = "https://vk.com/g2_mp";

        // DO NOT change that if you dont know what it is
        public static string G2O_API_URL                    = "http://api.gothic-online.com.pl/master/server/{0}/";

        public static string CONFIG_FOLDER_PATH             = ".launcher/";
        public static string VERSION_FILE_NAME              = "version.xml";
        public static string GAME_CONFIG_PATH               = "System/Gothic.ini";
        public static string GAME_EXEC                      = "System/Gothic2.exe"; 
        public static string G2O_EXEC                       = "G2O_Proxy.dll"; 

        public static Color LINKS_PANEL_COLOR               = Color.FromArgb(99, 40, 47, 99);
        public static Color NEWS_PANEL_COLOR                = Color.FromArgb(99, 0, 0, 0);
        public static Color SERVER_STATUS_OK_COLOR          = Color.FromArgb(99, 0, 255, 0);
        public static Color SERVER_STATUS_OFF_COLOR         = Color.FromArgb(99, 255, 255, 0);
        public static Color PLAY_BUTTON_COLOR               = Color.FromArgb(99, 40, 47, 99);
        public static ColorScheme MATERIAL_DEFAULT_COLOR    = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue500, Accent.Blue400, TextShade.WHITE);
    }
}
