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
        Task<IList<Team>> LoadTeams();
        Task<IList<Match>> LoadMatches();
        Task<IList<Player>> LoadPlayers(string fifaCode);
        Task<IList<Match>> LoadTeamRankings(string fifaCode);
        Task<IList<Player>> LoadPlayerRankings(string fifaCode);
        Task<Team> LoadTeam(string fifaCode);
    }
}
