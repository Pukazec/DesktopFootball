using DataLibrary;
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
    public partial class RangList : Form
    {
        private static IRepo repo;
        private static Settings settings;
        private IList<Match> matches;
        private IList<Match> sortedMatches;
        private IList<Player> players;
        private IList<Player> sortedPlayers;
        private PlayerRangUC selectedPlayer;
        private bool editing;

        public RangList(IRepo repository)
        {
            repo = repository;
            InitializeComponent();
        }

        internal async Task Settings(Settings mainSettings)
        {
            lblError.Text = "Loadin data...";
            lblError.Visible = true;
            settings = mainSettings;
            string fifaCode = settings.FavoreteRepresentation.FifaCode;
            try
            {
                matches = await repo.LoadTeamRankings(fifaCode);
                players = await repo.LoadPlayerRankings(fifaCode);
            }
            catch (Exception)
            {
                lblError.Text = "Conntect costumer support.\nKontaktiraj korisničku službu.";
                lblError.Visible = true;
            }
            foreach (Player player in players)
            {
                if (settings.FavoretePlayers.FirstOrDefault(p => player.Name == p.Name) != null)
                {
                    player.Favorete = true;
                }
            }
            LoadDdls();
            lblError.Visible = false;
        }

        private void LoadDdls()
        {
            ddlMatchSorter.Items.Add("Attendance asc");
            ddlMatchSorter.Items.Add("Attendance desc");
            ddlMatchSorter.SelectedIndex = 0;
            ddlPlayersSort.Items.Add("Goals scored asc");
            ddlPlayersSort.Items.Add("Goals scored desc");
            ddlPlayersSort.Items.Add("Yellow cards asc");
            ddlPlayersSort.Items.Add("Yellow cards desc");
            ddlPlayersSort.SelectedIndex = 0;
        }

        private void ddlMatchSorter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortedMatches != null)
            {
                sortedMatches.Clear();
            }

            pnlMatches.Controls.Clear();

            if (ddlMatchSorter.SelectedIndex == 0)
            {

                sortedMatches = matches.OrderBy(match => match.Attendance).ToList();
            }
            if (ddlMatchSorter.SelectedIndex == 1)
            {
                sortedMatches = matches.OrderByDescending(match => match.Attendance).ToList();
            }

            LoadMatches(sortedMatches);
        }

        private void LoadMatches(IList<Match> sortedMatches)
        {
            foreach (Match match in sortedMatches)
            {
                MatchRangUC matchRang = new MatchRangUC();
                matchRang.LoadData(match.Location, match.Attendance, match.HomeTeamCountry, match.AwayTeamCountry);
                pnlMatches.Controls.Add(matchRang);
            }
        }

        private void ddlPlayersSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortedPlayers != null)
            {
                sortedPlayers.Clear();
            }

            pnlPlayers.Controls.Clear();

            switch (ddlPlayersSort.SelectedIndex)
            {
                case 0:
                    sortedPlayers = players.OrderBy(player => player.Scored).ToList();
                    break;
                case 1:
                    sortedPlayers = players.OrderByDescending(player => player.Scored).ToList();
                    break;
                case 2:
                    sortedPlayers = players.OrderBy(player => player.YellowCards).ToList();
                    break;
                case 3:
                    sortedPlayers = players.OrderByDescending(player => player.YellowCards).ToList();
                    break;
            }

            LoadPlayers(sortedPlayers);
        }

        private void LoadPlayers(IList<Player> sortedPlayers)
        {
            foreach (Player player in sortedPlayers)
            {
                PlayerRangUC playerRang = new PlayerRangUC();
                playerRang.LoadData(player.Name, player.Apearences, player.Scored, player.YellowCards, player.ImgUrl, player.Favorete, settings);
                pnlPlayers.Controls.Add(playerRang);
            }
        }

        private void pageSettings_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }

        private void printerSelection_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void printPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void print_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            Bitmap print;
            int height;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (tabControl.SelectedTab == tabPlayers)
            {
                height = pnlPlayers.Height;
                pnlPlayers.Height = 1800;
                print = new Bitmap(pnlPlayers.Width, pnlPlayers.Height);
                pnlPlayers.DrawToBitmap(print, new Rectangle(0, 0, pnlPlayers.Width, pnlPlayers.Height));
                e.Graphics.DrawImage(print, (pagearea.Width / 2) - (pnlPlayers.Width / 2), 20f);
                pnlPlayers.Height = height;
            }

            if (tabControl.SelectedTab == tabMatches)
            {
                height = pnlMatches.Height;
                pnlMatches.Height = 1800;
                print = new Bitmap(pnlMatches.Width, pnlMatches.Height);
                pnlMatches.DrawToBitmap(print, new Rectangle(0, 0, pnlMatches.Width, pnlMatches.Height));
                e.Graphics.DrawImage(print, (pagearea.Width / 2) - (pnlMatches.Width / 2), 20f);
                pnlMatches.Height = height;
            }
        }

        private void editSettings_Click(object sender, EventArgs e)
        {
            SettingsDefault settingsDefault = new SettingsDefault(repo);
            settingsDefault.SettingsLoad(settings);
            settingsDefault.Show();
            editing = true;
            this.Hide();
        }

        private void contextMenuStrip_Opened(object sender, EventArgs e)
        {
            if (selectedPlayer != null)
            {
                selectedPlayer.BorderStyle = BorderStyle.None;
            }

            ContextMenuStrip contextMenu = sender as ContextMenuStrip;
            PlayerRangUC player = contextMenu.SourceControl as PlayerRangUC;

            player.BorderStyle = BorderStyle.Fixed3D;
            selectedPlayer = player;
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult image = ofd.ShowDialog();
            if (image == DialogResult.OK)
            {
                string playerName = selectedPlayer.GetPlayerName();
                players.FirstOrDefault(p => p.Name == playerName).ImgUrl = ofd.FileName;
            }
        }

        private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMessage myMessage = new MyMessage();
            myMessage.ShowDialog();
            if (myMessage.Save)
            {
                settings.Save(settings);
            }
        }

        private void RangList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!editing)
            {
                MyMessage myMessage = new MyMessage();
                myMessage.ShowDialog();
                if (myMessage.Save)
                {
                    settings.Save(settings);
                }
            }
        }
    }
}
