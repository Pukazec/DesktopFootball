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
    public partial class PlayerSelection : Form
    {
        public static IRepo repo;

        public PlayerSelection(IRepo repository)
        {
            repo = repository;
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
                IList<Player> players = repo.LoadPlayers();
                foreach (Player player in players)
                {
                    PlayerSelectionUC playerSelectionUC = new PlayerSelectionUC(player.Name, player.ShirtNumber, player.Position, player.Captain);
                    pnlPlayers.Container.Add(playerSelectionUC);
                }
                /*
                teams.ToList().ForEach(t => ddlRepresentation.Items.Add(t.Country));
                ddlRepresentation.SelectedIndex = 0;
                lblFavoreteRepresentationError.Visible = false;*/
            }
            catch (Exception ex)
            {
                lblFavoretePlayersError.Text = ex.Message;
                lblFavoretePlayersError.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
