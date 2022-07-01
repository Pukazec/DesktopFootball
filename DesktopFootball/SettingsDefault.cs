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
    public partial class SettingsDefault : Form
    {
        private static IRepo repo;
        private static Settings settings;

        public SettingsDefault(IRepo repository)
        {
            repo = repository;
            InitializeComponent();
        }

        internal void SettingsLoad(Settings mainSettings)
        {
            settings = mainSettings;
            repo.Settings(settings);
            LoadLanguages();
        }

        private void LoadLanguages()
        {
            ddlLanguage.Items.Add(Settings.LanguageE.English);
            ddlLanguage.Items.Add(Settings.LanguageE.Croatian);
            ddlLanguage.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RadioButton selected = gbChampionship.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            settings.Championship = (Settings.ChampionshipE)Enum.Parse(typeof(Settings.ChampionshipE), selected.Text.ToString());
            settings.Language = (Settings.LanguageE)Enum.Parse(typeof(Settings.LanguageE), ddlLanguage.SelectedItem.ToString());

            OpenNextForm(settings);
        }

        private void OpenNextForm(Settings settings)
        {
            Representation representation = new Representation(repo);
            representation.Settings(settings);
            representation.Parent(this);
            representation.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
