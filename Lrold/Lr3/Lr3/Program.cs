using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Principal;
using System.ComponentModel;
using System.Reflection;

namespace Lr3
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            #region Request admin acess
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
            if (!hasAdministrativeRight)
            {
                // relaunch the application with admin rights
                string fileName = Assembly.GetExecutingAssembly().Location;
                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.Verb = "runas";
                processInfo.FileName = fileName;

                try
                {
                    Process.Start(processInfo);
                }
                catch (Win32Exception)
                {
                    // This will be thrown if the user cancels the prompt
                }

                return;
            }
            #endregion
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            FileSystemExplorer sys = new FileSystemExplorer();
        }
    }
}
