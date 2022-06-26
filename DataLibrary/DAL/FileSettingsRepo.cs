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
            IList<Player> players = new List<Player>();
            settings.FavoretePlayers = new List<Player>();

            settings.Championship = (ChampionshipE)Enum.Parse(typeof(ChampionshipE), lines[0]);
            settings.Language = (LanguageE)Enum.Parse(typeof(LanguageE), lines[1]);

            settings.FavoreteRepresentation = Team.ParseFromFile(lines[2]);
            for (int i = 3; i < lines.Length; i++)
            {
                players.Add(Player.ParseFromFileLine(lines[i]));
            }
            players.ToList().ForEach(p =>settings.FavoretePlayers.Add(p));
            
            return settings;
        }

        public void SaveSettings(Settings settings)
        {
            IList<string> lines = new List<string>
            {
                settings.Championship.ToString(),
                settings.Language.ToString(),
                settings.FavoreteRepresentation.ParseForFileLine()
            };
            foreach (Player player in settings.FavoretePlayers)
            {
                lines.Add(player.ParseForFileLine());
            }
            File.WriteAllLines(PATH, lines.ToArray());
        }

        public bool ExistingSettings()
        {
            string[] lines = File.ReadAllLines(PATH);

            if (lines.Length >= 6)
            {
                return true;
            }

            return false;
        }
    }
}
