using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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

namespace Bomba
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        static List<string> PrisijungimuKiekis = new List<string>();

        string connectionString = (@"Data Source =DESKTOP-FGIOSI5\SQLEXPRESS; Initial Catalog = Bomba; Integrated Security=true");
        public static Window1 instance;
        public TextBlock User;
        DataSet ds2 = new DataSet();

        private bool isDragging;
        private Point offset;
        public Window1()
        {
            InitializeComponent();
            instance = this;
            User = usernamui;
            DuomenuIeskojimas();
            ResizeMode = ResizeMode.NoResize;
        }

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

        public void DuomenuIeskojimas()
        {
            using (SqlConnection FindingData = new SqlConnection(connectionString))
            {
                FindingData.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(UserName) FROM tblBomba WHERE UserName = " +
                    "(SELECT UserName FROM tblUser)", FindingData);
                int count = (int)cmd2.ExecuteScalar();
                TavoPrisijungimai.Text = count.ToString();
               
                SqlCommand viso = new SqlCommand("SELECT TOP 1 UserID FROM tblUser ORDER BY UserID DESC", FindingData);
                int count_VISO = (int)viso.ExecuteScalar();
                VisoPrisijungimai.Text = count_VISO.ToString();

                SqlCommand geriausias = new SqlCommand("SELECT UserName FROM tblBomba WHERE GameResults <> 0 " +
                    "GROUP BY UserName HAVING MIN(GameResults) = (SELECT MIN(GameResults) " +
                    "FROM tblBomba WHERE GameResults <> 0)", FindingData);
                string Geriausias = (string)geriausias.ExecuteScalar();
                VisoRezultatai.Text = Geriausias.ToString();

                SqlCommand tavogeriausias = new SqlCommand("SELECT MIN(GameResults) AS LowestScore FROM tblBomba" +
                    " WHERE UserName = (SELECT UserName FROM tblUser) AND GameResults > 0", FindingData);
                int Tavo_Geriausias = (int)tavogeriausias.ExecuteScalar();
                TavoRezultatai.Text = Tavo_Geriausias.ToString();
                FindingData.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Piano piano = new Piano();
            piano.Show();
            Piano.instance.vardas.Text = usernamui.Text;
            if (Piano.instance.vardas.Text== string.Empty)
            {
                string prisijunkite = "Neprisijunges";
                Piano.instance.vardas.Text = prisijunkite;
            }
            
        }

        private void migtukas3_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection userID = new SqlConnection(connectionString))
            {
                if (userID.State == System.Data.ConnectionState.Closed)
                    userID.Open();
                string query = @"DELETE FROM tblUser WHERE UserName='" + usernamui.Text + "'";
                SqlCommand cmd2 = new SqlCommand(query, userID);
                int row = cmd2.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Logout succesfully", "My Box");
                }
            }
            this.Close();
        }
 
        private void Bandom_Click(object sender, RoutedEventArgs e)
        {
            Balionai balionai = new Balionai();
            balionai.Show();
        }

        private void lOGOUT_Click(object sender, RoutedEventArgs e)
        {
           MessageBoxResult messageBoxResult = MessageBox.Show(usernamui.Text + " You Sure Want To Leave?", 
               "My Box", MessageBoxButton.YesNoCancel);
            switch (messageBoxResult)
            {
                case MessageBoxResult.No:
                    MessageBox.Show(usernamui.Text + " Pasirinkai Teisingai", "My Box");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show(usernamui.Text + " Pasirinkai Teisingai", "My Box");
                    break;
                case MessageBoxResult.Yes:
                    MessageBox.Show(usernamui.Text + " Kaip Tu Dristi Palikti Mus?", "My Box");
                    using (SqlConnection userID = new SqlConnection(connectionString))
                    {
                        if (userID.State == System.Data.ConnectionState.Closed)
                            userID.Open();
                        string query = @"DELETE FROM tblUser WHERE UserName='" + usernamui.Text + "'";
                        SqlCommand cmd2 = new SqlCommand(query, userID);
                        int row = cmd2.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Logout succesfully", "My Box");
                        }
                    }
                    LoginScreen loginscreen = new LoginScreen();
                    loginscreen.Show();
                    loginscreen.Focus();
                    this.Close();
                    break;
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            game.Show();
            game.Focus();

            
            Game.instanceGame.VardasPatvirtinimui.Text = usernamui.Text;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Virus virus = new Virus();
            virus.Show();
            virus.Focus();
            //this.Close();

        }
    }
}
