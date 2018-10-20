using System;
using System.Net.Sockets;
using TritexHalloween.Networking;

namespace ClientExample
{
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;

    using TritexHalloween.StoryObjects;

    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                var client = new Client(IPAddress.Parse("127.0.0.1"));

                var adventure = new Adventurer();
                adventure.Name = "Winning";
                adventure.Status = "Biwinning";

                client.Send(0, adventure);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }

            Console.ReadLine();
        }
    }
}