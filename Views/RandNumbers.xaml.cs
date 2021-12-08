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
using LNU_VARM_games;
using NLog;

namespace VARM_games_TEST.Views
{
    using System;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    public partial class RandNumbers : Page
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private int randnum1 = 1;
        private int randnum2 = 10;
        private int score = 0;
        private int random = 0;
        readonly Random rd = new Random();
        private int mydelay = 1000;

        public RandNumbers()
        {
            InitializeComponent();
        }

        async private void Start_button_click(object sender, RoutedEventArgs e)
        {
            randnum1 = 1;
            randnum2 = 10;
            score = 0;
            Score_block.Text = "Score: " + score;
            mydelay = 1000;
            textBox1.Clear();
            random = rd.Next(randnum1, randnum2);
            Status_block.Text = Convert.ToString(random);
            textBox1.IsEnabled = false;
            await Task.Delay(mydelay);
            textBox1.IsEnabled = true;
            Keyboard.Focus(textBox1);
            Status_block.Text = "Put your answer here";
            Start_button_numb.IsEnabled = false;
            logger.Debug("Randnumbers started");
        }

        async private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int us_input = Convert.ToInt32(textBox1.Text);
                if (us_input == random)
                {
                    randnum1 *= 10;
                    randnum2 *= 10;
                    score += 1;
                    mydelay += 150;
                    random = rd.Next(randnum1, randnum2);
                    textBox1.Clear();
                    Status_block.Text = Convert.ToString(random);
                    Score_block.Text = "Score: " + score;
                    textBox1.IsEnabled = false;
                    await Task.Delay(2000);
                    textBox1.IsEnabled = true;
                    Keyboard.Focus(textBox1);
                    Status_block.Text = "Put your answer here";
                }
                else
                {
                    Status_block.Text = "Mistake! " + random;
                    textBox1.IsEnabled = false;
                    Start_button_numb.IsEnabled = true;

                }
            }
        }

        private void Home_click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
            logger.Debug("Randnumbers to MainPage");
        }
    }
}
