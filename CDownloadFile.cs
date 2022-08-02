using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOR_Launcher
{
    public class CDownloadFile
    {
        string md5;
        string filePath;
        string fileName;
        string fileUrl;

        public CDownloadFile(string md5, string filePath, string fileName, string fileUrl)
        {
            this.md5 = md5;
            this.filePath = filePath;
            this.fileName = fileName;
            this.fileUrl = fileUrl;
        }

        public string getFullName()     { return filePath + fileName; }
        public string getFullUrl()      { return fileUrl; }
        public string getPath()         { return filePath; }
        public string getName()         { return fileName; }
        public string getMD5()          { return md5; }
    }
}
