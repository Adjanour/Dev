using DevExpress.Skins;
using DevExpress.UserSkins;
using HostelApp.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HostelApp.Gen;

namespace HostelApp
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
            new xfrmMain().Show();
            Application.Run();
        }
    }
}
