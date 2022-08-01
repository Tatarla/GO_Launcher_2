using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOR_Launcher
{
    internal class CDownloadFile
    {
        string md5;
        string filePath;
        string fileName;
        string fileUrl;
        int    fileType;

        public CDownloadFile(string md5, string filePath, string fileName, string fileUrl, int fileType)
        {
            this.md5 = md5;
            this.filePath = filePath;
            this.fileName = fileName;
            this.fileUrl = fileUrl;
            this.fileType = fileType;
        }

        public string getFullName()     { return filePath + fileName; }
        public string getFullUrl()      { return fileUrl; }
        public string getPath()         { return filePath; }
    }
}
