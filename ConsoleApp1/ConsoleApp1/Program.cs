using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Web;


namespace ConsoleApp1
{
    class Program
    {
        //test comment for gitting from home
        static void Main(string[] args)
        {

            //create server
            TcpListener server = new TcpListener(IPAddress.Any, 8000);
            TcpClient clientSocket;

            String fromClient;
            String serverSays;
            int i = 0;
            //start server
            Console.WriteLine(">> Starting Server.");
            server.Start();

            //start the server loop
            while (true)
            {
                Console.WriteLine(">> Waiting for a client to connect.");
                clientSocket = server.AcceptTcpClient(); // wait for a new client to connect
                ClientConnection newClient = new ClientConnection(clientSocket); //client connected
                Console.WriteLine(">> Server Finished creating new client handler");
            }



        }
    }
}

/**
 * This batch of commented code is from the interweb, so far did not really use much from it
 * /

//TcpListener server = new TcpListener(IPAddress.Any, 9999);
////TcpListener server = new TcpListener(8000);
//// we set our IP address as server's address, and we also set the port: 9999

//server.Start();  // this will start the server

//while (true)   //we wait for a connection
//{
//    TcpClient client = server.AcceptTcpClient();  //if a connection exists, the server will accept it

//    NetworkStream ns = client.GetStream(); //networkstream is used to send/receive messages

//    byte[] hello = new byte[100];   //any message must be serialized (converted to byte array)
//    hello = Encoding.Default.GetBytes("hello world");  //conversion string => byte array

//    ns.Write(hello, 0, hello.Length);     //sending the message

//    while (client.Connected)  //while the client is connected, we look for incoming messages
//    {
//        byte[] msg = new byte[1024];     //the messages arrive as byte array
//        ns.Read(msg, 0, msg.Length);   //the same networkstream reads the message sent by the client
//        Console.WriteLine(encoder.GetString(msg).Trim('')); //now , we write the message as string
//    }

//    String p = "test";

//    p = HttpUtility.UrlDecode(p, System.Text.Encoding.UTF8);


//  }



/**
* the following is my first working one on one, take turns passing messages back and forth
**/

////get streams
//StreamReader reader = new StreamReader(client.GetStream());
//StreamWriter writer = new StreamWriter(client.GetStream());

//writer.AutoFlush = true;
//writer.Flush();
////while (true)
//while((fromClient = reader.ReadLine()) != null)
//{

//    Console.WriteLine("Client: " + fromClient);
//    if(fromClient.Equals("Bye."))
//    {
//        Console.WriteLine("Reach true of fromClient is Bye.");
//        writer.WriteLine("Bye.");
//        writer.Flush();
//        break;
//    }

//    serverSays = "Hello I am server " + i;
//    writer.WriteLine(serverSays);
//    writer.Flush();
//    Console.WriteLine("Me: " + serverSays);

//    i++;
//}