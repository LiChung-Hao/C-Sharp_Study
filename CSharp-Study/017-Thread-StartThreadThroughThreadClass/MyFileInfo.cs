using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _017_Thread_StartThreadThroughThreadClass
{
    internal class MyFileInfo
    {
        private string _fileName;
        private string _filePath;

        public void InfoFile(string fileName, string filePath)
        { 
            _fileName=fileName;
            _filePath=filePath;
        }

        public void DonwloadFile()
        {
            Console.WriteLine(_fileName+" starts downloading from "+_filePath);
            Thread.Sleep(3000);
            Console.WriteLine("Download completed!");
        }
    }
}
