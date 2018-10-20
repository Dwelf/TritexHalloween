namespace TritexHalloween.Networking
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;

    public class Client
    {
        private readonly IPAddress serverIpAddress;
        public Client(IPAddress ipAddress)
        {
            this.serverIpAddress = ipAddress;
        }

        public void Send<T>(int identifier, T item) where T : class, new()
        {
            byte[] data;
            IFormatter formatter;
            using (var stream = new MemoryStream())
            {
                formatter = new BinaryFormatter();
                formatter.Serialize(stream, item);
                stream.Flush();
                stream.Position = 0;
                data = stream.ToArray();
            }

            var message = new Message(identifier, data);
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(this.serverIpAddress, 8001);
            formatter = new BinaryFormatter(); // the formatter that will serialize my object on my stream 
            NetworkStream strm = tcpClient.GetStream();
            formatter.Serialize(strm, message);
            strm.Close();
            tcpClient.Close();
        }
    }
}
