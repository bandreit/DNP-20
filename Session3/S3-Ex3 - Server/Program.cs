using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace S3_Ex3
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

                while (true)
                {
                    // read
                    byte[] dataFromClient = new byte[1024];
                    int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                    string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
                    Console.WriteLine(s);
                    
                    // respond
                    byte[] dataToClient = Encoding.ASCII.GetBytes($"Returning {s}");
                    stream.Write(dataToClient, 0, dataToClient.Length);
                    
                    if (s == "exit")
                    {
                        break;
                    }
                }
               
                // close connection
                client.Close();
            }
        }
    }
}