using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopFootball
{
    public partial class MyMessage : Form
    {
        private static Settings.LanguageE language;
        public bool Save { get; set; }
        public MyMessage(Settings.LanguageE setLanguage)
        {
            language = setLanguage;
            CultureInfo culture = new CultureInfo(language.ToString());
            Thread.CurrentThread.CurrentUICulture = culture;
            InitializeComponent();
        }

        private void MyMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnYes_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnNo_Click(sender, e);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Save = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Save=false;
            this.Close();
        }
    }
}
