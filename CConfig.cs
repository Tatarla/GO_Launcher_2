using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;

namespace GOR_Launcher
{
    public static class CConfig
    {
        private static string   serverAddress;
        private static int      connectionAvailable;
        private static int      onlinePlayers;

        public static void Initialize()
        {
            // Parsing remote XML
            XmlDocument configXml = new XmlDocument();
            configXml.Load(Constants.REMOTE_CONFIG_URL);

            XmlNode rootNode    = configXml.SelectSingleNode("root");
            serverAddress       = rootNode.SelectSingleNode("address").InnerText;
            connectionAvailable = Convert.ToInt16(rootNode.SelectSingleNode("available").InnerText);

            // Parsing player counter
            using (var wc = new WebClient())
            {
                try
                {
                    var amogus = string.Format(Constants.G2O_API_URL, serverAddress);
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

        public static string    GetServerAddress()          { return serverAddress; }
        public static bool      IsConnectionAvailable()     { return connectionAvailable == 1; }
        public static int       GetOnlinePlayers()          { return connectionAvailable == 1 ? onlinePlayers : 0; }
    }
}
