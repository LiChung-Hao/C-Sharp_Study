using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _025_Socket_UdpClient // -p63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. create socket, bind ip and port
            UdpClient udpClient = new UdpClient(new IPEndPoint(IPAddress.Parse("192.168.1.78"), 7788));

            //2. receive data
            IPEndPoint point = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                byte[] data = udpClient.Receive(ref point); //know who (ip & port) through point, return byte[], the data we wanna receive
                string message = Encoding.UTF8.GetString(data);

                Console.WriteLine("Received message: " + message);
            }

            udpClient.Close();
            Console.ReadKey();
        }
    }
}
