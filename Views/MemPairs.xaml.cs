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
using System.Diagnostics;

namespace VARM_games_TEST.Views
{
    /// <summary>
    /// Interaction logic for MemPairs.xaml
    /// </summary>
    public partial class MemPairs : Page
    {
        public int counter = 0;
        public int value = 0;
        Stopwatch s = new Stopwatch();


        public MemPairs()
        {
            InitializeComponent();


            List<int> pairs = new List<int>(); // {0, 0, 1, 1, 2, 2, 3, 3, 4, 4}
            int colums = PairsGrid.ColumnDefinitions.Count;
            int rows = PairsGrid.RowDefinitions.Count;
            for (int i = 0; i < (colums * rows) / 2; i++)
            {
                pairs.Add(i);
                pairs.Add(i);
            }

            List<Label> labels = new List<Label>() { t00, t10, t20, t30, t40, t01, t11, t21, t31, t41 };
            Random rand = new Random();

            foreach (var item in labels)
            {
                int indx = rand.Next(0, pairs.Count);

                item.Content = pairs[indx];

                pairs.RemoveAt(indx);
            }

            s.Start();
            Timer.Content = s.Elapsed;
            //Grid DynamicGrid = new Grid();
            //DynamicGrid.RowDefinitions.Add(new RowDefinition());
            //DynamicGrid.RowDefinitions.Add(new RowDefinition());
            //DynamicGrid.ColumnDefinitions.Add(new ColumnDefinition());
            //DynamicGrid.ColumnDefinitions.Add(new ColumnDefinition());
            //DynamicGrid.ColumnDefinitions.Add(new ColumnDefinition());
            //DynamicGrid.ColumnDefinitions.Add(new ColumnDefinition());
            //DynamicGrid.ColumnDefinitions.Add(new ColumnDefinition());

            //DynamicGrid.Width = this.Width;
            //DynamicGrid.Height = 200;

            //DynamicGrid.HorizontalAlignment = HorizontalAlignment.Center;
            //DynamicGrid.VerticalAlignment = VerticalAlignment.Center;

            //DynamicGrid.Background = new SolidColorBrush(Colors.LightSteelBlue);
            //DynamicGrid.ShowGridLines = true;



            //Rectangle rec = new Rectangle();
            //rec.Fill = new SolidColorBrush(Colors.Yellow);
            //rec.Stroke = new SolidColorBrush(Colors.Black);

            //rec.Width = 100;
            //rec.Height = 100;

            //rec.HorizontalAlignment = HorizontalAlignment.Center;
            //rec.VerticalAlignment = VerticalAlignment.Center;

            //DynamicGrid.Children.Add(rec);

            //this.Content = DynamicGrid;
        }

        private void ClearRectangles()
        {
            t00.Visibility = Visibility.Collapsed;
            t10.Visibility = Visibility.Collapsed;
            t20.Visibility = Visibility.Collapsed;
            t30.Visibility = Visibility.Collapsed;
            t40.Visibility = Visibility.Collapsed;

            t01.Visibility = Visibility.Collapsed;
            t11.Visibility = Visibility.Collapsed;
            t21.Visibility = Visibility.Collapsed;
            t31.Visibility = Visibility.Collapsed;
            t41.Visibility = Visibility.Collapsed;

            if (r00.Fill == Brushes.LightGreen) r00.Visibility = Visibility.Hidden;
            if (r10.Fill == Brushes.LightGreen) r10.Visibility = Visibility.Hidden;
            if (r20.Fill == Brushes.LightGreen) r20.Visibility = Visibility.Hidden;
            if (r30.Fill == Brushes.LightGreen) r30.Visibility = Visibility.Hidden;
            if (r40.Fill == Brushes.LightGreen) r40.Visibility = Visibility.Hidden;

            if (r01.Fill == Brushes.LightGreen) r01.Visibility = Visibility.Hidden;
            if (r11.Fill == Brushes.LightGreen) r11.Visibility = Visibility.Hidden;
            if (r21.Fill == Brushes.LightGreen) r21.Visibility = Visibility.Hidden;
            if (r31.Fill == Brushes.LightGreen) r31.Visibility = Visibility.Hidden;
            if (r41.Fill == Brushes.LightGreen) r41.Visibility = Visibility.Hidden;


            r00.Fill = new SolidColorBrush(Color.FromRgb(255, 170, 85));
            r10.Fill = new SolidColorBrush(Color.FromRgb(255, 170, 85));
            r20.Fill = new SolidColorBrush(Color.FromRgb(255, 170, 85));
            r30.Fill = new SolidColorBrush(Color.FromRgb(255, 170, 85));
            r40.Fill = new SolidColorBrush(Color.FromRgb(255, 170, 85));

            r01.Fill = new SolidColorBrush(Color.FromRgb(255, 170, 85));
            r11.Fill = new SolidColorBrush(Color.FromRgb(255, 170, 85));
            r21.Fill = new SolidColorBrush(Color.FromRgb(255, 170, 85));
            r31.Fill = new SolidColorBrush(Color.FromRgb(255, 170, 85));
            r41.Fill = new SolidColorBrush(Color.FromRgb(255, 170, 85));
            value = -1;
            counter = 0;
        }


