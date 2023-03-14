using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
using System.IO;

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
            string description = string.Empty; ;
            string cover = string.Empty;
            string source = "Amuse\\storage";

            string query = $"SELECT cover,users.username,description FROM `games` INNER JOIN users on creator = users.id WHERE title = \"{title}\";";
            MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                cover = mySqlDataReader.GetString(0);
                creator = mySqlDataReader.GetString(1);
                description = mySqlDataReader.GetString(2);

            }
            connection.Close();

            gametitle.Content = title;

            string[] words = description.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = 0;
            foreach (string word in words) {
                gamedescription.Content += word + " ";
                wordCount++;
                if (wordCount > 7)
                {
                    gamedescription.Content += Environment.NewLine;
                    wordCount = 0;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
            //start game | játék indítása
        {
            string pathToExe = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Amuse", "storage", "Minecraft.exe");
            try
            {
                // Call a Win32 API function
                Process.Start(pathToExe);
            }
            catch (Win32Exception ex)
            {
                // Handle the exception
                MessageBox.Show("Win32 error occurred:"+ ex.Message);
            }

        }
    }
}
