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

namespace Amuse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string connectionStr = "server=localhost;database=amuse;username=root;port=3306;password=";
        MySqlConnection connection = new MySqlConnection(connectionStr);

        public MainWindow()
        {
            InitializeComponent();
            connection.Open();
            string users = $"SELECT count(*) FROM `games`;";
            MySqlCommand usersCmd = new MySqlCommand(users,connection);
            MySqlDataReader usersRdr = usersCmd.ExecuteReader();
            usersRdr.Read();
            int usersCounted = usersRdr.GetInt32(0);
            usersRdr.Close();
            connection.Close();

            for (int i = 0; i < 5; i++)
            {
                RadioButton radio = new RadioButton();
                radio.Name = "asd2"; 
                radio.Content = usersCounted.ToString();
                asd.Children.Add(radio);
            }
            Grid.SetColumn(asd,1);
            Grid.SetRow(asd,5);

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

    }
}
