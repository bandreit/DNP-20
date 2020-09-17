using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Ex4_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Ex4_Server...");
            
            IPAddress ip = IPAddress.Parse("10.152.196.34");
            TcpListener listener = new TcpListener(ip, 8080);
            listener.Start();

            Console.Out.WriteLine("Ex4_Server started...");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.Out.WriteLine("Ex4_Client connected");
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