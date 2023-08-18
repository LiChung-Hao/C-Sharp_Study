using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _024_Socket_TCPListener // -p61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. TcpListener makes a package of socket. This class will create socket
            TcpListener listener = new TcpListener(IPAddress.Parse("192.168.1.78"), 7788); //who you are listening to
            
            //2. Start listening
            listener.Start();

            //3. Wait for client to connect
            TcpClient client = listener.AcceptTcpClient();

            //4. Get the data from client
            NetworkStream stream = client.GetStream(); //get stream from client. we can get data through the stream
            
            byte[] data = new byte[1024]; //a container to store the data
            //0 means starting from 0 index in data[] to store the data
            //1024 means read max to index 1024 in data[], if only 500, then read 500
            while (true)
            {
                int length = stream.Read(data, 0, 1024);

                string message = Encoding.UTF8.GetString(data, 0, length);
                Console.WriteLine("Received message: " + message);
            }


            stream.Close();
            client.Close();
            listener.Stop();

            Console.ReadKey();
        }
    }
}
