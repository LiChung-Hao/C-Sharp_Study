using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _003_Socket_TCPClient // -p62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //once client initiated, it builds the connection with host
            TcpClient client = new TcpClient("192.168.1.78",7788);

            NetworkStream stream = client.GetStream(); //communicate through stream

            while (true)
            {
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }


            stream.Close();
            client.Close();
            Console.ReadKey();
        }
    }
}
