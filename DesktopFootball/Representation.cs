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
        private static SettingsDefault settingsDefault;
        public Representation(IRepo repository)
        {
            repo = repository;
            InitializeComponent();
        }

        private async Task PrepareData()
        {
            lblFavoreteRepresentationError.Text = "Loading data...";
            lblFavoreteRepresentationError.Visible = true;
            try
            {
                teams = await repo.LoadTeams("/teams/results");
                teams.ToList().Sort();
                teams.ToList().ForEach(t => ddlRepresentation.Items.Add(t.Country));
                ddlRepresentation.SelectedIndex = 0;
                lblFavoreteRepresentationError.Visible = false;
            }
            catch (Exception ex)
            {
                lblFavoreteRepresentationError.Text = "Conntect costumer support.\nKontaktiraj korisničku službu.";
                btnNext.Enabled = false;
                lblFavoreteRepresentationError.Show();
            }
            lblFavoreteRepresentationError.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ddlRepresentation.SelectedItem == null)
            {
                lblFavoreteRepresentationError.Text = "Representation must be selected";
                return;
            }
            Team selectedTeam = teams.FirstOrDefault(t => t.Country == ddlRepresentation.SelectedItem.ToString());
            settings.FavoreteRepresentation = selectedTeam;

            OpenNextForm(settings);
        }


        private void OpenNextForm(Settings settings)
        {
            FavoretePlayers favoretePlayers = new FavoretePlayers(repo);
            favoretePlayers.Settings(settings);
            favoretePlayers.Parent(this);
            favoretePlayers.Show();
            this.Hide();
        }

        internal void Parent(SettingsDefault defaultSettings)
        {
            settingsDefault = defaultSettings;
        }

        public void Settings(Settings mainSettings)
        {
            settings = mainSettings;
            repo.Settings(settings);
            PrepareData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            settingsDefault.Show();
            this.Close();
        }

        private void Representation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
