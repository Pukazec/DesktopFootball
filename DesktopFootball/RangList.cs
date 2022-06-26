using DataLibrary;
using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopFootball
{
    public partial class RangList : Form
    {
        private static IRepo repo;
        private static Settings settings;
        private IList<Match> matches;
        private IList<Match> sortedMatches;
        private IList<Player> players;
        private IList<Player> sortedPlayers;

        public RangList(IRepo repository)
        {
            repo = repository;
            InitializeComponent();
        }

        internal void Settings(Settings mainSettings)
        {
            settings = mainSettings;
            string fifaCode = settings.FavoreteRepresentation.FifaCode;
            matches = repo.LoadTeamRankings(fifaCode);
            players = repo.LoadPlayerRankings(fifaCode);
        }

        private void RangList_Load(object sender, EventArgs e)
        {
            ddlMatchSorter.Items.Add("Attendance asc");
            ddlMatchSorter.Items.Add("Attendance desc");
            ddlMatchSorter.SelectedIndex = 0;
            ddlPlayersSort.Items.Add("Goals scored asc");
            ddlPlayersSort.Items.Add("Goals scored desc");
            ddlPlayersSort.Items.Add("Yellow cards asc");
            ddlPlayersSort.Items.Add("Yellow cards desc");
            ddlPlayersSort.SelectedIndex = 0;
        }

        private void ddlMatchSorter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortedMatches != null)
            {
                sortedMatches.Clear();
            }

            pnlMatches.Controls.Clear();
            
            if (ddlMatchSorter.SelectedIndex == 0)
            {
                sortedMatches = matches.OrderBy(match => match.Attendance).ToList();
            }
            if (ddlMatchSorter.SelectedIndex == 1)
            {
                sortedMatches = matches.OrderByDescending(match => match.Attendance).ToList();
            }
            
            LoadMatches(sortedMatches);
        }

        private void LoadMatches(IList<Match> sortedMatches)
        {
            foreach (Match match in matches)
            {
                MatchRangUC matchRang = new MatchRangUC();
                matchRang.LoadData(match.Location, match.Attendance, match.HomeTeamCountry, match.AwayTeamCountry);
                pnlMatches.Controls.Add(matchRang);
            }
        }

        private void ddlPlayersSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortedPlayers != null)
            {
                sortedPlayers.Clear();
            }

            pnlPlayers.Controls.Clear();

            switch (ddlPlayersSort.SelectedIndex)
            {
                case 0:
                    sortedPlayers = players.OrderBy(player => player.Scored).ToList();
                    break;
                case 1:
                    sortedPlayers = players.OrderByDescending(player => player.Scored).ToList();
                    break;
                case 2:
                    sortedPlayers = players.OrderBy(player => player.YellowCards).ToList();
                    break;
                case 3:
                    sortedPlayers = players.OrderByDescending(player => player.YellowCards).ToList();
                    break;
            }

            LoadPlayers(sortedPlayers);
        }

        private void LoadPlayers(IList<Player> sortedPlayers)
        {
            foreach (Player player in players)
            {
                PlayerRangUC playerRang = new PlayerRangUC();
                playerRang.LoadData(player.Name, player.Apearences, player.Scored, player.YellowCards, settings);
                pnlPlayers.Controls.Add(playerRang);
            }
        }

        private void RangList_Closing(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save settings?", "Save settings", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                settings.Save(settings);
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
