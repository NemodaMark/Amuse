using System;
using System.Collections.Generic;
using System.IO.Pipes;
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
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.InteropServices;

namespace Amuse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // todo: Ezt javítsd ki - (kréta) :D 
        static string connectionStr = "server=localhost;database=amuse;username=root;port=3306;password=";
        MySqlConnection connection = new MySqlConnection(connectionStr);

        public string ReceivedData { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            #region recent game
            // A legutolsó hozzáadott játék | the latest game added

            string recentQuery = $"SELECT title FROM `games` ORDER BY `games`.`added`  DESC  LIMIT 1;";
            MySqlCommand recentCommand;
            MySqlDataReader recentDataReader;
            RadioButton recentRadioButton = new RadioButton();

            connection.Open();
                recentCommand = new MySqlCommand(recentQuery, connection);
                recentDataReader = recentCommand.ExecuteReader();
                    while (recentDataReader.Read())
                    {
                        recentRadioButton.Name = "recent";
                        recentRadioButton.Content = recentDataReader[0].ToString();
                        recentRelease.Children.Add(recentRadioButton);
                        Grid.SetColumn(recentRelease, 0);
                        Grid.SetRow(recentRelease, 0);
                    }
            connection.Close();
            #endregion

            #region user libary
            // A felhasználó profilján lévő játékok | games on the user's profile

            int userID = Login.userID;
            string libaryQuery = $"SELECT title FROM `orders` INNER JOIN games on gameID = games.id WHERE userID = '{userID}';";
            List<string> gamesLibary = new List<string>();

            MySqlCommand libaryCommand;
            MySqlDataReader libaryDataReader;

            connection.Open();
                libaryCommand = new MySqlCommand(libaryQuery, connection);
                libaryDataReader = libaryCommand.ExecuteReader();
                    while (libaryDataReader.Read())
                    {
                        RadioButton libaryRadioButton = new RadioButton();
                        libaryRadioButton.Name = "userGame";
                        libaryRadioButton.Content = libaryDataReader[0].ToString();
                        libaryRadioButton.Checked += userGames_Checked;
                        userLibary.Children.Add(libaryRadioButton);
                        Grid.SetColumn(userLibary, 1);
                        Grid.SetRow(userLibary, 5);
                    }
            connection.Close();
            #endregion
        }

        private void home_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }


        private void closeBt_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void restoreBt_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal) WindowState = WindowState.Maximized;
            else WindowState = WindowState.Normal;
        }

        private void minimizeBt_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }


        public bool IsMenuExpanded
        {
            get { return (bool)GetValue(IsMenuExpandedProperty); }
            set { SetValue(IsMenuExpandedProperty, value); }
        }

        public static readonly DependencyProperty IsMenuExpandedProperty =
            DependencyProperty.Register("IsMenuExpanded", typeof(bool), typeof(MainWindow));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void LogoutBt_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show(); this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
            //Store
        {

        }

        private void userGames_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
