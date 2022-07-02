using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DAL
{
    public class FileRepo : IRepo
    {
        public Task<IList<Match>> LoadMatches(string path)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Player>> LoadPlayerRankings(string fifaCode)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Player>> LoadPlayers(string path)
        {
            throw new NotImplementedException();
        }

        public Task<Team> LoadTeam(string fifaCode)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Match>> LoadTeamRankings(string fifaCode)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Team>> LoadTeams(string path)
        {
            throw new NotImplementedException();
        }

        public void Settings(Settings settings)
        {
            throw new NotImplementedException();
        }
    }
}
