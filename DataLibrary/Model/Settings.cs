using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    public class Settings
    {
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
        public int FavoreteRepresentationId { get; set; }
        public IList<Player> FavoretePlayer { get; set; }
    }
}
