using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_FileStream_ToReadFile // -p67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1. create a filestream to operate on the textfile1.txt
            //FileStream fileStream = new FileStream("TextFile1.txt", FileMode.Open);
            ////filestream is not for txt

            ////2. read or write data
            //byte[] data = new byte[1024]; // a data container

            //while (true)
            //{
            //    int length = fileStream.Read(data, 0, data.Length); //loopingly read (each time 1024 bytes)
            //    if (length == 0) //til the end of the data
            //    {
            //        Console.WriteLine("Reading Over!");
            //        break;
            //    }
            //    for (int i = 0; i < data.Length; i++)
            //    {
            //        Console.Write(data[i] + " ");
            //    }
            //}

            //II. Copy the pic
            //the pic is 64.5kb*1024 = 66048 bytes
            FileStream readStream = new FileStream("num1-8.png", FileMode.Open);
            FileStream writeStream = new FileStream("num1-8-copys.png", FileMode.Create);

            byte[] data = new byte[1024];
            int round = 0;
            while (true)
            {
                int length = readStream.Read(data, 0, data.Length);
                if (length == 0)
                {
                    Console.WriteLine("**Reading Over! after " + round + " rounds!");
                    break;
                }
                else
                { 
                    writeStream.Write(data, 0, length);
                    round++;
                }
            }

            readStream.Close();
            writeStream.Close();
        }
    }
}
