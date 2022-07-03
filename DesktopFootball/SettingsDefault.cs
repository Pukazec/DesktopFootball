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
    public partial class SettingsDefault : Form
    {
        private static IRepo repo;
        private static Settings settings;
        private static IImageRepo images;
        private Settings.LanguageE language;

        public SettingsDefault(IRepo repository)
        {
            repo = repository;
            language = Settings.LanguageE.en;
            SetCulture();
        }

        private void SetCulture()
        {
            CultureInfo culture = new CultureInfo(language.ToString());

            Thread.CurrentThread.CurrentUICulture = culture;

            this.Controls.Clear();
            InitializeComponent();
        }

        internal void SettingsLoad(Settings mainSettings, IImageRepo imagesRepo)
        {
            images = imagesRepo;
            settings = mainSettings;
            repo.Settings(settings);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RadioButton selected = gbChampionship.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            settings.Championship = (Settings.ChampionshipE)Enum.Parse(typeof(Settings.ChampionshipE), selected.Name);
            settings.Language = (Settings.LanguageE)Enum.Parse(typeof(Settings.LanguageE), language.ToString());

            OpenNextForm(settings);
        }

        private void OpenNextForm(Settings settings)
        {
            Representation representation = new Representation(repo, settings, images, this);
            representation.Show();
            this.Hide();
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == Settings.LanguageE.en.ToString())
            {
                language = Settings.LanguageE.hr;
                SetCulture();
            }
            else
            {
                language = Settings.LanguageE.en;
                SetCulture();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
