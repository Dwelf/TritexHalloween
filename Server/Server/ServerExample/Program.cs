using System;
using System.Net;
using System.Net.Sockets;
namespace ServerExample
{
    using System.IO;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;

    using TritexHalloween.Networking;
    using TritexHalloween.StoryObjects;

    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var ip = IPAddress.Parse("127.0.0.1");



                var server = new Server(ip, gotMessage);
                server.Start();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }
            Console.ReadLine();
        }

        private static void gotMessage(Message message)
        {
            if (message.ObjectType == 0)
            {
                IFormatter formatter;
                using (var stream = new MemoryStream(message.Data))
                {
                    formatter = new BinaryFormatter();
                    var advenure = (Adventurer)formatter.Deserialize(stream);
                    Console.WriteLine(advenure.Name);
                    Console.WriteLine(advenure.Status);
                }
            }
        }
    }
}