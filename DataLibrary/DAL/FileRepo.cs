using DataLibrary.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DAL
{
    public class FileRepo : IRepo
    {
        private string DIR = Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString();// "../worldcup.sfg.io/";
        public string REPRESENTATION;
        public string PATH;

        private Task<RestResponse<T>> GetData<T>(string source)
        {
            RestClient restClient = new RestClient(source);
            Task<RestResponse<T>> task = restClient.ExecuteAsync<T>(new RestRequest());
            return task;
        }

        private T Desserialize<T>(RestResponse<T> restResponse)
        {
            return JsonConvert.DeserializeObject<T>(restResponse.Content);
        }

        public void Settings(Settings settings)
        {
            if (settings.Championship == Model.Settings.ChampionshipE.Women)
            {
                REPRESENTATION = DIR + @"\women";
            }
            if (settings.Championship == Model.Settings.ChampionshipE.Men)
            {
                REPRESENTATION = DIR + @"\men";
            }
        }

        public async Task<IList<Player>> LoadPlayers(string fifaCode)
        {
            PATH = REPRESENTATION + @"\matches.json";
            IList<Match> matches = new List<Match>();
            IList<Player> players = new List<Player>();
            IList<TeamStatistics> teams = new List<TeamStatistics>();
            RestResponse<IList<Match>> restResponse = await GetData<IList<Match>>(PATH);
            matches = (IList<Match>)Desserialize<IList<Match>>(restResponse);

            foreach (Match match in matches)
            {
                if (match.HomeTeam.Code == fifaCode)
                {
                    teams.Add(match.HomeTeamStatistics);
                }
                if (match.AwayTeam.Code == fifaCode)
                {
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
            return players;
        }

        public async Task<IList<Team>> LoadTeams()
        {
            PATH = REPRESENTATION + @"\results.json";
            IList<Team> teams = new List<Team>();
            RestResponse<IList<Team>> restResponse = await GetData<IList<Team>>(PATH);
            teams = (IList<Team>)Desserialize<IList<Team>>(restResponse);
            return teams;
        }

        public async Task<Team> LoadTeam(string fifaCode)
        {
            PATH = REPRESENTATION + @"\results.json";
            Team team = new Team();
            IList<Team> teams = new List<Team>();
            RestResponse<IList<Team>> restResponse = await GetData<IList<Team>>(PATH);
            teams = (IList<Team>)Desserialize<IList<Team>>(restResponse);
            team = teams.FirstOrDefault(t => t.FifaCode == fifaCode);
            return team;
        }

        public async Task<IList<Match>> LoadTeamRankings(string fifaCode)
        {
            PATH = REPRESENTATION + @"\matches.json";
            IList<Match> matches = new List<Match>();
            IList<Match> wantedMatches = new List<Match>();
            RestResponse<IList<Match>> restResponse = await GetData<IList<Match>>(PATH);
            matches = (IList<Match>)Desserialize<IList<Match>>(restResponse);
            foreach (Match match in matches)
            {
                if (match.HomeTeam.Code == fifaCode)
                {
                    wantedMatches.Add(match);
                }
                if (match.AwayTeam.Code == fifaCode)
                {
                    wantedMatches.Add(match);
                }
            }
            return wantedMatches;
        }
        
        public async Task<IList<Match>> LoadMatches()
        {
            PATH = REPRESENTATION + @"\matches.json";
            IList<Match> matches = new List<Match>();
            RestResponse<IList<Match>> restResponse = await GetData<IList<Match>>(PATH);
            matches = (IList<Match>)Desserialize<IList<Match>>(restResponse);
            return matches;
        }

        public async Task<IList<Player>> LoadPlayerRankings(string fifaCode)
        {
            PATH = REPRESENTATION + @"\matches.json";
            IList<Match> matches = new List<Match>();
            IList<Player> players = new List<Player>();
            IList<TeamStatistics> teams = new List<TeamStatistics>();
            IList<TeamEvent> happenings = new List<TeamEvent>();
            RestResponse<IList<Match>> restResponse = await GetData<IList<Match>>(PATH);
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
                        player.Apearences = 1;
                        players.Add(player);
                    }
                    else
                    {
                        players.FirstOrDefault(p => p.Name == player.Name).Apearences++;
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
                        players.FirstOrDefault(p => happening.Player == p.Name).Scored++;
                        break;
                    case TeamEvent.TypeOfEventE.GoalPenalty:
                        players.FirstOrDefault(p => happening.Player == p.Name).Scored++;
                        break;
                    case TeamEvent.TypeOfEventE.YellowCard:
                        players.FirstOrDefault(p => happening.Player == p.Name).YellowCards++;
                        break;
                    case TeamEvent.TypeOfEventE.YellowCardSecond:
                        players.FirstOrDefault(p => happening.Player == p.Name).YellowCards++;
                        break;
                    case TeamEvent.TypeOfEventE.SubstitutionIn:
                        players.FirstOrDefault(p => happening.Player == p.Name).Apearences++;
                        break;
                }
            }

            return players;
        }
    }
}
