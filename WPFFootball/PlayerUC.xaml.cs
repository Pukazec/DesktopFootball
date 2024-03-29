﻿using DataLibrary.DAL;
using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFFootball
{
    /// <summary>
    /// Interaction logic for PlayerUC.xaml
    /// </summary>
    public partial class PlayerUC : UserControl
    {
        private static IImageRepo images;

        public Player Player { get; set; }
        public PlayerUC(IImageRepo imagesRepo)
        {
            images = imagesRepo;
            InitializeComponent();
        }

        internal void LoadData(Player player)
        {
            lblName.Content = player.Name;
            lblNumber.Content = player.ShirtNumber;
            Player = player;
            if (images.LoadImage(player.Name) != null)
            {
                imgPlayer.Source = new BitmapImage(new Uri(images.LoadImage(player.Name)));
            }
        }

        internal Player GetData()
        {
            return Player;
        }
    }
}
