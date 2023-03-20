using MySql.Data.MySqlClient;
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

namespace Amuse
{
    /// <summary>
    /// Interaction logic for user.xaml
    /// </summary>
    public partial class user : Page
    {
        MySqlConnection connection = new MySqlConnection(MainWindow.connectionStr);
        static int balance = 0;

        public user()
        {
            InitializeComponent();
            Username.Content = Login.user;
            string query = $"SELECT `email`,`roleName`,`balance` FROM `users` INNER JOIN roles ON role = roles.id WHERE username = '{Login.user}';';";
            MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            { 
                userEmail.Content = mySqlDataReader.GetString(0);
                userRole.Content = mySqlDataReader.GetString(1);
                if (mySqlDataReader.GetString(2) != null)
                    userBalance.Content = int.Parse(mySqlDataReader.GetString(2));
            }
            
        }

        private void userBt_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Close();
            
            Login login = new Login();
            login.Show();

        }

        private void deposit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
