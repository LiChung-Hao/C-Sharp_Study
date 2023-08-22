using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_File_UseFileToEditRead // -p66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] strs = File.ReadAllLines("TextFile1.txt"); //each line as a string
            //foreach (string s in strs)
            //{ 
            //    Console.WriteLine(s);
            //}

            //string s = File.ReadAllText("TextFile1.txt"); //all content in the file
            //Console.WriteLine(s);

            //byte[] pngByte = File.ReadAllBytes("num1-8.png");
            //foreach (var b in pngByte)
            //{ 
            //    Console.WriteLine(b);
            //}

            //File.WriteAllText("WAT.txt", "wat test, yay"); //create  wat.txt file then write "wat test yay" into it

            //File.WriteAllLines("WAL.txt", new string[] { "line1: jajaj", "line2: njbjsnd", "lineajsnd !", "@@@" });
            ////create wal.txt then put each element into each line in the file

            //byte[] data = File.ReadAllBytes("num1-8.png");
            //File.WriteAllBytes("copyPic.png", data); //create a new pic copyPic.png using the bytes read from num1-8.png
        }
    }
}
