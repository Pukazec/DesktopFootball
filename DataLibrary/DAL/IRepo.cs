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
        IList<Match> LoadMatches();
        IList<Team> LoadResults();
        IList<Team> LoadGroupResults();
        IList<Team> LoadTeams(string path);
        IList<Group> LoadGroups();
        IList<Player> LoadPlayers(string path);
        IList<TeamEvent> LoadTeamEvents();
        IList<TeamStatistics> LoadTeamStatistics();
        void Settings(Settings settings);
    }
}
