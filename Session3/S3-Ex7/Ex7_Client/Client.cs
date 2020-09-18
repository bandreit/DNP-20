using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using TransferObjec;

namespace Ex7_Client
{
    public class Client
    {
        public void Start()
        {
            Console.WriteLine("Starting Client ....");

            TcpClient client = new TcpClient("127.0.0.1", 8080);
            NetworkStream stream = client.GetStream();
            ClientReceiver clientReceiver = new ClientReceiver(stream, this);

            Thread thread = new Thread(clientReceiver.Run);
            thread.Start();

            while (true)
            {
                string input = Console.ReadLine();
                Message message = new Message(input);
                string jsonFormatted = JsonSerializer.Serialize(message, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                clientReceiver.SendMessage(jsonFormatted);

                if (input.ToLower() == "exit")
                {
                    break;
                }
            }
            
            // stream.Close();
            // client.Close();
        }

        public void WriteOutputMessage(string response)
        {
            Message message = JsonSerializer.Deserialize<Message>(response);
            Console.WriteLine("Received: " + message);
        }
    }
}