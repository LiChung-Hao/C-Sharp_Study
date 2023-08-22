using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_StreamReader_StreamWriter__ReadWriteFile //-p68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a streamreader reader
            StreamReader reader = new StreamReader("TextFile1.txt");

            //Read the file

            ////1.
            //while (true)
            //{
            //    string str = reader.ReadLine(); //read one line after call, call again, then next line
            //    if(str==null) break;
            //    Console.WriteLine(str);
            //}

            //2.
            //string str = reader.ReadToEnd(); //read all strings in the file
            //Console.WriteLine(str);

            ////3.
            //while (true)
            //{ 
            //    int res = reader.Read();
            //    if (res == -1)
            //    {
            //        break;
            //    }
            //    else 
            //    {
            //        Console.Write((char)res);
            //    }
            //}

            reader.Close();

            //Stream Writer
            StreamWriter writer = new StreamWriter("Text4Write.txt"); //if file not exist, create one, if exist, overwrite it
            
            while (true)
            { 
                string message = Console.ReadLine();
                if(message=="q") break;
                writer.WriteLine(message);
            }
            writer.Close();

        }
    }
}
