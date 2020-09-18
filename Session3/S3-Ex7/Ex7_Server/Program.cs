using System;
using System.Net;
using System.Net.Sockets;

namespace Ex7_Server
{
    class Program
    {
        static void Main(string[] args)
        {
           Server server = new Server();
           server.Start();
        }
    }
}