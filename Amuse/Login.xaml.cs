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
using System.Windows.Shapes;
using BC = BCrypt.Net.BCrypt;

namespace Amuse
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        static string connectionStr = "server=localhost;database=amuse;username=root;port=3306;password=";
        MySqlConnection connection = new MySqlConnection(connectionStr);
        public static int userID = 0;

        public static string user { get;  set; }
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                       user = username.Text;
                string userpass = password.Password;

                string DataUser = String.Empty;
                string DataPass = String.Empty;

                string query = $"SELECT `username`,`password`,`id` FROM `users` " +
                    $"WHERE `username` = '{user}';";
                MySqlCommand mySqlCommand = new MySqlCommand(query,connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    DataUser = mySqlDataReader.GetString(0);
                    DataPass = mySqlDataReader.GetString(1);
                    userID = mySqlDataReader.GetInt32(2);
                }
            connection.Close();
                bool HashCheck = BCrypt.Net.BCrypt.Verify(userpass, DataPass);

                if (HashCheck == true)
                {
                    
                    MainWindow main = new MainWindow();
                    main.Show(); this.Close();
                }
                else if (HashCheck == false)
                {
                    MessageBox.Show("Opps! Check your username or password!");
                }
        }

        private void email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
