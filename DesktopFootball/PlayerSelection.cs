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
        private static IRepo repo;
        private IList<Player> allPlayers;
        private IList<Player> filtered = new List<Player>();
        private Control controlStartedDnD;
        private bool succesDnD;


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
            lblFavoretePlayersError.Hide();
        }

        private void PrepareData(IRepo repo)
        {
            try
            {
                allPlayers = repo.LoadPlayers("/matches");
                ShowUsers(allPlayers);
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
                playerSelectionUC.DragDrop += Player_DragDrop;
                playerSelectionUC.DragEnter += Player_DragEnter;
                playerSelectionUC.DragLeave += Player_DragLeave;
                playerSelectionUC.MouseDown += Player_MouseDown;
                pnlPlayers.Controls.Add(playerSelectionUC);
            }
        }

        private void Player_MouseDown(object sender, MouseEventArgs e)
        {
            Player selected = sender as Player;

        }


        private void Player_DragLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Player_DragEnter(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Player_DragDrop(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text == "")
            {
                filtered.Clear();
                ShowUsers(allPlayers);
            }
            else
            {
                filtered.Clear();
                foreach (Player player in allPlayers)
                {
                    if (player.Name.ToUpper().StartsWith(txtSearch.Text.ToUpper()))
                    {
                        filtered.Add(player);
                    }
                }
            }
            ShowUsers(filtered);
        }

        private void pnlFavourets_DragDrop(object sender, DragEventArgs e)
        {
            Panel favoretes = sender as Panel;
            Panel allPlayers = e.Data.GetData(typeof(Panel)) as Panel;

        }

        private void pnlFavourets_DragEnter(object sender, DragEventArgs e)
        {
            PlayerSelectionUC player = sender as PlayerSelectionUC;

            if (player == controlStartedDnD)
            {
                return;
            }

            e.Effect = DragDropEffects.Move;

            lblFavoretePlayersError.Text = "Drop allowed...";
        }

        private void pnlFavourets_DragLeave(object sender, EventArgs e)
        {
            PlayerSelectionUC player = sender as PlayerSelectionUC;

            if (player == controlStartedDnD)
            {
                return;
            }

            lblFavoretePlayersError.Text = "Drop not allowed...";
        }
    }
}
