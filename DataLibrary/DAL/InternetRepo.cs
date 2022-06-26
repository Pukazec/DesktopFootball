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
        public string REPRESENTATION;
        public string URL;

        private RestResponse<T> GetData<T>(string source)
        {
            RestClient restClient = new RestClient(source);
            return restClient.Execute<T>(new RestRequest());
        }

        private T Desserialize<T>(RestResponse<T> restResponse)
        {
            return JsonConvert.DeserializeObject<T>(restResponse.Content);
        }

        public void Settings(Settings settings)
        {
            if (settings.Championship == Model.Settings.ChampionshipE.Women)
            {
                REPRESENTATION = settings.Female;
            }
            if (settings.Championship == Model.Settings.ChampionshipE.Men)
            {
                REPRESENTATION = settings.Male;
            }
        }

        public IList<Player> LoadPlayers(string path)
        {
            URL = REPRESENTATION + path;
            IList<Match> matches = new List<Match>();
            IList<Player> players = new List<Player>();
            IList<TeamStatistics> teams = new List<TeamStatistics>();
            RestResponse<IList<Match>> restResponse = GetData<IList<Match>>(URL);
            matches = (IList<Match>)Desserialize<IList<Match>>(restResponse);
            foreach (Match match in matches)
            {
                if (teams.FirstOrDefault(e => e.Country == match.AwayTeamCountry) == null)
                {
                    teams.Add(match.AwayTeamStatistics);
                }
                if (teams.FirstOrDefault(e => e.Country == match.HomeTeamCountry) == null)
                {
                    teams.Add(match.HomeTeamStatistics);
                }
            }
            foreach(TeamStatistics team in teams)
            {
                foreach (Player player in team.StartingEleven)
                {
                    if (players.FirstOrDefault(e => e.Name == player.Name) == null)
                    {
                        players.Add(player);
                    }
                }
                foreach (Player player in team.Substitutes)
                {
                    if (players.FirstOrDefault(e => e.Name == player.Name) == null)
                    {
                        players.Add(player);
                    }
                }
            }
            return players;
        }

        public IList<Team> LoadTeams(string path)
        {
            URL = REPRESENTATION + path;
            IList<Team> teams = new List<Team>();
            RestResponse<IList<Team>> restResponse = GetData<IList<Team>>(URL);
            teams = (IList<Team>)Desserialize<IList<Team>>(restResponse);
            return teams;
        }

        public IList<Match> LoadTeamRankings(string fifaCode)
        {
            URL = REPRESENTATION + "/matches/country?fifa_code=" + fifaCode;
            IList<Match> matches = new List<Match>();
            RestResponse<IList<Match>> restResponse = GetData<IList<Match>>(URL);
            matches = (IList<Match>)Desserialize<IList<Match>>(restResponse);
            return matches;
        }

        public IList<Player> LoadPlayerRankings(string fifaCode)
        {
            URL = REPRESENTATION + "/matches/country?fifa_code=" + fifaCode;
            IList<Match> matches = new List<Match>();
            IList<Player> players = new List<Player>(); 
            IList<TeamStatistics> teams = new List<TeamStatistics>();
            IList<TeamEvent> happenings = new List<TeamEvent>();
            RestResponse<IList<Match>> restResponse = GetData<IList<Match>>(URL);
            matches = (IList<Match>)Desserialize<IList<Match>>(restResponse);


            foreach (Match match in matches)
            {
                if (match.HomeTeam.Code == fifaCode)
                {
                    foreach (TeamEvent teamEvent in match.HomeTeamEvents)
                    {
                        happenings.Add(teamEvent);
                    }
                    teams.Add(match.HomeTeamStatistics);
                }
                if (match.AwayTeam.Code == fifaCode)
                {
                    foreach (TeamEvent teamEvent in match.AwayTeamEvents)
                    {
                        happenings.Add(teamEvent);
                    }
                    teams.Add(match.AwayTeamStatistics);
                }
            }

            foreach (TeamStatistics team in teams)
            {
                foreach (Player player in team.StartingEleven)
                {
                    if (players.FirstOrDefault(e => e.Name == player.Name) == null)
                    {
                        players.Add(player);
                    }
                }
                foreach (Player player in team.Substitutes)
                {
                    if (players.FirstOrDefault(e => e.Name == player.Name) == null)
                    {
                        players.Add(player);
                    }
                }
            }

            foreach (TeamEvent happening in happenings)
            {
                switch (happening.TypeOfEvent)
                {
                    case TeamEvent.TypeOfEventE.Goal:
                        players.FirstOrDefault(p => happening.Player == p.Name).Scored += 1;
                        break;
                    case TeamEvent.TypeOfEventE.GoalPenalty:
                        players.FirstOrDefault(p => happening.Player == p.Name).Scored += 1;
                        break;
                    case TeamEvent.TypeOfEventE.YellowCard:
                        players.FirstOrDefault(p => happening.Player == p.Name).YellowCards += 1;
                        break;
                    case TeamEvent.TypeOfEventE.YellowCardSecond:
                        players.FirstOrDefault(p => happening.Player == p.Name).YellowCards += 1;
                        break;
                }
            }

            return players;
        }
    }
}
