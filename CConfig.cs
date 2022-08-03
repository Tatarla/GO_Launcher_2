using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using Microsoft.Win32;

namespace GOR_Launcher
{
    public static class CConfig
    {
        private static string   serverAddress;
        private static int      connectionAvailable;
        private static int      onlinePlayers;
        private static string   world;
        private static string   playerNickname;
        private static Version  ver;

        public static void Initialize()
        {
            // Parsing remote XML
            XmlDocument configXml = new XmlDocument();
            configXml.Load(Constants.REMOTE_CONFIG_URL);

            XmlNode rootNode    = configXml.SelectSingleNode("root");
            serverAddress       = rootNode.SelectSingleNode("address").InnerText;
            connectionAvailable = Convert.ToInt16(rootNode.SelectSingleNode("available").InnerText);
            world               = rootNode.SelectSingleNode("world").InnerText;
            string version      = rootNode.SelectSingleNode("version").InnerText;

            ver                 = new Version(version);

            // Parsing player counter
            using (var wc = new WebClient())
            {
                try
                {
                    var json = wc.DownloadString(string.Format(Constants.G2O_API_URL, serverAddress));
                    var json_decode = System.Web.Helpers.Json.Decode(json);

                    if (json_decode.online == false)
                        connectionAvailable = 0;
                    else
                        onlinePlayers = json_decode.info.players;
                }
                catch (WebException ex) when (ex.Response is HttpWebResponse wr && wr.StatusCode == HttpStatusCode.NotFound)
                {
                    connectionAvailable = 0;
                }
            }
        }

        public static void UpdateRegistry()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
            key = key.CreateSubKey("G2O", true);

            key.SetValue("ip_port",     serverAddress);
            key.SetValue("nickname",    playerNickname);
            key.SetValue("world",       world);
        }

        public static Version   GetVersion()                        { return ver; }
        public static void      UpdateNickname(string nickname)     { playerNickname = nickname; }
        public static string    GetServerAddress()                  { return serverAddress; }
        public static bool      IsConnectionAvailable()             { return connectionAvailable == 1; }
        public static int       GetOnlinePlayers()                  { return connectionAvailable == 1 ? onlinePlayers : 0; }
    }
}
