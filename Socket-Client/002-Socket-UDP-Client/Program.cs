using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _002_Socket_UDP_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. create a socket
            Socket udpClient=new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            while (true)
            {
                //2. send the mssage
                Console.Write("Enter the message to send: ");
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                EndPoint serverPoint = new IPEndPoint(IPAddress.Parse("192.168.1.78"), 7788);
                udpClient.SendTo(data, serverPoint);
            }

            //udpClient.Close();
            //Console.ReadKey();
        }
    }
}
