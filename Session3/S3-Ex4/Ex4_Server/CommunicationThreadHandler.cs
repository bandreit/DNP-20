using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Ex4_Server
{
    public class CommunicationThreadHandler
    {
        private NetworkStream Stream;

        public CommunicationThreadHandler(NetworkStream stream)
        {
            Stream = stream;
            Thread t = new Thread(Run);
            t.Start();
        }

        public void Run()
        {
            while (true)
            {
                // read
                byte[] dataFromClient = new byte[1024];
                int bytesRead = Stream.Read(dataFromClient, 0, dataFromClient.Length);
                string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
                Console.WriteLine(s);

                // respond
                byte[] dataToClient = Encoding.ASCII.GetBytes($"Returning {s}");
                Stream.Write(dataToClient, 0, dataToClient.Length);

                if (s == "exit")
                {
                    break;
                }
            }
        }
    }
}