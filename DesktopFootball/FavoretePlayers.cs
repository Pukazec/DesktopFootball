using DataLibrary;
using DataLibrary.DAL;
using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopFootball
{
    public partial class FavoretePlayers : Form
    {
        private static IRepo repo;
        private static Settings settings;
        private static IImageRepo images;
        private IList<Player> allPlayers;
        private Representation parentForm;
        private IList<Player> filtered = new List<Player>();
        private IList<PlayerSelectionUC> selectedPlayers = new List<PlayerSelectionUC>();
        private FlowLayoutPanel parent;

        public FavoretePlayers(IRepo repository, Settings mainSettings, IImageRepo imagesRepo, Representation representation)
        {

            repo = repository;
            settings = mainSettings;
            images = imagesRepo;
            parentForm = representation;
            CultureInfo culture = new CultureInfo(settings.Language.ToString());
            Thread.CurrentThread.CurrentUICulture = culture;
            InitializeComponent();
            PrepareData();
        }

        //*************************************************************************************************** Data load ********************************************************************//

        private async void PrepareData()
        {
            lblFavoretePlayersError.Text = "Loading data...";
            lblFavoretePlayersError.Visible = true;
            try
            {
                allPlayers = await repo.LoadPlayers(settings.FavoreteRepresentation.FifaCode);
                ShowUsers(allPlayers);
            }
            catch (Exception)
            {
                lblFavoretePlayersError.Text = "Conntect costumer support.\nKontaktiraj korisničku službu.";
                lblFavoretePlayersError.Show();
            }
            lblFavoretePlayersError.Visible = false;
        }

        private void ShowUsers(IList<Player> players)
        {
            pnlAllPlayers.Controls.Clear();
            foreach (Player player in players)
            {
                PlayerSelectionUC playerSelection = new PlayerSelectionUC(images)
                {
                    Name = player.Name,
                    ContextMenuStrip = playerContextMenuStrip
                };
                playerSelection.LoadData(player.Name, player.ShirtNumber, player.Position, player.Captain);
                playerSelection.MouseDown += PlayerSelection_MouseDown;

                pnlAllPlayers.Controls.Add(playerSelection);
            }
        }

        //*************************************************************************************************** Data search ********************************************************************//

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
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
                ShowUsers(filtered);
            }

        }

        //*************************************************************************************************** Button clicks ********************************************************************//

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pnlFavoretePlayers.Controls.Count < 3)
            {
                lblFavoretePlayersError.Text = "Select more players";
                lblFavoretePlayersError.Visible = true;
                return;
            }
            IList<Player> favoretes = new List<Player>();
            foreach (PlayerSelectionUC favourete in pnlFavoretePlayers.Controls)
            {
                favoretes.Add(favourete.GetPlayer());
            }
            settings.FavoretePlayers = favoretes;

            OpenNextForm(settings);
        }

        private void OpenNextForm(Settings settings)
        {
            RangList rangList = new RangList(repo, settings, images);
            rangList.Show();
            this.Hide();
        }

        //*************************************************************************************************** Data move ********************************************************************//

        private void PlayerSelection_MouseDown(object sender, MouseEventArgs e)
        {
            PlayerSelectionUC selectedPlayer = sender as PlayerSelectionUC;
            selectedPlayer.BackColor = Color.LightGray;
            selectedPlayers.Add(selectedPlayer);

            parent = (FlowLayoutPanel)selectedPlayer.Parent;
            if (selectedPlayers.Count < 1) { return; }
            selectedPlayer.DoDragDrop(selectedPlayer, DragDropEffects.Move);
        }

        private void pnlPlayers_DragEnter(object sender, DragEventArgs e)
        {
            FlowLayoutPanel starter = sender as FlowLayoutPanel;

            if (starter == parent)
            {
                return;
            }

            e.Effect = DragDropEffects.Move;
        }

        private void pnlPlayers_DragDrop(object sender, DragEventArgs e)
        {
            MovePlayers();
        }

        private void playerContextMenuStrip_Opened(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenu = sender as ContextMenuStrip;
            PlayerSelectionUC playerSelectionUC = contextMenu.SourceControl as PlayerSelectionUC;
            if (playerSelectionUC == null)
            {
                return;
            }

            parent = (FlowLayoutPanel)playerSelectionUC.Parent;
            playerSelectionUC.BackColor = Color.LightGray;
            selectedPlayers.Add(playerSelectionUC);
        }

        private void moveToOtherList_Click(object sender, EventArgs e)
        {
            MovePlayers();
        }

        private void MovePlayers()
        {
            if (parent == pnlAllPlayers)
            {
                selectedPlayers.ToList().ForEach(player => player.SetFav());
                selectedPlayers.ToList().ForEach(player => pnlFavoretePlayers.Controls.Add(player));
                selectedPlayers.ToList().ForEach(player => pnlAllPlayers.Controls.Remove(player));
            }
            if (parent == pnlFavoretePlayers)
            {
                selectedPlayers.ToList().ForEach(player => player.SetNotFav());
                selectedPlayers.ToList().ForEach(player => pnlAllPlayers.Controls.Add(player));
                selectedPlayers.ToList().ForEach(player => pnlFavoretePlayers.Controls.Remove(player));
            }
            selectedPlayers.ToList().ForEach(player => player.BackColor = Color.DarkGray);
            selectedPlayers.Clear();
        }

        private void FavoretePlayers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
