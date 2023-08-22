using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_FileInfo_CheckFileAndFolderInfo // -p64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////relative path: where the file currently at (compiled and run) 
            //FileInfo fileInfo = new FileInfo("TextFile1.txt");
            ////absolute path
            ////FileInfo fileInfo = new FileInfo(@"D:\C-Sharp\yt-mandarin\CSharp-Study\026-FileInfo-CheckFileAndFolderInfo\\TextFile1.txt");
            //Console.WriteLine(fileInfo.Exists);
            //Console.WriteLine(fileInfo.Name);
            //Console.WriteLine(fileInfo.Directory);
            //Console.WriteLine(fileInfo.IsReadOnly);
            //Console.WriteLine(fileInfo.Exists);

            //fileInfo.CopyTo("another.txt");
            //fileInfo.Delete(); // delet the one copied to debug file (where FileInfo(location))

            //FileInfo fileInfo = new FileInfo("notCreatedYet.txt");
            ////if (fileInfo.Exists == false)
            ////{ 
            ////    fileInfo.Create(); //create the current file notCreatedYet.txt
            ////}

            //fileInfo.MoveTo("nameChanged.txt"); //rename the file

            ////Folder - absolute path
            //DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\C-Sharp\yt-mandarin\CSharp-Study\026-FileInfo-CheckFileAndFolderInfo\bin\Debug");
            //Console.WriteLine(directoryInfo.Exists);
            //Console.WriteLine(directoryInfo.Parent);
            //Console.WriteLine(directoryInfo.Root);
            //Console.WriteLine(directoryInfo.CreationTime);
            //directoryInfo.CreateSubdirectory("liSecond");

            //Folder relative path
            DirectoryInfo directoryInfo = new DirectoryInfo("LiTest3");
            if (directoryInfo.Exists == false)
            { 
                directoryInfo.Create();
            }
        }
    }
}
