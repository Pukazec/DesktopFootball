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
    public partial class RangList : Form
    {
        private static IRepo repo;
        private static Settings settings;

        public RangList(IRepo repo)
        {
            InitializeComponent();
        }

        internal void Settings(Settings mainSettings)
        {
            settings = mainSettings;
            //PrepareData();
        }
    }
}
