using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _001_Socket_TCP_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. create socket
            Socket tcpClient=new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //2. request connection, no need to listen
            IPAddress ipAdress = IPAddress.Parse("192.168.1.78");
            //same as IPAddress iPAddress = new IPAddress(new byte[] { 192,168,1,78});
            EndPoint ep = new IPEndPoint(ipAdress,1985); //has to be the same as the one server bind to
            tcpClient.Connect(ep);

            //3. receive data
            byte[] data = new byte[1024]; //make a big data (1024)
            int length = tcpClient.Receive(data); //pass a byte[], the data[] here actually used to receive data
            //length here means how long(how many bytes) the data is received
            string messageReceived = Encoding.UTF8.GetString(data, 0, length); //only transfer the data received
            Console.WriteLine("Message from server received: "+messageReceived);

            //--------------------
            string messageFromClient= Console.ReadLine();
            tcpClient.Send(Encoding.UTF8.GetBytes(messageFromClient));
            Console.WriteLine("messageFromClient's been sent!"+ messageFromClient);

            Console.ReadKey();

        }
    }
}
