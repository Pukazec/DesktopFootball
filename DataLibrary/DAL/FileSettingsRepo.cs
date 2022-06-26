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
        private static readonly string DIR = "C:/temp";
        private static readonly string PATH = DIR + "/settings.txt";

        public FileSettingsRepo()
        {
            CreateFilesIfNonExistent();
        }

        private void CreateFilesIfNonExistent()
        {
            Directory.CreateDirectory(DIR);
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


            //settings.FavoreteRepresentationId = int.Parse(lines[2]);
            //settings.FavoretePlayer = lines[3] != null ? lines[3] : 
            
            return settings;
        }

        public void SaveMainSettings(Settings settings)
        {
            //Settings lastSettings = LoadSettings();
            IList<string> lines = new List<string>();
            lines.Add(settings.Championship.ToString());
            lines.Add(settings.Language.ToString());
            File.WriteAllLines(PATH, lines.ToArray());
        }

        public void SavePlayers(Settings settings)
        {
            IList<string> lines = new List<string>();
            lines.Add(settings.Championship.ToString());
            lines.Add(settings.Language.ToString());
            lines.Add(settings.FavoreteRepresentation.ParseForFileLine());
            foreach (Player player in settings.FavoretePlayers)
            {
                lines.Add(player.ParseForFileLine());
            }
            File.WriteAllLines(PATH, lines.ToArray());
        }

        public void SaveRepresentation(Settings settings)
        {
            IList<string> lines = new List<string>();
            lines.Add(settings.Championship.ToString());
            lines.Add(settings.Language.ToString());
            lines.Add(settings.FavoreteRepresentation.ParseForFileLine());
            File.WriteAllLines(PATH, lines.ToArray());
        }
    }
}
