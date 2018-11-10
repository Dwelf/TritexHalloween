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
            if (Console.ReadKey().Key == ConsoleKey.R)
            {
            }

            try
            {
                var client = new Client(IPAddress.Parse("127.0.0.1"));

                var adventure = new Adventurer();
                adventure.Name = "Joseph";
                adventure.Status = "Biwinning";
                adventure.Temperature = 30;
                adventure.SuitPressure = 3;
                adventure.OxygenRemaining = TimeSpan.FromDays(2);
                adventure.HeartRateMode = HeartRateMode.Green;
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