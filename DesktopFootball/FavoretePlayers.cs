﻿using DataLibrary;
using DataLibrary.DAL;
using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private IList<PlayerSelectionUC> selectedPlayers = new List<PlayerSelectionUC>();
        private FlowLayoutPanel parent;

        public FavoretePlayers(IRepo repository)
        {
            repo = repository;
            InitializeComponent();
        }

        //*************************************************************************************************** Data load ********************************************************************//

        private void PrepareData()
        {
            try
            {
                allPlayers = repo.LoadPlayers(settings.FavoreteRepresentation.FifaCode);
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
            pnlAllPlayers.Controls.Clear();
            foreach (Player player in players)
            {
                PlayerSelectionUC playerSelection = new PlayerSelectionUC();
                playerSelection.Name = player.Name;
                playerSelection.ContextMenuStrip = playerContextMenuStrip;
                playerSelection.LoadData(player.Name, player.ShirtNumber, player.Position, player.Captain);
                playerSelection.MouseDown += PlayerSelection_MouseDown;

                pnlAllPlayers.Controls.Add(playerSelection);
            }
        }

        internal void Settings(Settings mainSettings)
        {
            settings = mainSettings;
            PrepareData();
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
            Representation representation = new Representation(repo);
            representation.Settings(settings);
            representation.Show();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pnlFavoretePlayers.Controls.Count < 3)
            {
                lblFavoretePlayersError.Text = "Select more players";
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
            RangList rangList = new RangList(repo);
            rangList.Settings(settings);
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
                selectedPlayers.ToList().ForEach(player => pnlFavoretePlayers.Controls.Add(player));
                selectedPlayers.ToList().ForEach(player => pnlAllPlayers.Controls.Remove(player));
            }
            if (parent == pnlFavoretePlayers)
            {

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
