using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using TransferObjec;

namespace Ex7_Client
{
    public class ClientReceiver
    {
        private Stream _stream;
        private Client _client;

        public ClientReceiver(NetworkStream stream, Client client)
        {
            _stream = stream;
            _client = client;
        }

        public void Run()
        {
            while (true)
            {
                byte[] dataFromServer = new byte[1024];
                int bytesRead = _stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);

                _client.WriteOutputMessage(response);
            }
        }

        public void SendMessage(string message)
        {
            byte[] dataToServer = Encoding.ASCII.GetBytes(message);
            _stream.Write(dataToServer, 0, dataToServer.Length);
        }
    }
}