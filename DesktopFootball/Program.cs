using DataLibrary;
using DataLibrary.DAL;
using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopFootball
{
    internal static class Program
    {
        private static IRepo repo;
        private static Settings settings;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            repo = RepoFactory.GetRepo();
            settings = new Settings();
            if (settings.Exists())
            {
                settings = settings.Load();
                RangList rangList = new RangList(repo);
                repo.Settings(settings);
                rangList.Settings(settings);
                rangList.Show();
                Application.Run(rangList);
            }
            else
            {
                SettingsDefault settingsDefault = new SettingsDefault(repo);
                settingsDefault.SettingsLoad(settings);
                Application.Run(settingsDefault);
            }
        }
    }
}
