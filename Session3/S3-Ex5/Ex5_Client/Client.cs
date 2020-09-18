using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Ex5_Client
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
                Console.Out.Write("Input >> ");
                string input = Console.ReadLine();
                clientReceiver.SendMessage(input);

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
            Console.WriteLine("Received: " + response);
        }
    }
}