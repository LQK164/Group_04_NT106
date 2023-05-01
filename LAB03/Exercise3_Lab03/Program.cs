using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_server
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread server = new Thread(() =>
            {
                Application.Run(new Server());
            });
            Thread client = new Thread(() =>
            {
                Application.Run(new test_client());
            });
            server.Start();
            client.Start();
        }
    }
}
