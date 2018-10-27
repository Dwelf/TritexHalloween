using System;
using System.Windows.Forms;


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
            string ip = "127.0.0.1";

            var form = new FRM_OxygenIndicator(ip);
            Application.Run(form);
        }
    }
}
