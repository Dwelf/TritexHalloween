using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TritexHalloween.Server
{
    public class Server
    {
        private readonly IPAddress localEndPoint;

        public Server(IPAddress ipAddress)
        {
            this.localEndPoint = ipAddress;
        }

        public void Start()
        {
            try
            {

                /* Initializes the Listener */
                TcpListener myList = new TcpListener(this.localEndPoint, 8001);

                /* Start Listening at the specified port */
                myList.Start();

                Console.WriteLine("The server is running at port 8001...");
                Console.WriteLine("The local End point is  :" + myList.LocalEndpoint);
                Console.WriteLine("Waiting for a connection.....");

                // Accepts the connections
                Socket s = myList.AcceptSocket();
                Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);

                // get the data
                byte[] b = new byte[100];
                int k = s.Receive(b);
                Console.WriteLine("Received...");
                for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(b[i]));

                // Send the Replay
                ASCIIEncoding asen = new ASCIIEncoding();
                s.Send(asen.GetBytes("The string was received by the server."));
                Console.WriteLine("\nSent Acknowledgement");
                /* clean up */
                s.Close();
                myList.Stop();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }

            Console.ReadLine();
        }
    }

    }
}
