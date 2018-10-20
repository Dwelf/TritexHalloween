using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TritexHalloween.Networking
{
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Threading;

    using TritexHalloween.Networking;

    public class Server
    {
        private readonly IPAddress localEndPoint;


        private readonly Action<Message> recieviedMessage;

        public Server(IPAddress ipAddress, Action<Message> recieviedMessage)
        {
            this.recieviedMessage = recieviedMessage;
            this.localEndPoint = ipAddress;
        }

        public bool StopServer { get; set; }

        public void Start()
        {

            try
            {
                /* Initializes the Listener */
                TcpListener myList = new TcpListener(this.localEndPoint, 8001);

                /* Start Listening at the specified port */
                myList.Start();

                // Accepts the connections
                TcpClient client;
                while (this.StopServer == false)
                {
                    client = myList.AcceptTcpClient();
                    this.HandleRequest(client);
                    client.Close();
                    Thread.Sleep(200);
                }

                myList.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }

            Console.ReadLine();
        }

        private void HandleRequest(TcpClient client)
        {
            var binaryFormatter = new BinaryFormatter();
            var stream = client.GetStream();
            var message = (Message)binaryFormatter.Deserialize(stream);
            this.recieviedMessage.Invoke(message);
            stream.Close();
        }
    }
}