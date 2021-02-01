using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgIO.Properties;
using Microsoft.Win32;

namespace AgIO
{
    static class Program
    {
        private static readonly Mutex Mutex = new Mutex(true, "{8F6F0AC4-B9A1-55fd-A8CF-72F04E6BDE8F}");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Mutex.WaitOne(TimeSpan.Zero, true))
            {
                ////opening the subkey
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Drive");

                ////create default keys if not existing
                if (regKey == null)
                {
                    RegistryKey Key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Drive");

                    //storing the values
                    Key.SetValue("Language", "en");
                    Key.SetValue("Directory", "Default");
                    Key.Close();

                    Settings.Default.setF_culture = "en";
                    Settings.Default.setF_workingDirectory = "Default";
                    Settings.Default.Save();
                }
                else
                {
                    Settings.Default.setF_culture = regKey.GetValue("Language").ToString();
                    Settings.Default.setF_workingDirectory = regKey.GetValue("Directory").ToString();
                    Settings.Default.Save();
                    regKey.Close();
                }

                //if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Properties.Settings.Default.setF_culture);
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.setF_culture);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormLoop());
            }
            //else
            //{
            //    MessageBox.Show("AgIO is Already Running"); 
            //}
        }
    }
}
