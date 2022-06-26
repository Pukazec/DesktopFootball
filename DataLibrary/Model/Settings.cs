using DataLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    public class Settings
    {
        public string Female = "https://worldcup.sfg.io";
        public string Male = "https://world-cup-json-2018.herokuapp.com";
        private ISettingsRepo settingsRepo;
        public enum ChampionshipE
        {            
            Men,
            Women
        }

        public enum LanguageE
        {
            Croatian,
            English
        }

        public ChampionshipE Championship { get; set; }
        
        public LanguageE Language { get; set; }
        public Team FavoreteRepresentation { get; set; }
        public IList<Player> FavoretePlayer { get; set; }

        public void Save(Settings settings)
        {
            settingsRepo = RepoFactory.GetSettingsRepo();
            settingsRepo.SaveMainSettings(settings);
        }

        public void SaveRepresentation(Settings settings)
        {
            settingsRepo.SaveRepresentation(settings);
        }
    }
}
