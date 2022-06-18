using DataLibrary;
using DataLibrary.DAL;
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
    public partial class PlayerSelection : Form
    {
        public PlayerSelection()
        {
            InitializeComponent();
        }

        private void PlayerSelection_Load(object sender, EventArgs e)
        {
            IRepo repo = RepoFactory.GetRepo();
            lblFavoretePlayersError.Text = "Loading data...";
            PrepareData(repo);
        }

        private void PrepareData(IRepo repo)
        {
            try
            {
                IList<Team> teams = repo.LoadTeams();
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
    }
}
