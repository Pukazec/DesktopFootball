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
    public partial class FavoretePlayers : Form
    {
        private static IRepo repo;
        private static Settings settings;
        private IList<Player> allPlayers;
        private IList<Player> filtered = new List<Player>();
        private Control controlStartedDnD;
        private bool succesDnD;

        public FavoretePlayers(IRepo repository)
        {
            repo = repository;
            InitializeComponent();
        }

        private void FavoretePlayers_Load(object sender, EventArgs e)
        {
            IRepo repo = RepoFactory.GetRepo();
            lblFavoretePlayersError.Text = "Loading data...";
            PrepareData();
            lblFavoretePlayersError.Hide();
        }

        private void PrepareData()
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
            lbAllPlayers.Items.Clear();
            foreach (Player player in players)
            {
                lbAllPlayers.Items.Add(player);
            }
            players.ToList().ForEach(p => lbAllPlayers.Items.Add(p));
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            filtered.Clear();
            if (txtSearch.Text == "")
            {
                ShowUsers(allPlayers);
            }
            else
            {
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

        internal void Settings(Settings mainSettings)
        {
            settings = mainSettings;
            PrepareData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox selected = sender as ListBox;
            IList<Player> move = new List<Player>();
            
            foreach (Player player in selected.SelectedItems)
            {
                move.Add(player);
            }

            controlStartedDnD = selected;
            if(move.Count < 1) { return; }
            selected.DoDragDrop(selected, DragDropEffects.Move);

            if (succesDnD)
            {
                selected.SelectedItems.Clear();
                controlStartedDnD = null;
                succesDnD = false;
            }
        }

        private void lbAllPlayers_DragEnter(object sender, DragEventArgs e)
        {
            ListBox starter = sender as ListBox;

            if (starter == controlStartedDnD)
            {
                return;
            }

            e.Effect = DragDropEffects.Move;
        }

        private void lbAllPlayers_DragDrop(object sender, DragEventArgs e)
        {
            ListBox finish = sender as ListBox;
            //IList<Player> start = e.Data.GetData(typeof(IList<Player>)) as IList<Player>;
            ListBox start = e.Data.GetData(typeof(ListBox)) as ListBox;

            //start.ToList().ForEach(player => finish.Items.Add(player));
            foreach (Player player in start.SelectedItems)
            {
                finish.Items.Add(player);
            }

            succesDnD = true;
        }
    }
}
