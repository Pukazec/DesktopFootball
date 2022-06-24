using DataLibrary.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class InternetRepo : IRepo
    {
        public IList<Team> LoadGroupResults()
        {
            throw new NotImplementedException();
        }

        public IList<Group> LoadGroups()
        {
            throw new NotImplementedException();
        }

        public IList<Match> LoadMatches()
        {
            throw new NotImplementedException();
        }

        public IList<Player> LoadPlayers()
        {
            IList<Match> matches = new List<Match>();
            IList<Player> players = new List<Player>();
            RestResponse<IList<Match>> restResponse = GetData<IList<Match>>("https://world-cup-json-2018.herokuapp.com/matches");
            matches = (IList<Match>)DeserializeTeams<IList<Match>>(restResponse);
            return players;
        }

        public IList<Team> LoadResults()
        {
            throw new NotImplementedException();
        }

        public IList<TeamEvent> LoadTeamEvents()
        {
            throw new NotImplementedException();
        }

        public IList<Team> LoadTeams()
        {
            IList<Team> teams = new List<Team>();
            RestResponse<IList<Team>> restResponse = GetData<IList<Team>>("https://world-cup-json-2018.herokuapp.com/teams/results");
            teams = (IList<Team>)DeserializeTeams<IList<Team>>(restResponse);
            return teams;
        }

        public IList<TeamStatistics> LoadTeamStatistics()
        {
            throw new NotImplementedException();
        }

        private RestResponse<T> GetData<T>(string source)
        {
            RestClient restClient = new RestClient(source);
            return restClient.Execute<T>(new RestRequest());
        }

        private T DeserializeTeams<T>(RestResponse<T> restResponse)
        {
            return JsonConvert.DeserializeObject<T>(restResponse.Content);
        }
    }
}
