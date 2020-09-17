using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Server...");
            
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 8080);
            listener.Start();

            Console.Out.WriteLine("Server started...");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.Out.WriteLine("Client connected");
                NetworkStream stream = client.GetStream();
                
                CommunicationThreadHandler communicationThreadHandler = new CommunicationThreadHandler(stream);
                
                //     if (s == "exit")
                //     {
                //         break;
                //     }
                
                // close connection
                // client.Close();
            }
        }
    }
}