using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataLibrary.Model.Settings;

namespace DataLibrary.DAL
{
    public class FileSettingsRepo : ISettingsRepo
    {
        private static readonly string PATH = "~/settings.txt";
        private static readonly char DEL = '|';


        public Settings LoadSettings()
        {
            Settings settings = new Settings();

            string[] lines = File.ReadAllLines(PATH);
            if (lines.Length == 0)
            {
                throw new Exception("Settings empty");
            }


            //settings.Championship = line.Split(DEL).First()[0];
            //settings.Language = line.Split(DEL).Last()[0];

            //settings.FavoreteRepresentation = lines[1];
            

            return settings;
        }

        public void SaveMainSettings()
        {
            
        }

        public void SavePlayers()
        {
            
        }

        public void SaveRepresentation()
        {
            
        }
    }
}
