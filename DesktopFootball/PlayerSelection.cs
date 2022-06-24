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
        IList<Player> players;
        IList<Player> filtered = new List<Player>();


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
                players = repo.LoadPlayers();
                ShowUsers(players);
            }
            catch (Exception ex)
            {
                lblFavoretePlayersError.Text = ex.Message;
                lblFavoretePlayersError.Show();
            }
        }

        private void ShowUsers(IList<Player> players)
        {
            pnlPlayers.Controls.Clear();
            foreach (Player player in players)
            {
                PlayerSelectionUC playerSelectionUC = new PlayerSelectionUC();
                playerSelectionUC.LoadData(player.Name, player.ShirtNumber, player.Position, player.Captain);
                pnlPlayers.Controls.Add(playerSelectionUC);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            IList<Player> temp;
            if (txtSearch.Text == "")
            {
                ShowUsers(players);
                filtered.Clear();
            }
            if (txtSearch.Text.Length == 1)
            {
                foreach (Player player in players)
                {
                    if (player.Name.ToUpper().StartsWith(txtSearch.Text.ToUpper()))
                    {
                        filtered.Add(player);
                    }
                }
            }
            else
            {
                temp = new List<Player>();
                filtered.ToList().ForEach(player => temp.Add(player));
                filtered.Clear();
                foreach (Player player in temp)
                {
                    if (player.Name.ToUpper().StartsWith(txtSearch.Text.ToUpper()))
                    {
                        filtered.Add(player);
                    }
                }
            }
            ShowUsers(filtered);
        }
    }
}
