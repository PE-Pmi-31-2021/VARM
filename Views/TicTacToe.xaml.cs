using System;
using System.Collections.Generic;
using System.Linq;
using NLog;
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
using LNU_VARM_games;

namespace VARM_games_TEST.Views
{
    /// <summary>
    /// Interaction logic for TicTacToe.xaml
    /// </summary>
    public partial class TicTacToe : Page
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private bool isX = false;

        int[] filledGrid = new int[9]; //0 -> Unfilled, 1 -> O, 2 -> X
        int alreadyFilled = 0;
        int[] magicSquare =    //Sum of 3-in-line is always 15
        {
         8, 1, 6,
         3, 5, 7,
         4, 9, 2
        };

        public TicTacToe()
        {
            InitializeComponent();
            GameOverGrid.Visibility = Visibility.Hidden; //Hide GameOver Grid
            logger.Debug("TicTacToe started");
        }

        private void CheckIfAnyoneWin()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    for (int k = 0; k < 9; k++)
                        if (i != j && i != k && j != k)
                            if (filledGrid[i] == (isX ? 2 : 1) && filledGrid[j] == (isX ? 2 : 1) && filledGrid[k] == (isX ? 2 : 1))
                                if (magicSquare[i] + magicSquare[j] + magicSquare[k] == 15)
                                    EndGame(isX ? 2 : 1);
        }

        private void EndGame(int state) //stage: 0 -> Draw, 1 -> O win, 2 -> X win
        {
            GameGrid.Visibility = Visibility.Hidden; //Hide Game Grid
            GameOverGrid.Visibility = Visibility.Visible; //Show GameOver Grid
            WhosWin.Text = (state == 0) ? "Draw" : ("Winner is: " + ((state == 1) ? "O" : "X"));
            logger.Debug("TicTacToe session ended successfully");
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            int buttonIndex = Convert.ToInt32(((Button)sender).Tag.ToString().Last().ToString());
            TextBlock textBlock = (TextBlock)FindName("T_" + buttonIndex.ToString());
            if (filledGrid[buttonIndex - 1] == 0) //if not already clicked
            {
                filledGrid[buttonIndex - 1] = (isX) ? 2 : 1;
                textBlock.Text = (isX) ? "X" : "O";
                whosRound.Text = "Player round: " + textBlock.Text;
                alreadyFilled++; //If all 9 blocks filled -> end game

                CheckIfAnyoneWin();
                if (alreadyFilled >= 9)
                    EndGame(0); //Draw

                isX = !isX;
            }
        }

        private void ExitGame(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
            MainPage g = new MainPage();
            this.NavigationService.Navigate(g);
            logger.Debug("TicTacToe to MainPage");
        }

        private void RestartGame(object sender, RoutedEventArgs e)
        {
            isX = false;
            filledGrid = new int[9]; //0 -> Unfilled, 1 -> O, 2 -> X
            alreadyFilled = 0;

            //Clear buttons textBlocks
            for (int i = 0; i < 9; i++)
            {
                ((TextBlock)FindName("T_" + (i + 1).ToString())).Text = "";
            }

            //Change Grids visibility
            GameGrid.Visibility = Visibility.Visible; //Show Game Grid
            GameOverGrid.Visibility = Visibility.Hidden; //Hide GameOver Grid
            logger.Debug("TicTacToe restarted");
        }
    }
}
