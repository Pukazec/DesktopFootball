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


        public FileSettingsRepo()
        {
            CreateFilesIfNonExistent();
        }

        private void CreateFilesIfNonExistent()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public Settings LoadSettings()
        {
            Settings settings = new Settings();
            string[] lines = File.ReadAllLines(PATH);

            settings.Language = (LanguageE)Enum.Parse(typeof(LanguageE), lines[0]);
            settings.Championship = (ChampionshipE)Enum.Parse(typeof(ChampionshipE), lines[1]);


            settings.FavoreteRepresentationId = int.Parse(lines[2]);
            //settings.FavoretePlayer = lines[3] != null ? lines[3] : 
            
            return settings;
        }

        public void SaveMainSettings()
        {
            Settings settings = LoadSettings();
            //settings.MainSettingsUpdate();
            //File.WriteAllLines(PATH, settings);
        }

        public void SavePlayers()
        {
            
        }

        public void SaveRepresentation()
        {
            
        }
    }
}
