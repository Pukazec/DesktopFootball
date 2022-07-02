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
using System.Windows.Shapes;

namespace WPFFootball
{
    /// <summary>
    /// Interaction logic for PlayerDetails.xaml
    /// </summary>
    public partial class PlayerDetails : Window
    {
        private static IImageRepo images;

        public PlayerDetails(IImageRepo imagesRepo)
        {
            images = imagesRepo;
            InitializeComponent();
        }

        internal void LoadData(Player player, Match match)
        {
            int goals = 0;
            int cards = 0;
            lblName.Content = player.Name;
            lblNumber.Content = player.ShirtNumber;
            if (player.Captain)
            {
                lblIsCapetan.Content = "Yes";
            }
            else
            {
                lblIsCapetan.Content = "No";
            }
            foreach (TeamEvent events in match.HomeTeamEvents)
            {
                if (events.Player == player.Name && events.TypeOfEvent == TeamEvent.TypeOfEventE.Goal)
                {
                    goals++;
                }
                if (events.Player == player.Name && events.TypeOfEvent == TeamEvent.TypeOfEventE.YellowCard)
                {
                    goals++;
                }
            }
            foreach (TeamEvent events in match.AwayTeamEvents)
            {
                if (events.Player == player.Name && events.TypeOfEvent == TeamEvent.TypeOfEventE.Goal)
                {
                    goals++;
                }
                if (events.Player == player.Name && events.TypeOfEvent == TeamEvent.TypeOfEventE.YellowCard)
                {
                    goals++;
                }
            }
            lblGoals.Content = goals;
            lblYellowCards.Content = cards;
            if (images.LoadImage(player.Name) != null)
            {
                imgPlayer.Source = new BitmapImage(new Uri(images.LoadImage(player.Name)));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
