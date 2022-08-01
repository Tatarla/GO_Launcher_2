using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace GOR_Launcher
{
    public static class CFileValidation
    {
        static XmlDocument          mainFileXml;
        static List<CDownloadFile>  downloadList;

        public static bool Initialize()
        {
            downloadList    = new List<CDownloadFile>();

            mainFileXml     = new XmlDocument();
            mainFileXml.Load(Constants.FILE_LIST_URL);

            XmlNode fileListNode = mainFileXml.SelectSingleNode("file_list");
            if (fileListNode == null)
                return false;

            XmlNodeList fileList = fileListNode.SelectNodes("file");
            foreach (XmlNode fileNode in fileList)
            {
                string fileMd5      = fileNode.SelectSingleNode("md5").InnerText;
                string fileName     = fileNode.SelectSingleNode("fileName").InnerText;
                string fileUrl      = fileNode.SelectSingleNode("fileUrl").InnerText;
                string filePath     = fileNode.SelectSingleNode("filePath").InnerText;

                if (!fileUrl.Contains("http://") || fileUrl.Contains("https://"))
                    fileUrl = Constants.FILE_DOWNLOAD_URL + fileUrl;

                downloadList.Add(new CDownloadFile(fileMd5, filePath, fileName, fileUrl));
            }

            return true;
        }
    }
}
