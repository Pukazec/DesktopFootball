using DataLibrary;
using DataLibrary.DAL;
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
    public partial class Representation : Form
    {
        private static IRepo repo;
        private IList<Team> teams;
        private static Settings settings;
        public Representation(IRepo repository)
        {
            repo = repository;
            InitializeComponent();
        }

        private void PrepareData()
        {
            try
            {
                teams = repo.LoadTeams("/teams/results");
                teams.ToList().Sort();
                teams.ToList().ForEach(t => ddlRepresentation.Items.Add(t.Country));
                ddlRepresentation.SelectedIndex = 0;
                lblFavoreteRepresentationError.Visible = false;
            }
            catch (Exception ex)
            {
                lblFavoreteRepresentationError.Text = ex.Message;
                lblFavoreteRepresentationError.Show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Team selectedTeam = teams.FirstOrDefault(t => t.Country == ddlRepresentation.SelectedItem.ToString());
            settings.FavoreteRepresentation = selectedTeam;

            OpenNextForm(settings);
        }


        private void OpenNextForm(Settings settings)
        {
            FavoretePlayers favoretePlayers = new FavoretePlayers(repo);
            favoretePlayers.Settings(settings);
            favoretePlayers.Show();
            this.Hide();
        }

        public void Settings(Settings mainSettings)
        {
            settings = mainSettings;
            repo.Settings(settings);
            PrepareData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Parent.Show();
            this.Close();
        }
    }
}
