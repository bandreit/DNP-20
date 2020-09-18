using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Ex5_Server
{
    public class CommunicationThreadHandler
    {
        private NetworkStream Stream;
        private ConnectionPool _connectionPool;

        public CommunicationThreadHandler(NetworkStream stream, ConnectionPool pool)
        {
            Stream = stream;
            _connectionPool = pool;
        }

        public void Run()
        {
            Console.Out.WriteLine("Thread Started...");
            while (true)
            {
                // read
                byte[] dataFromClient = new byte[1024];
                int bytesRead = Stream.Read(dataFromClient, 0, dataFromClient.Length);
                string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
                Console.WriteLine("Received " + s);

                if (s == "exit")
                {
                    _connectionPool.RemoveHandler(this);
                    break;
                }
                
                _connectionPool.BroadcastMessage(s);
            }
        }

        public void SendMessage(string message)
        {
            byte[] dataToClient = Encoding.ASCII.GetBytes(message);
            Stream.Write(dataToClient, 0, dataToClient.Length);
        }
    }
}