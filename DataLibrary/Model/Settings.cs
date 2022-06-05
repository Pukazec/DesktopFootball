using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    internal class Settings
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
        public Result FavoreteRepresentation { get; set; }
        public Player FavoretePlayer { get; set; }
    }
}
