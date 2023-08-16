using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _023_Socket_UDP_Server //compare to tcp, udp doesn't have the process of building connection -p58
{ //udp vs tcp -p60
    internal class Program
    {
        static Socket udpServer;
        static void Main(string[] args)
        {
            //1. create a scoket
            udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //2. bind ip and port
            udpServer.Bind(new IPEndPoint(IPAddress.Parse("192.168.1.78"), 7788));
            Console.WriteLine("Server is ready!");

            //3. receive data
            new Thread(ReceiveMessage) { IsBackground=true}.Start();

            //udpServer.Close();
            Console.ReadKey();
        }

        static void ReceiveMessage()
        {
            while (true)
            {
                byte[] data = new byte[1024];
                EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0); //No given value (any, 0 (port))
                int length = udpServer.ReceiveFrom(data, ref remoteEndPoint); //this method will put remote side's ipaddress and port num in the second ref
                                                                              //ref here means the method ReceiveFrom can change remoteEndPoint

                //get the message
                string message = Encoding.UTF8.GetString(data, 0, length);
                Console.WriteLine("Received message: " + message + " from IP: " + (remoteEndPoint as IPEndPoint).Address.ToString() + " : "
                    + (remoteEndPoint as IPEndPoint).Port.ToString());
            }

        }
    }
}
