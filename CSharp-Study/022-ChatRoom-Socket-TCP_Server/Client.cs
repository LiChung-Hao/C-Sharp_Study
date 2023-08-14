using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _022_ChatRoom_Socket_TCP_Server
{
    internal class Client
    {
        private Socket socket;
        private Thread t;
        private byte[] data=new byte[1024];
        public Client(Socket s)
        { 
            socket = s;
            //Start a thread to handle the message received
            t = new Thread(ReceiveMessage);
            t.Start();
        }
        private void ReceiveMessage()
        {   //keep receiving message
            while (true)
            {
                if (socket.Poll(10,SelectMode.SelectRead)) //check if the socket still connected, or if diconnect, it will still keep taking null as message received
                {
                    socket.Close();
                    break;
                }
                int length = socket.Receive(data);
                string message=Encoding.UTF8.GetString(data, 0, length);
                //once receiving the data, prodcast the data to client side
                Program.BroadCast(message);
                Console.WriteLine("Receive the message: " + message);
            }
        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            socket.Send(data);
        }

        public bool Connected
        {
            get { return socket.Connected; }
        }
    }
}
