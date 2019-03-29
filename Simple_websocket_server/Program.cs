using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace WebSocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80));

            server.OnClientConnected += (object sender, OnClientConnectedHandler e) =>
            {
                string clientGuid = e.GetClient().GetGuid();
                Console.WriteLine("Client with guid {0} connected!", clientGuid);
            };

            server.OnMessageReceived += MessageReceivedCallback;
            Console.ReadKey();
        }

        static void MessageReceivedCallback(object sender,OnMessageReceivedHandler e)
        {
            string message = e.GetMessage();
            string guid = e.GetClient().GetGuid();
            Console.WriteLine("Message received: {0} - Sender Guid: {1}", message, guid);
        }

       static void 
       
    }
}
