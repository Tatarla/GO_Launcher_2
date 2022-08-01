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

        public static string BANNER_URL                     = "http://rgc-host.ru/testLauncher/banners/testBanner-{0}.png";
        public static string FILE_LIST_URL                  = "http://rgc-host.ru/testLauncher/files.xml";
        public static string FILE_DOWNLOAD_URL              = "http://rgc-host.ru/testLauncher/files/";
        public static string VERSION_FILE_URL               = "http://rgc-host.ru/testLauncher/version.xml";

        public static string CONFIG_FOLDER_PATH             = ".launcher/";
        public static string VERSION_FILE_NAME              = "version.xml";

        public static Color LINKS_PANEL_COLOR               = Color.FromArgb(100, 40, 47, 99);
        public static Color NEWS_PANEL_COLOR                = Color.FromArgb(100, 0, 0, 0);
        public static Color SERVER_STATUS_OK_COLOR          = Color.FromArgb(50, 0, 255, 0);
        public static Color SERVER_STATUS_OFF_COLOR         = Color.FromArgb(50, 255, 255, 0);
        public static Color PLAY_BUTTON_COLOR               = Color.FromArgb(255, 40, 47, 99);
        public static ColorScheme MATERIAL_DEFAULT_COLOR    = new ColorScheme(Primary.Red900, Primary.Red800, Primary.Red500, Accent.Red400, TextShade.WHITE);
    }
}
