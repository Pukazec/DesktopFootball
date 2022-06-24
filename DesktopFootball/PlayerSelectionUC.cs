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
    public partial class PlayerSelectionUC : UserControl
    {
        public PlayerSelectionUC()
        {
            InitializeComponent();
        }

        public PlayerSelectionUC(string lblPlayerName, long lblPlayerNumber, Player.PositionE lblPlayerPosition, bool isCapetan)
        {
            this.lblPlayerName.Text = lblPlayerName;
            this.lblPlayerNumber.Text = lblPlayerNumber.ToString();
            this.lblPlayerPosition.Text = lblPlayerPosition.ToString();
            if (isCapetan)
            {
                lblPlayerCapetan.Text = "Yes";
            } else
            {
                lblPlayerCapetan.Text = "No";
            }
        }
    }
}
