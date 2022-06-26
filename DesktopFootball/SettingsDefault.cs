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
        public SettingsDefault()
        {
            InitializeComponent();
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
            Representation representation = new Representation();
            representation.Settings(settings);
            representation.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsDefault_Load(object sender, EventArgs e)
        {
            repo = RepoFactory.GetRepo();
            settings = new Settings();
            if (settings.Exists())
            {
                settings = settings.Load();
                RangList rangList = new RangList(repo);
                repo.Settings(settings);
                rangList.Settings(settings);
                rangList.Show();
                this.Hide();
            }
        }
    }
}
