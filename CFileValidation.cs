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
using System.Security.Cryptography;

namespace GOR_Launcher
{
    public static class CFileValidation
    {
        static XmlDocument              mainFileXml;
        static List<CDownloadFile>      downloadList;
        static List<CDownloadFile>      deleteFiles;
        static int                      dlPointer;
        static WebClient                dlClient;

        static MaterialProgressBar      dlBarRef;
        static Label                    dlLabelRef;

        public static bool Initialize(MaterialProgressBar barRef, Label labelRef)
        {
            downloadList    = new List<CDownloadFile>();
            deleteFiles     = new List<CDownloadFile>();
            dlBarRef        = barRef;
            dlLabelRef      = labelRef;

            if (!IsVersionPresent())
                ValidateFiles();

            return true;
        }

        public static List<CDownloadFile> ParseXmlFile(string path)
        {
            List<CDownloadFile> returnList = new List<CDownloadFile>();

            mainFileXml = new XmlDocument();
            mainFileXml.Load(path);

            XmlNode fileListNode = mainFileXml.SelectSingleNode("file_list");
            if (fileListNode == null)
                return null;

            XmlNodeList fileList = fileListNode.SelectNodes("file");
            foreach (XmlNode fileNode in fileList)
            {
                string fileMd5 = fileNode.SelectSingleNode("md5").InnerText;
                string fileName = fileNode.SelectSingleNode("fileName").InnerText;
                string fileUrl = fileNode.SelectSingleNode("fileUrl").InnerText;
                string filePath = fileNode.SelectSingleNode("filePath").InnerText;
                int fileType = 0;

                // Checking if it is file or folder (fileType = 0 - file, = 1 - folder)
                XmlNode fileTypeNode = fileNode.SelectSingleNode("fileType");
                if (fileTypeNode != null)
                    fileType = Convert.ToInt16(fileTypeNode.InnerText);

                // Checking if is file located on the remote host
                if (!fileUrl.Contains("http://") && !fileUrl.Contains("https://"))
                    fileUrl = Constants.FILE_DOWNLOAD_URL + fileUrl;

                returnList.Add(new CDownloadFile(fileMd5, filePath, fileName, fileUrl, fileType));
            }

            return returnList;
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

        // *** *** //
        // File Validation

        public static bool ContainsFile(List<CDownloadFile> list, string filename)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i].getName() == filename)
                    return true;

            return false;
        }

        public static string GetFileMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    byte[] md5_hash = md5.ComputeHash(stream);
                    string md5_string = BitConverter.ToString(md5_hash).Replace("-", "").ToLowerInvariant();
                    return md5.ComputeHash(stream).ToString();
                }
            }
        }

        public static bool IsVersionPresent()
        {
            // Creating hidden directory for storing any config information
            // This method should be called very first once launcher is started up, so any other methods will be able to use the folder for sure
            if (!Directory.Exists(Constants.CONFIG_FOLDER_PATH))
            {
                DirectoryInfo dir = Directory.CreateDirectory(Constants.CONFIG_FOLDER_PATH);
                dir.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }

            if (!File.Exists(Constants.CONFIG_FOLDER_PATH + Constants.VERSION_FILE_NAME))
                return false;

            // Getting local version
            XmlDocument verXml = new XmlDocument();
            verXml.Load(Constants.CONFIG_FOLDER_PATH + Constants.VERSION_FILE_NAME);
            string localVersion = verXml.SelectSingleNode("info").SelectSingleNode("version").InnerText;

            // Getting remote version
            verXml = new XmlDocument();
            verXml.Load(Constants.VERSION_FILE_URL);
            string remoteVersion = verXml.SelectSingleNode("info").SelectSingleNode("version").InnerText;

            return localVersion == remoteVersion;
        }

        public static void ValidateFiles()
        {
            // Cleanup
            deleteFiles.Clear();
            downloadList.Clear();

            // Creating local file list
            List<CDownloadFile> localFileList = null;

            if (File.Exists(Constants.CONFIG_FOLDER_PATH + "files.xml"))
                localFileList = ParseXmlFile(Constants.CONFIG_FOLDER_PATH + "files.xml");

            // Creating remote file list
            List<CDownloadFile> remoteFileList = ParseXmlFile(Constants.FILE_LIST_URL);

            // Validating remote files
            for (int i = 0; i < remoteFileList.Count; i++)
            {
                if (!File.Exists(remoteFileList[i].getFullName()))
                {
                    downloadList.Add(remoteFileList[i]);
                    continue;
                }

                FileAttributes atr = File.GetAttributes(remoteFileList[i].getFullName());
                if (!atr.HasFlag(FileAttributes.Directory))
                {
                    if (GetFileMD5(remoteFileList[i].getFullName()) != remoteFileList[i].getMD5().ToLower())
                        downloadList.Add(remoteFileList[i]);
                }
            }

            // Forming deletion list
            if (localFileList != null)
            {
                for (int i = 0; i < localFileList.Count; i++)
                {
                    if (!ContainsFile(remoteFileList, localFileList[i].getName()))
                        deleteFiles.Add(localFileList[i]);
                }
            }

            int test = downloadList.Count;
        }
    }
}
