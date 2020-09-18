using System;
using System.Net.Sockets;
using System.Text;

namespace Ex7_Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Start();
        }
    }
}