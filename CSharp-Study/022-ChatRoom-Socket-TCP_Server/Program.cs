using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _022_ChatRoom_Socket_TCP_Server
{
    internal class Program
    {
        static List <Client> clientList= new List<Client> ();
        public static void BroadCast(string message)
        {
           List<Client> notConnectedList = new List<Client> ();
            foreach (Client client in clientList)
            {
                if (client.Connected)
                {
                    client.SendMessage(message);
                }
                else
                {
                    notConnectedList.Add(client);
                }
            }
            foreach (Client clientTemp in notConnectedList)
            { 
                clientList.Remove(clientTemp);
            }
        }
        static void Main(string[] args)
        {
            Socket tcpServer=new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpServer.Bind(new IPEndPoint(IPAddress.Parse("192.168.1.78"), 9541));
            tcpServer.Listen(100);
            Console.WriteLine("Server is running. Waiting for connection...");
            int connectClientNum = 0;
            while (true) //keep accepting new client to connect
            {
                Socket clientSocket = tcpServer.Accept();
                connectClientNum++;
                Console.WriteLine(connectClientNum+" clients have been connected!");
                Client client = new Client(clientSocket);
                clientList.Add(client);
            }
        }
    }
}
