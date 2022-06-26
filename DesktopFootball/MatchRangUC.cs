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
    public partial class MatchRangUC : UserControl
    {
        public MatchRangUC()
        {
            InitializeComponent();
        }
        public void LoadData(string location, long attendents, string homeTeam, string awayTeam)
        {
            lblLocation.Text = location;
            lblAttendance.Text = attendents.ToString();
            lblHomeTeam.Text = homeTeam;
            lblAwayTeam.Text = awayTeam;
        }
    }
}
