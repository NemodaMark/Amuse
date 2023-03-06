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
        public string user { get;  set; }
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                       user = username.Text;
                string userpass = password.Text;

                string DataUser = String.Empty;
                string DataPass = String.Empty;

                string query = $"SELECT `username`,`password` FROM `users` " +
                    $"WHERE `username` = '{user}';";
                MySqlCommand mySqlCommand = new MySqlCommand(query,connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    DataUser = mySqlDataReader.GetString(0);
                    DataPass = mySqlDataReader.GetString(1);
                }
            connection.Close();
                bool HashCheck = BCrypt.Net.BCrypt.Verify(userpass, DataPass);

                if (HashCheck == true)
                {
                MessageBox.Show("You successfully logged in!");
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
