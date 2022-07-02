using DataLibrary;
using DataLibrary.DAL;
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
    /// Interaction logic for SettingsDefault.xaml
    /// </summary>
    public partial class SettingsDefault : Window
    {
        private static IRepo repo;
        private static Settings settings;
        private static bool edit;

        public SettingsDefault()
        {
            repo = RepoFactory.GetRepo();
            settings = new Settings();
            if (settings.Exists() && !edit)
            {
                settings = settings.Load();
                repo.Settings(settings);
                OpenNextForm(settings);
            }
            InitializeComponent();
            LoadLanguages();
        }

        private void LoadLanguages()
        {
            ddlChampionship.Items.Add(Settings.ChampionshipE.Women);
            ddlChampionship.Items.Add(Settings.ChampionshipE.Men);
            ddlChampionship.SelectedIndex = 0;
            ddlLanguage.Items.Add(Settings.LanguageE.English);
            ddlLanguage.Items.Add(Settings.LanguageE.Croatian);
            ddlLanguage.SelectedIndex = 0;
            ddlSize.Items.Add(Settings.WindowSizeE.Small);
            ddlSize.Items.Add(Settings.WindowSizeE.Midium);
            ddlSize.Items.Add(Settings.WindowSizeE.Maximize);
            ddlSize.SelectedIndex = 0;
        }

        public SettingsDefault(bool editing)
        {
            edit = editing;
            InitializeComponent();
            LoadLanguages();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            settings.Championship = (Settings.ChampionshipE)Enum.Parse(typeof(Settings.ChampionshipE), ddlChampionship.SelectedItem.ToString());
            settings.Language = (Settings.LanguageE)Enum.Parse(typeof(Settings.LanguageE), ddlLanguage.SelectedItem.ToString());
            settings.Size = (Settings.WindowSizeE)Enum.Parse(typeof(Settings.WindowSizeE), ddlSize.SelectedItem.ToString());

            OpenNextForm(settings);
        }

        private void OpenNextForm(Settings settings)
        {
            Game game = new Game(repo, settings);
            game.Settings(this);
            game.Show();
            this.Hide();
        }
    }
}
