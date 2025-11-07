using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTF
{
    class Startup
    {

        public static void SetStartup(string AppName, string AppPath, bool enable)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (enable)
            {

                if (!CheckStartupItem(AppName))
                    // Add the value in the registry so that the application runs at startup
                    rk.SetValue(AppName, AppPath);

               // MessageBox.Show("Enable  start up");
            }
            else
            {

                rk.DeleteValue(AppName, false);

               // MessageBox.Show("Disable start up");
            }

        }

        public static bool CheckStartupItem(string ProductName)
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rkApp.GetValue(ProductName) == null)
                // The value doesn't exist, the application is not set to run at startup
                return false;
            else
                // The value exists, the application is set to run at startup
                return true;
        }


        public static void background_process(bool Run)
        {
            if (Run)
            {

            }
            else
            {

            }

        }
    }
}
