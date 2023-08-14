using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _021_Socket_TCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. create a socket
            Socket tcpServer = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);

            //2. bind IP and port number
            //IP > address(computer), port number >>receiver(like Skype, Messenger...etc)
            //ip: 192.168.1.78
            IPAddress iPAddress = new IPAddress(new byte[] { 192,168,1,78});
            EndPoint ep = new IPEndPoint(iPAddress,1985); //ipendpoint is a package of ip address and port number
            tcpServer.Bind(ep); //Apply ip address and port number from the system to communicate
            Console.WriteLine("Server starts binding!"); 

            //3. start listening (wait for client connection)
            tcpServer.Listen(100); //ref here is the max connection number (100 connections here)

            //4. have the socket to communicate with client
            Socket avecClientSocket =  tcpServer.Accept();//Pause the current thread until a client connect, then continue the code below
                                                          //Use the returned socket to communicate with client
            Console.WriteLine("A connection from client is in!"); 

            //5. send the message
            string message = "Hi! I am Li!!";
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            avecClientSocket.Send(messageBytes);//ref has to be in byte[]
            Console.WriteLine("The greeting message's been sent: "+ message);

            //------------------
            byte[] messageFromClientBytes = new byte[1024];
            int lengthOfMessageFromClient= avecClientSocket.Receive(messageFromClientBytes);
            string messageFromClientString = Encoding.UTF8.GetString(messageFromClientBytes,0,lengthOfMessageFromClient);
            Console.WriteLine(messageFromClientString);
            Console.ReadKey();
        }
    }
}
