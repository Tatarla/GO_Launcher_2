using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using MaterialSkin.Controls;

namespace GOR_Launcher
{
    public static class CFileValidation
    {
        static XmlDocument              mainFileXml;
        static List<CDownloadFile>      downloadList;
        static int                      dlPointer;
        static WebClient                dlClient;

        static MaterialProgressBar      dlBarRef;
        static Label                    dlLabelRef;

        public static bool Initialize(MaterialProgressBar barRef, Label labelRef)
        {
            downloadList    = new List<CDownloadFile>();
            dlBarRef        = barRef;
            dlLabelRef      = labelRef;

            mainFileXml     = new XmlDocument();
            mainFileXml.Load(Constants.FILE_LIST_URL);

            XmlNode fileListNode = mainFileXml.SelectSingleNode("file_list");
            if (fileListNode == null)
                return false;

            XmlNodeList fileList = fileListNode.SelectNodes("file");
            foreach (XmlNode fileNode in fileList)
            {
                string fileMd5          = fileNode.SelectSingleNode("md5").InnerText;
                string fileName         = fileNode.SelectSingleNode("fileName").InnerText;
                string fileUrl          = fileNode.SelectSingleNode("fileUrl").InnerText;
                string filePath         = fileNode.SelectSingleNode("filePath").InnerText;
                int fileType            = 0;

                // Checking if it is file or folder (fileType = 0 - file, = 1 - folder)
                XmlNode fileTypeNode    = fileNode.SelectSingleNode("fileType");
                if (fileTypeNode != null)
                    fileType = Convert.ToInt16(fileTypeNode.InnerText);

                // Checking if is file located on the remote host
                if (!fileUrl.Contains("http://") && !fileUrl.Contains("https://"))
                    fileUrl = Constants.FILE_DOWNLOAD_URL + fileUrl;

                downloadList.Add(new CDownloadFile(fileMd5, filePath, fileName, fileUrl, fileType));
            }

            StartDownlaod();

            return true;
        }

        // Async download start and events
        public static void StartDownlaod()
        {
            dlClient                           = new WebClient();
            dlClient.DownloadProgressChanged  += new DownloadProgressChangedEventHandler(DlProgressChanged);
            dlClient.DownloadFileCompleted    += new AsyncCompletedEventHandler(DlFileCompleted);

            dlPointer                          = -1;
            DlNext();
        }

        public static void DlProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn      = double.Parse(e.BytesReceived.ToString());
            double totalBytes   = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage   = bytesIn / totalBytes * 100;
            dlBarRef.Value      = int.Parse(Math.Truncate(percentage).ToString());

            double mbytesIn     = Math.Round((bytesIn / 1024) / 1024, 1);
            double mbtotalBytes = Math.Round((totalBytes / 1024) / 1024, 1);
            dlLabelRef.Text     = string.Format("{0} {1}... {2} Mb / {3} Mb", CLocalization.Get("downloading"), downloadList[dlPointer].getName(), mbytesIn.ToString(), mbtotalBytes.ToString());
        }

        public static void DlFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DlNext();
        }

        public static void DlNext()
        {
            dlPointer += 1;
            if (downloadList.Count == dlPointer)
            {
                DlCompleted();
                return;
            }

            Directory.CreateDirectory(downloadList[dlPointer].getPath());
            dlClient.DownloadFileAsync(new Uri(downloadList[dlPointer].getFullUrl()), downloadList[dlPointer].getFullName());
        }

        public static void DlCompleted()
        {

        }
    }
}
