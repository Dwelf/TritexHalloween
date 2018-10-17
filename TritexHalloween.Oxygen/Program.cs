using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using TritexHalloween.Server;

namespace TritexHalloween.Oxygen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var ip = IPAddress.Parse("127.0.0.1");
            var server = new Server.Server(ip);

            if (Console.ReadKey().Key == ConsoleKey.R)
            {
                var form = new FRM_OxygenIndicator();
                Application.Run(form);
            }
        }
    }
}
