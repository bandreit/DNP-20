using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Ex5_Server
{
    public class Server
    {
        public void Start()
        {
            Console.WriteLine("Starting Server...");
            
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 8080);
            listener.Start();
            ConnectionPool connectionPool = new ConnectionPool();

            Console.Out.WriteLine("Server started...");
    
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                Console.Out.WriteLine("Client connected");
                CommunicationThreadHandler communicationThreadHandler = new CommunicationThreadHandler(stream, connectionPool);
                connectionPool.AddHandler(communicationThreadHandler);
                Thread thread = new Thread(communicationThreadHandler.Run);
                thread.Start();
            }
        }
    }
}