using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ClientConnection
    {
        TcpClient clientSocket;
        // String clientName; //not used

        /**
        * constructor for new client connection handling
        * */
        public ClientConnection(TcpClient tcpClient)
        {
            this.clientSocket = tcpClient;
            //this. clientName = name; //not used
            Thread clientThread = new Thread(clientConnectionMain);
            clientThread.Start();

        }

        /**
         * This is where the server handles each client connection
         * */
        private void clientConnectionMain()
        {
            Console.WriteLine("New Client connection thread started"); //testing
            Thread.Sleep(1500);
            Console.WriteLine("Done sleeping, nothing more to do now");

        }


    }
}