        private void check(Rectangle rec, Label lab)
        {
            Timer.Content = s.Elapsed;
            List<Label> labels = new List<Label>() { t00, t10, t20, t30, t40, t01, t11, t21, t31, t41 };
            List<Rectangle> rects = new List<Rectangle>() { r00, r10, r20, r30, r40, r01, r11, r21, r31, r41 };
            for (int i = 0; i < rects.Count; i++)
            {
                if (rects[i].Fill == rec.Fill && rects[i].Name != rec.Name)
                {
                    if (labels[i].Content.Equals(lab.Content))
                    {
                        rects[i].Fill = Brushes.LightGreen;
                        rec.Fill = Brushes.LightGreen;
                        counter++;
                        return;
                    }
                    rects[i].Fill = Brushes.LightCoral;
                }
            }
            rec.Fill = Brushes.LightCoral;
            counter++;
            return;
        }


        private void r00_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (counter == 0)
            {
                t00.Visibility = Visibility.Visible;
                r00.Fill = Brushes.LightYellow;
                counter++;
            }
            else if (counter == 1)
            {
                t00.Visibility = Visibility.Visible;
                r00.Fill = Brushes.LightYellow;

                check(r00, t00);

                //List<Label> labels = new List<Label>() { t10, t20, t30, t40, t01, t11, t21, t31, t41 };
                //List<Rectangle> rects = new List<Rectangle>() { r10, r20, r30, r40, r01, r11, r21, r31, r41 };
                //for (int i = 0; i < rects.Count; i++)
                //{
                //    if (rects[i].Fill == r00.Fill)
                //    {
                //        if (labels[i].Content.Equals(t00.Content))
                //        {
                //            rects[i].Fill = Brushes.LightGreen;
                //            r00.Fill = Brushes.LightGreen;
                //            t00.Visibility = Visibility.Visible;
                //            counter++;
                //            return;
                //        }
                //    }
                //}
                //counter++;
            }
            else
            {
                ClearRectangles();
            }
        }

        private void r10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (counter == 0)
            {
                t10.Visibility = Visibility.Visible;
                r10.Fill = Brushes.LightYellow;
                counter++;
            }
            else if (counter == 1)
            {
                t10.Visibility = Visibility.Visible;
                r10.Fill = Brushes.LightYellow;
                check(r10, t10);
            }
            else
            {
                ClearRectangles();
            }
        }

        private void r20_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (counter == 0)
            {
                t20.Visibility = Visibility.Visible;
                r20.Fill = Brushes.LightYellow;
                counter++;
            }
            else if (counter == 1)
            {
                t20.Visibility = Visibility.Visible;
                r20.Fill = Brushes.LightYellow;
                check(r20, t20);
            }
            else
            {
                ClearRectangles();
            }
        }

        private void r30_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (counter == 0)
            {
                t30.Visibility = Visibility.Visible;
                r30.Fill = Brushes.LightYellow;
                counter++;
            }
            else if (counter == 1)
            {
                t30.Visibility = Visibility.Visible;
                r30.Fill = Brushes.LightYellow;
                check(r30, t30);
            }
            else
            {
                ClearRectangles();
            }
        }

        private void r40_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (counter == 0)
            {
                t40.Visibility = Visibility.Visible;
                r40.Fill = Brushes.LightYellow;
                counter++;
            }
            else if (counter == 1)
            {
                t40.Visibility = Visibility.Visible;
                r40.Fill = Brushes.LightYellow;
                check(r40, t40);
            }
            else
            {
                ClearRectangles();
            }
        }



        private void r01_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (counter == 0)
            {
                t01.Visibility = Visibility.Visible;
                r01.Fill = Brushes.LightYellow;
                counter++;
            }
            else if (counter == 1)
            {
                t01.Visibility = Visibility.Visible;
                r01.Fill = Brushes.LightYellow;
                check(r01, t01);
            }
            else
            {
                ClearRectangles();
            }
        }

        private void r11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (counter == 0)
            {
                t11.Visibility = Visibility.Visible;
                r11.Fill = Brushes.LightYellow;
                counter++;
            }
            else if (counter == 1)
            {
                t11.Visibility = Visibility.Visible;
                r11.Fill = Brushes.LightYellow;
                check(r11, t11);
            }
            else
            {
                ClearRectangles();
            }
        }

        private void r21_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (counter == 0)
            {
                t21.Visibility = Visibility.Visible;
                r21.Fill = Brushes.LightYellow;
                counter++;
            }
            else if (counter == 1)
            {
                t21.Visibility = Visibility.Visible;
                r21.Fill = Brushes.LightYellow;
                check(r21, t21);
            }
            else
            {
                ClearRectangles();
            }
        }

        private void r31_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (counter == 0)
            {
                t31.Visibility = Visibility.Visible;
                r31.Fill = Brushes.LightYellow;
                counter++;
            }
            else if (counter == 1)
            {
                t31.Visibility = Visibility.Visible;
                r31.Fill = Brushes.LightYellow;
                check(r31, t31);
            }
            else
            {
                ClearRectangles();
            }
        }

        private void r41_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (counter == 0)
            {
                t41.Visibility = Visibility.Visible;
                r41.Fill = Brushes.LightYellow;
                counter++;
            }
            else if (counter == 1)
            {
                t41.Visibility = Visibility.Visible;
                r41.Fill = Brushes.LightYellow;
                check(r41, t41);
            }
            else
            {
                ClearRectangles();
            }
        }


    }
}
