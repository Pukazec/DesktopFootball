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
    public partial class PlayerSelectionUC : UserControl, IDisposable
    {
        public PlayerSelectionUC()
        {
            InitializeComponent();
        }

        public void LoadData(string name, long number, Player.PositionE position, bool isCapetan)
        {
            lblPlayerName.Text = name;
            lblPlayerNumber.Text = number.ToString();
            lblPlayerPosition.Text = position.ToString();
            if (isCapetan)
            {
                lblPlayerCapetan.Text = "Yes";
            }
            else
            {
                lblPlayerCapetan.Text = "No";
            }
        }

        public Player GetPlayer()
        {
            Player player = new Player
            {
                Name = lblPlayerName.Text,
                ShirtNumber = int.Parse(lblPlayerNumber.Text),
                Position = (Player.PositionE)Enum.Parse(typeof(Player.PositionE), lblPlayerPosition.Text),
            };

            if (lblPlayerCapetan.Text == "Yes")
            {
                player.Captain = true;
            }
            else
            {
                player.Captain = false;
            }

            return player;
        }
    }
}
