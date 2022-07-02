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
    public partial class PlayerRangUC : UserControl
    {
        private static IImageRepo images;

        public PlayerRangUC(IImageRepo imagesRepo)
        {
            images = imagesRepo;
            InitializeComponent();
        }

        internal void LoadData(string name, int apearences, int scored, int yellowCards, string imgUrl, bool favorete, Settings settings)
        {
            lblName.Text = name;
            lblApearences.Text = apearences.ToString();
            lblGoalsScored.Text = scored.ToString();
            lblYellowCard.Text = yellowCards.ToString();
            if (imgUrl != null)
            {
                imgPlayer.ImageLocation = imgUrl;
            }
            if (favorete)
            {
                BackColor = Color.DarkGoldenrod;
            }
            if (images.LoadImage(name) != null)
            {
                imgPlayer.ImageLocation = images.LoadImage(name);
            }
        }

        internal string GetPlayerName()
        {
            return lblName.Text;
        }
    }
}
