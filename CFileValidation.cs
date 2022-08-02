using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;

namespace GOR_Launcher
{
    public static class CFileValidation
    {
        static XmlDocument              mainFileXml;
        static List<CDownloadFile>      downloadList;
        static List<CDownloadFile>      deleteFiles;
        static WebClient                dlClient;

        static MainForm                 mainForm;

        public static async Task Initialize(MainForm form)
        {
            downloadList    = new List<CDownloadFile>();
            deleteFiles     = new List<CDownloadFile>();

            mainForm        = form;

            if (!IsVersionPresent())
                await StartFileValidation();
            else
                IsReady();

            await Task.Delay(1);
        }

        public static bool IsReady()
        {
            if (downloadList.Count == 0)
            {
                mainForm.SetPlayButton(true);
                mainForm.SetProgressBar(100);
                mainForm.SetProgressLabel(CLocalization.Get("fileDone"));
                return true;
            }

            return false;
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
                string fileMd5  = fileNode.SelectSingleNode("md5").InnerText;
                string fileName = fileNode.SelectSingleNode("fileName").InnerText;
                string fileUrl  = fileNode.SelectSingleNode("fileUrl").InnerText;
                string filePath = fileNode.SelectSingleNode("filePath").InnerText;

                // Checking if is file located on the remote host
                if (!fileUrl.Contains("http://") && !fileUrl.Contains("https://"))
                    fileUrl = Constants.FILE_DOWNLOAD_URL + fileUrl;

                returnList.Add(new CDownloadFile(fileMd5, filePath, fileName, fileUrl));
            }

            // Adding XML file and version XML every time (only for remote)
            Uri uriXml = new Uri(path);
            if (path.Contains("http://") || path.Contains("https://"))
            {
                returnList.Add(new CDownloadFile("none", Constants.CONFIG_FOLDER_PATH, Path.GetFileName(uriXml.LocalPath), path));
                returnList.Add(new CDownloadFile("none", Constants.CONFIG_FOLDER_PATH, Constants.VERSION_FILE_NAME, Constants.VERSION_FILE_URL));
            }

            return returnList;
        }

        // Async download start and events
        public static void StartDownlaod()
        {
            dlClient                           = new WebClient();
            dlClient.DownloadProgressChanged  += new DownloadProgressChangedEventHandler(DlProgressChanged);
            dlClient.DownloadFileCompleted    += new AsyncCompletedEventHandler(DlFileCompleted);

            DlNext();
        }

        public static void DlProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn      = double.Parse(e.BytesReceived.ToString());
            double totalBytes   = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage   = bytesIn / totalBytes * 100;
            mainForm.SetProgressBar(int.Parse(Math.Truncate(percentage).ToString()));

            double mbytesIn     = Math.Round((bytesIn / 1024) / 1024, 1);
            double mbtotalBytes = Math.Round((totalBytes / 1024) / 1024, 1);
            mainForm.SetProgressLabel(string.Format("{0} {1}... {2} Mb / {3} Mb", CLocalization.Get("downloading"), downloadList[0].getName(), mbytesIn.ToString(), mbtotalBytes.ToString()));
        }

        public static void DlFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            downloadList.RemoveAt(0);
            DlNext();
        }

        public static void DlNext()
        {
            if (downloadList.Count == 0)
            {
                DlCompleted();
                return;
            }

            Directory.CreateDirectory(downloadList[0].getPath());
            dlClient.DownloadFileAsync(new Uri(downloadList[0].getFullUrl()), downloadList[0].getFullName());
        }

        public static void DlCompleted()
        {
            // Saving meta data
            
            IsReady();
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
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
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

        public static async Task StartFileValidation()
        {
            mainForm.SetPlayButton(false);

            await ValidateFiles();

            if (!IsReady())
                StartDownlaod();
        }

        private static async Task ValidateFiles()
        {
            // Cleanup
            deleteFiles.Clear();
            downloadList.Clear();

            // Creating local file list
            
            List<CDownloadFile> localFileList = new List<CDownloadFile>();

            if (File.Exists(Path.GetFullPath(Constants.CONFIG_FOLDER_PATH + "files.xml")))
                localFileList = ParseXmlFile(Path.GetFullPath(Constants.CONFIG_FOLDER_PATH + "files.xml"));

            // Creating remote file list
            List<CDownloadFile> remoteFileList = ParseXmlFile(Constants.FILE_LIST_URL);

            // Validating remote files
            double percentage = Math.Round(remoteFileList.Count / 100.0, 1);

            for (int i = 0; i < remoteFileList.Count; i++)
            {
                if (remoteFileList[i].getFullName().Contains(".launcher"))
                    continue;

                mainForm.SetProgressBar(Convert.ToInt16(percentage * i));
                mainForm.SetProgressLabel(CLocalization.Get("fileValidating") + " " + remoteFileList[i].getName());

                if (!File.Exists(remoteFileList[i].getFullName()))
                {
                    downloadList.Add(remoteFileList[i]);
                    continue;
                }

                FileAttributes atr = File.GetAttributes(remoteFileList[i].getFullName());
                if (!atr.HasFlag(FileAttributes.Directory))
                {
                    var fileMd5 = GetFileMD5(remoteFileList[i].getFullName());
                    if (fileMd5 != remoteFileList[i].getMD5().ToLower())
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

            await Task.Delay(1);
        }
    }
}
