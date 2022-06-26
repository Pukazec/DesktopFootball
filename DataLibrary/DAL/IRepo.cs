using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IRepo
    {
        void Settings(Settings settings);
        IList<Team> LoadTeams(string path);
        IList<Player> LoadPlayers(string path);
        IList<Match> LoadTeamRankings(string fifaCode);
    }
}
