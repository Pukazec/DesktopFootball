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
            Settings settings = new Settings();

            RadioButton selected = gbChampionship.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            settings.Championship = (Settings.ChampionshipE)Enum.Parse(typeof(Settings.ChampionshipE), selected.Text.ToString());
            settings.Language = (Settings.LanguageE)Enum.Parse(typeof(Settings.LanguageE), ddlLanguage.SelectedItem.ToString());

            settings.Save(settings);

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
    }
}
