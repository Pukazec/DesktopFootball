using DataLibrary;
using DataLibrary.DAL;
using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopFootball
{
    public partial class Representation : Form
    {
        private static IRepo repo;
        private static IImageRepo images;
        private static Settings settings;
        private static SettingsDefault settingsDefault;
        private IList<Team> teams;
        public Representation(IRepo repository, Settings mainSettings, IImageRepo imagesRepo, SettingsDefault defaultSettings)
        {
            repo = repository;
            images = imagesRepo;
            settings = mainSettings;
            settingsDefault = defaultSettings;
            repo.Settings(settings);
            CultureInfo culture = new CultureInfo(settings.Language.ToString());
            Thread.CurrentThread.CurrentUICulture = culture;
            InitializeComponent();
            PrepareData();
        }

        private async Task PrepareData()
        {
            lblFavoreteRepresentationError.Text = "Loading data...";
            lblFavoreteRepresentationError.Visible = true;
            try
            {
                teams = await repo.LoadTeams();
                teams.ToList().Sort();
                teams.ToList().ForEach(t => ddlRepresentation.Items.Add(t.ToString()));
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
            Team selectedTeam = teams.FirstOrDefault(t => t.Country == ddlRepresentation.SelectedItem.ToString().Split(' ').First());
            settings.FavoreteRepresentation = selectedTeam;

            OpenNextForm(settings);
        }


        private void OpenNextForm(Settings settings)
        {
            FavoretePlayers favoretePlayers = new FavoretePlayers(repo, settings, images, this);
            favoretePlayers.Show();
            this.Hide();
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
