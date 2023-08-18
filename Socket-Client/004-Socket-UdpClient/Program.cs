using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _004_Socket_UdpClient // -p63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. create a socket
            UdpClient udpClient = new UdpClient();

            while (true)
            {
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.Send(data, data.Length, new IPEndPoint(IPAddress.Parse("192.168.1.78"), 7788));
            }

            udpClient.Close();
            Console.ReadKey();
        }
    }
}
