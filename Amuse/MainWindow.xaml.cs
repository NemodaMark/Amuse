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

namespace Amuse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string connectionStr = "server=localhost;database=amuse;username=root;port=3306;password=";
        MySqlConnection connection = new MySqlConnection(connectionStr);
        List<string> gameTitle = new List<string>();
        List<string> strings = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            DateTime dateTime = DateTime.MinValue;
            int newest = 0;
            
            connection.Open();
            string libary = $"SELECT `id`,`title`,`added` FROM `games`;";
            MySqlCommand libaryCmd = new MySqlCommand(libary, connection);
            MySqlDataReader libaryRdr = libaryCmd.ExecuteReader();
            while (libaryRdr.Read())
            {
                gameTitle.Add(libaryRdr[1].ToString());
                if (dateTime == DateTime.MinValue || dateTime <= DateTime.Parse(libaryRdr[2].ToString()))
                {
                dateTime = DateTime.Parse(libaryRdr[2].ToString());
                    newest = int.Parse(libaryRdr[0].ToString());
                }
            }
            libaryRdr.Close();

            string New = $"SELECT `title` FROM `games` where `id` = {newest};";
            MySqlCommand NewCmd = new MySqlCommand(New, connection);
            MySqlDataReader NewRdr = NewCmd.ExecuteReader();
                NewRdr.Read();
                 string mystring = NewRdr[0].ToString();
                NewRdr.Close();

                foreach (var item in gameTitle)
            { 
                    RadioButton radio = new RadioButton();
                    radio.Name = "game";
                    radio.Content = item.ToString();
                myLibary.Children.Add(radio);
                Grid.SetColumn(myLibary, 1);
                Grid.SetRow(myLibary, 5);
                if (item == mystring)
                {
                    RadioButton radioHit = new RadioButton();
                    radioHit.Name = "gameHit";
                    radioHit.Content = item.ToString();
                    nowHot.Children.Add(radioHit);
                    Grid.SetColumn(nowHot, 0);
                    Grid.SetRow(nowHot, 0);
                }
            }

            connection.Close();
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

        // Using a DependencyProperty as the backing store for IsMenuExpanded.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsMenuExpandedProperty =
            DependencyProperty.Register("IsMenuExpanded", typeof(bool), typeof(MainWindow));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
