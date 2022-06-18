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
    public partial class SettingsDefault : Form
    {
        public SettingsDefault()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*Settings settings = new Settings();

            if (rbWomen.Checked)
            {
                settings.Championship = Settings.ChampionshipE.Women;
            }
            else
            {
                settings.Championship = Settings.ChampionshipE.Men;
            }

            settings.Language = Settings.LanguageE.English;// Enum.Parse(ddlLanguage.Text);
            */
            Representation representation = new Representation();
            representation.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
