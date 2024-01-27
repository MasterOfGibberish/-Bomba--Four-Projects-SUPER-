using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Media;
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
using System.Windows.Threading;

namespace Bomba
{
    /// <summary>
    /// Interaction logic for Piano.xaml
    /// </summary>
   
    public partial class Piano : Window
    {
        static List<int> IrasytaMuzika = new List<int>();

        public static Piano instance;
        public TextBlock vardas;
        SqlConnection sqlBomba = new SqlConnection (@"Data Source =DESKTOP-FGIOSI5\SQLEXPRESS; Initial Catalog = Bomba; Integrated Security=true");
        public Piano()
        {
            InitializeComponent();
           
            instance = this;
            vardas = Vardas;
        }
        private bool isDragging;
        private Point offset;

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDragging = true;
            offset = e.GetPosition(this);
            this.CaptureMouse();
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
            this.ReleaseMouseCapture();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPos = e.GetPosition(this);
                double deltaX = currentPos.X - offset.X;
                double deltaY = currentPos.Y - offset.Y;

                this.Left += deltaX;
                this.Top += deltaY;
            }
        }


        private bool isPlayClicked = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer play = new SoundPlayer(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Bomba\Bomba\Resources\gama\Do.wav");
            play.Load();
            play.Play();

            Button button = (Button)sender;

            if (isPlayClicked)
            {
                if (button.Background.ToString() == "#FFFF0000")
                {
                    // User clicked on the red button
                    play_Click(button, new RoutedEventArgs(Button.ClickEvent));
                }
                else
                {
                    MessageBox.Show("You clicked the wrong button", "WARNING!");
                    dispatcherTimer.Stop();
                    this.Close();
                    Piano piano = new Piano();
                    piano.Show();
                }

            }

            // Change the background color to red
            Do.Background = new SolidColorBrush(Colors.WhiteSmoke);
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SoundPlayer play = new SoundPlayer(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Bomba\Bomba\Resources\gama\Re.wav");
            play.Load();
            play.Play();
            Button button = (Button)sender;

            if (isPlayClicked)
            {
                if(button.Background.ToString() == "#FFFF0000")
                {
                    // User clicked on the red button
                    play_Click(button, new RoutedEventArgs(Button.ClickEvent));
                }
                else 
                {
                    MessageBox.Show("You clicked the wrong button", "WARNING!");
                    dispatcherTimer.Stop();
                    this.Close();
                    Piano piano = new Piano();
                    piano.Show();
                }

            }
            Re.Background = new SolidColorBrush(Colors.WhiteSmoke);
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SoundPlayer play = new SoundPlayer(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Bomba\Bomba\Resources\gama\Mi.wav");
            play.Load();
            play.Play();
            Button button = (Button)sender;
            if (isPlayClicked)
            {
                if (button.Background.ToString() == "#FFFF0000")
                {
                    // User clicked on the red button
                    play_Click(button, new RoutedEventArgs(Button.ClickEvent));
                }
                else
                {
                    MessageBox.Show("You clicked the wrong button", "WARNING!");
                    dispatcherTimer.Stop();
                    this.Close();
                    Piano piano = new Piano();
                    piano.Show();
                }

            }
            // Change the background color to red
            Mi.Background = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SoundPlayer play = new SoundPlayer(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Bomba\Bomba\Resources\gama\Fa.wav");
            play.Load();
            play.Play();
            Button button = (Button)sender;
            if (isPlayClicked)
            {
                if (button.Background.ToString() == "#FFFF0000")
                {
                    // User clicked on the red button
                    play_Click(button, new RoutedEventArgs(Button.ClickEvent));
                }
                else
                {
                    MessageBox.Show("You clicked the wrong button", "WARNING!");
                    dispatcherTimer.Stop();
                    this.Close();
                    Piano piano = new Piano();
                    piano.Show();
                }

            }
            // Change the background color to red
            Fa.Background = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SoundPlayer play = new SoundPlayer(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Bomba\Bomba\Resources\gama\Sol.wav");
            play.Load();
            play.Play();
            Button button = (Button)sender;
            if (isPlayClicked)
            {
                if (button.Background.ToString() == "#FFFF0000")
                {
                    // User clicked on the red button
                    play_Click(button, new RoutedEventArgs(Button.ClickEvent));
                }
                else
                {
                    MessageBox.Show("You clicked the wrong button", "WARNING!");
                    dispatcherTimer.Stop();
                    this.Close();
                    Piano piano = new Piano();
                    piano.Show();
                }

            }
            // Change the background color to red
            Sol.Background = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SoundPlayer play = new SoundPlayer(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Bomba\Bomba\Resources\gama\La.wav");
            play.Load();
            play.Play();
            Button button = (Button)sender;
            if (isPlayClicked)
            {
                if (button.Background.ToString() == "#FFFF0000")
                {
                    // User clicked on the red button
                    play_Click(button, new RoutedEventArgs(Button.ClickEvent));
                }
                else
                {
                    MessageBox.Show("You clicked the wrong button", "WARNING!");
                    dispatcherTimer.Stop();
                    this.Close();
                    Piano piano = new Piano();
                    piano.Show();
                }

            }
            // Change the background color to red
            La.Background = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            SoundPlayer play = new SoundPlayer(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Bomba\Bomba\Resources\gama\Si.wav");
            play.Load();
            play.Play();
            Button button = (Button)sender;
            if (isPlayClicked)
            {
                if (button.Background.ToString() == "#FFFF0000")
                {
                    // User clicked on the red button
                    play_Click(button, new RoutedEventArgs(Button.ClickEvent));
                }
                else
                {
                    MessageBox.Show("You clicked the wrong button", "WARNING!");
                    dispatcherTimer.Stop();
                    this.Close();
                    Piano piano = new Piano();
                    piano.Show();
                }

            }
            // Change the background color to red
            Si.Background = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            SoundPlayer play = new SoundPlayer(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Bomba\Bomba\Resources\gama\Do2.wav");
            play.Load();
            play.Play();
            Button button = (Button)sender;
            if (isPlayClicked)
            {
                if (button.Background.ToString() == "#FFFF0000")
                {
                    // User clicked on the red button
                    play_Click(button, new RoutedEventArgs(Button.ClickEvent));
                }
                else
                {
                    MessageBox.Show("You clicked the wrong button", "WARNING!");
                    dispatcherTimer.Stop();
                    this.Close();
                    Piano piano = new Piano();
                    piano.Show();
                }

            }
            // Change the background color to red
            Do2.Background = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void pirmas_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer play = new SoundPlayer(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Bomba\Bomba\Resources\MuzikosSharpai\Do#.wav");
            play.Load();
            play.Play();
            Button button = (Button)sender;
            if (isPlayClicked)
            {
                if (button.Background.ToString() == "#FFFF0000")
                {
                    // User clicked on the red button
                    play_Click(button, new RoutedEventArgs(Button.ClickEvent));
                }
                else
                {
                    MessageBox.Show("You clicked the wrong button", "WARNING!");
                    dispatcherTimer.Stop();
                    this.Close();
                    Piano piano = new Piano();
                    piano.Show();
                }

            }
            // Change the background color to black
            pirmas.Background = new SolidColorBrush(Colors.Black);
        }

        private void Antras_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer play = new SoundPlayer(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Bomba\Bomba\Resources\MuzikosSharpai\Re#.wav");
            play.Load();
            play.Play();
            Button button = (Button)sender;
            if (isPlayClicked)
            {
                if (button.Background.ToString() == "#FFFF0000")
                {
                    // User clicked on the red button
                    play_Click(button, new RoutedEventArgs(Button.ClickEvent));
                }
                else
                {
                    MessageBox.Show("You clicked the wrong button", "WARNING!");
                    dispatcherTimer.Stop();
                    this.Close();
                    Piano piano = new Piano();
                    piano.Show();
                }

            }
            // Change the background color to black
            Antras.Background = new SolidColorBrush(Colors.Black);
        }

        private void Trecias_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer play = new SoundPlayer(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Bomba\Bomba\Resources\MuzikosSharpai\Fa#.wav");
            play.Load();
            play.Play();
            Button button = (Button)sender;
            if (isPlayClicked)
            {
                if (button.Background.ToString() == "#FFFF0000")
                {
                    // User clicked on the red button
                    play_Click(button, new RoutedEventArgs(Button.ClickEvent));
                }
                else
                {
                    MessageBox.Show("You clicked the wrong button", "WARNING!");
                    dispatcherTimer.Stop();
                    this.Close();
                    Piano piano = new Piano();
                    piano.Show();
                }

            }
            // Change the background color to black
            Trecias.Background = new SolidColorBrush(Colors.Black);

        }

        private void Keturi_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer play = new SoundPlayer(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Bomba\Bomba\Resources\MuzikosSharpai\Sol#.wav");
            play.Load();
            play.Play();
            Button button = (Button)sender;
            if (isPlayClicked)
            {
                if (button.Background.ToString() == "#FFFF0000")
                {
                    // User clicked on the red button
                    play_Click(button, new RoutedEventArgs(Button.ClickEvent));
                }
                else
                {
                    MessageBox.Show("You clicked the wrong button", "WARNING!");
                    dispatcherTimer.Stop();
                    this.Close();
                    Piano piano = new Piano();
                    piano.Show();
                }

            }
            // Change the background color to black
            Keturi.Background = new SolidColorBrush(Colors.Black);
        }

        private void Penki_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer play = new SoundPlayer(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Bomba\Bomba\Resources\MuzikosSharpai\La.#wav.wav");
            play.Load();
            play.Play();
            Button button = (Button)sender;
            if (isPlayClicked)
            {
                if (button.Background.ToString() == "#FFFF0000")
                {
                    // User clicked on the red button
                    play_Click(button, new RoutedEventArgs(Button.ClickEvent));
                }
                else
                {
                    MessageBox.Show("You clicked the wrong button", "WARNING!");
                    dispatcherTimer.Stop();
                    this.Close();
                    Piano piano = new Piano();
                    piano.Show();
                }

            }
            // Change the background color to black
            Penki.Background = new SolidColorBrush(Colors.Black);
        }

        private void migtukas3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void back3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayClicked)
            {
                dispatcherTimer.Stop();
                this.Close();
                Piano piano = new Piano();
                piano.Show();
            }
            else
            {
                MessageBox.Show("Start the game first", "WARNING!");
            }
        }

        private int increment = 5;
        private DispatcherTimer dispatcherTimer;

        public void dispatcherTimerTicker(object sender, EventArgs e)
        {
            increment--;
            Animacija.Content = increment.ToString();
            if (increment == 0)
            {
                this.Close();
                Piano piano = new Piano();
                piano.Show();
                MessageBox.Show("The time ran out!", "WARNING!");
                dispatcherTimer.Stop();
                increment = 10;
            }
        }

        private void ChangeButtonColor(object sender, int randomNumber)
        {

            if (dispatcherTimer != null)
            {
                dispatcherTimer.Stop();
            }

            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Tick += dispatcherTimerTicker;
            dispatcherTimer.Start();

            if (randomNumber == 1)
            {
                Button button = (Button)sender;
                Do.Background = new SolidColorBrush(Colors.Red);
            }

            if (randomNumber == 2)
            {
                Button button = (Button)sender;
                Re.Background = new SolidColorBrush(Colors.Red);
            }

            if (randomNumber == 3)
            {
                Button button = (Button)sender;
                Mi.Background = new SolidColorBrush(Colors.Red);
            }

            if (randomNumber == 4)
            {
                Button button = (Button)sender;
                Fa.Background = new SolidColorBrush(Colors.Red);
            }

            if (randomNumber == 5)
            {
                Button button = (Button)sender;
                Sol.Background = new SolidColorBrush(Colors.Red);
            }

            if (randomNumber == 6)
            {
                Button button = (Button)sender;
                La.Background = new SolidColorBrush(Colors.Red);
            }

            if (randomNumber == 7)
            {
                Button button = (Button)sender;
                Si.Background = new SolidColorBrush(Colors.Red);
            }

            if (randomNumber == 8)
            {
                Button button = (Button)sender;
                Do2.Background = new SolidColorBrush(Colors.Red);
            }

            if (randomNumber == 9)
            {
                Button button = (Button)sender;
                pirmas.Background = new SolidColorBrush(Colors.Red);
            }

            if (randomNumber == 10)
            {
                Button button = (Button)sender;
                Antras.Background = new SolidColorBrush(Colors.Red);
            }

            if (randomNumber == 11)
            {
                Button button = (Button)sender;
                Trecias.Background = new SolidColorBrush(Colors.Red);
            }

            if (randomNumber == 12)
            {
                Button button = (Button)sender;
                Keturi.Background = new SolidColorBrush(Colors.Red);
            }

            if (randomNumber == 13)
            {
                Button button = (Button)sender;
                Penki.Background = new SolidColorBrush(Colors.Red);
            }
        }

        public void play_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 14);
            ChangeButtonColor(sender, randomNumber);
            increment = 5;
            Animacija.Content = increment.ToString();
            isPlayClicked = true;
        }      
    }
}
