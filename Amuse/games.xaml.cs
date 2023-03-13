using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for games.xaml
    /// </summary>
    /// 
    public partial class games : Page
    {
        MySqlConnection connection = new MySqlConnection(MainWindow.connectionStr);

        public games()
        {

            InitializeComponent();
            string title = MainWindow.clickedGame;
            string creator = string.Empty;
            string cover = string.Empty;
            string query = $"SELECT title,cover FROM `games` WHERE title = \"{title}\";";
            MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            { 
                creator = mySqlDataReader.GetString(0);
                cover = mySqlDataReader.GetString(1);
            }
            connection.Close();

            gametitle.Content = title;
            gamecreator.Content = creator;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
