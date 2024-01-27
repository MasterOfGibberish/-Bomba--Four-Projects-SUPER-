using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Threading;

namespace Bomba
{
    /// <summary>
    /// Interaction logic for Balionai.xaml
    /// </summary>
    public partial class Balionai : Window
    {

        string sqlConnection = (@"Data Source =DESKTOP-FGIOSI5\SQLEXPRESS; Initial Catalog = Biblioteka; Integrated Security=true");
        DispatcherTimer gameTimer = new DispatcherTimer();

        int speed = 3;
        int intervals = 90;
        Random rand = new Random();

        List<Rectangle> itemRemover = new List<Rectangle>();

        ImageBrush backgroundImage = new ImageBrush();

        int balloonSkins;
        int i;

        int missedBalloons;

        bool gameIsActive;

        int score;

        MediaPlayer player = new MediaPlayer();
        
        public Balionai()
        {
            InitializeComponent();
            gameTimer.Tick += GameEngine;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);

            backgroundImage.ImageSource = new BitmapImage(new Uri(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Three-projects-in-one\Bomba\Resources\balionai\360_F_287871802_GrrmM4RgBQt7hfIPYFTkRqaj2Fb8xvY4.jpg"));
            MyCanvas.Background = backgroundImage;
            RestartGame();

        }
        private void GameEngine(object sender, EventArgs e)
        {
            scoreText.Text = "Score: " + score;
            int ikiKiek = 999999;
            for (int i = 1; i < ikiKiek; i++)
            {
                int b = i * 100;
                if (score == b)
                {
                    speed = 3 + i;
                }
            }

            intervals -= 10;

            if (score == 200)
            {
                backgroundImage.ImageSource = new BitmapImage
                    (new Uri(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Three-projects-in-one\Bomba\Resources\balionai\abstract-grunge-decorative-relief-navy-blue-stucco-wall-texture-wide-angle-rough-colored-background_1258-28311.jpg"));
                MyCanvas.Background = backgroundImage;
            }

            if (intervals < 1)
            {
                ImageBrush balloonImage = new ImageBrush();

                balloonSkins += 1;

                if (balloonSkins > 5)
                {
                    balloonSkins = 1;
                }

                switch (balloonSkins)
                {
                    case 1:
                        balloonImage.ImageSource = new BitmapImage(new Uri(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Three-projects-in-one\Bomba\Resources\balionai\ballons.png"));
                        break;
                    case 2:
                        balloonImage.ImageSource = new BitmapImage(new Uri(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Three-projects-in-one\Bomba\Resources\balionai\balloon (1).png"));
                        break;
                    case 3:
                        balloonImage.ImageSource = new BitmapImage(new Uri(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Three-projects-in-one\Bomba\Resources\balionai\balloon (2).png"));
                        break;
                    case 4:
                        balloonImage.ImageSource = new BitmapImage(new Uri(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Three-projects-in-one\Bomba\Resources\balionai\balloon (3).png"));
                        break;
                    case 5:
                        balloonImage.ImageSource = new BitmapImage(new Uri(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Three-projects-in-one\Bomba\Resources\balionai\balloon.png"));
                        break;
                }

                Rectangle newBalloon = new Rectangle
                {
                    Tag = "balloon",
                    Height = 70,
                    Width = 50,
                    Fill = balloonImage
                };

                Canvas.SetLeft(newBalloon, rand.Next(50, 400));
                Canvas.SetTop(newBalloon, 600);

                MyCanvas.Children.Add(newBalloon);

                intervals = rand.Next(90, 150);
            }

            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {

                if ((string)x.Tag == "balloon")
                {

                    i = rand.Next(-5, 5);

                    Canvas.SetTop(x, Canvas.GetTop(x) - speed);
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - (i * -1));

                }

                if (Canvas.GetTop(x) < 20)
                {
                    itemRemover.Add(x);

                    missedBalloons += 1;
                }
            }


            foreach (Rectangle y in itemRemover)
            {
                MyCanvas.Children.Remove(y);
            }

            if (missedBalloons > 10)
            {
                using (SqlConnection RegistrationCon = new SqlConnection(sqlConnection))
                {
                    SqlCommand command = new SqlCommand("UserAdd", RegistrationCon);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Results", scoreText.Text.Trim());

                    gameIsActive = false;
                    gameTimer.Stop();
                    MessageBox.Show("Game over MR./MS.!! You missed 10 Balloons" + Environment.NewLine + "Open it again to play again", "OHHH...");
                }
            }
            if (score == 1000)
            {
                speed = 50;
            }

            if (score > 100)
            {
                speed = 7;
            }
        }

        private void PopBalloons(object sender, MouseButtonEventArgs e)
        {
            if (gameIsActive)
            {

                if (e.OriginalSource is Rectangle)
                {

                    Rectangle activeRec = (Rectangle)e.OriginalSource;

                    player.Open
                        (new Uri(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Three-projects-in-one\Bomba\Resources\balionai\Balloon Pop Sound Effect.mp3", UriKind.RelativeOrAbsolute));
                    player.Play();

                    MyCanvas.Children.Remove(activeRec);

                    score += 10;
                }
            }
        }

        private void StartGame()
        {
            gameTimer.Start();
            backgroundImage.ImageSource = new BitmapImage
                (new Uri(@"C:\Users\Namai\OneDrive\Desktop\wpf\WpfApp3\Three-projects-in-one\Bomba\Resources\balionai\pngtree-game-red-outer-space-image_2408904.jpg"));
            MyCanvas.Background = backgroundImage;
            missedBalloons = 0;
            score = 0;
            intervals = 90;
            gameIsActive = true;
            speed = 3;
        }

        private void RestartGame()
        {
            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {
                itemRemover.Add(x);
            }

            foreach (Rectangle y in itemRemover)
            {
                MyCanvas.Children.Remove(y);
            }

            itemRemover.Clear();

            StartGame();

        }
    }
}
