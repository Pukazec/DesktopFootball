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
    public partial class PlayerRangUC : UserControl
    {
        public PlayerRangUC()
        {
            InitializeComponent();
        }

        internal void LoadData(string name, int apearences, int scored, int yellowCards, string imgUrl, Settings settings)
        {
            lblName.Text = name;
            lblApearences.Text = apearences.ToString();
            lblGoalsScored.Text = scored.ToString();
            lblYellowCard.Text = yellowCards.ToString();
            if (imgUrl != null)
            {
                imgPlayer.ImageLocation = imgUrl;
            }
        }

        internal string GetPlayerName()
        {
            return lblName.Text;
        }
    }
}
