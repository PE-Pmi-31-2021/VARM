﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace LNU_VARM_games
{
    public partial class Game1 : Page
    {
        public Game1()
        {
            InitializeComponent();
        }

        private void Return_to_main_menu_button_click(object sender, RoutedEventArgs e)
        {

            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }


        

        private void Play_button_click(object sender, RoutedEventArgs e)
        {
            
            RandNumbers gamerand = new RandNumbers();
            this.NavigationService.Navigate(gamerand);
            

        }
    }
}
