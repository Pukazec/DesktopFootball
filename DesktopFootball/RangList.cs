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

        public RangList(IRepo repository)
        {
            repo = repository;
            InitializeComponent();
        }

        internal void Settings(Settings mainSettings)
        {
            settings = mainSettings;
            PrepareData();
        }

        private void PrepareData()
        {
            matches = repo.LoadTeamRankings(settings.FavoreteRepresentation.FifaCode);
            foreach (Match match in matches)
            {
                MatchRangUC matchRang = new MatchRangUC();
                matchRang.LoadData(match.Location, match.Attendance, match.HomeTeamCountry, match.AwayTeamCountry);
                pnlMatches.Controls.Add(matchRang);
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
