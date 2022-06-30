using DataLibrary;
using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFFootball
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        private static IRepo repo;
        private IList<Team> teams;
        private IList<Match> matches;
        private static Settings settings;

        public Game(IRepo repository)
        {
            repo = repository;
            InitializeComponent();
        }

        public void Settings(Settings mainSettings)
        {
            settings = mainSettings;
            repo.Settings(settings);
            PrepareData();
        }

        private void PrepareData()
        {
            matches = repo.LoadMatches("/matches");
            teams = repo.LoadTeams("/teams/results");
            teams.ToList().Sort();
            teams.ToList().ForEach(t => ddlHomeTeam.Items.Add(t));

            ddlHomeTeam.SelectedItem = settings.FavoreteRepresentation;

            LoadDdlAwayTeam();
        }

        private void LoadDdlAwayTeam()
        {
            foreach (Match match in matches)
            {
                if (match.HomeTeam.Equals(ddlHomeTeam.SelectedItem))
                {
                    ddlAgainstTeam.Items.Add(
                        teams.FirstOrDefault(t => t.Equals(match.AwayTeam)));
                }
            }
            ddlAgainstTeam.SelectedIndex = 0;
        }

        private void OpenHomeTeam_Click(object sender, RoutedEventArgs e)
        {
            Team selectedTeam = (Team)ddlHomeTeam.SelectedItem;

            TeamDetails team = new TeamDetails();
            team.LoadData(selectedTeam);
            team.Show();
            this.Close();
        }

        private void AwayHomeTeam_Click(object sender, RoutedEventArgs e)
        {
            Team selectedTeam = (Team)ddlAgainstTeam.SelectedItem;

            TeamDetails team = new TeamDetails();
            team.LoadData(selectedTeam);
            team.Show();
            this.Close();
        }

        private void ddlHomeTeam_IndexChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadDdlAwayTeam();
        }

        private void ddlAwayTeam_IndexChanged(object sender, SelectionChangedEventArgs e)
        {
            Match match = matches.FirstOrDefault
                (m => 
                    m.HomeTeam == ddlHomeTeam.SelectedItem 
                    && m.AwayTeam == ddlAgainstTeam.SelectedItem
                );
            lblResult.Content = $"{match.HomeTeam.Goals} : {match.AwayTeam.Goals}";
        }
    }
}
