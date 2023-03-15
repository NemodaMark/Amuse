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
using System.Runtime.ConstrainedExecution;

namespace Amuse
{
    /// <summary>
    /// Interaction logic for games.xaml
    /// </summary>
    /// 
    public partial class games : Page
    {
        MySqlConnection connection = new MySqlConnection(MainWindow.connectionStr);
        public string pathToExe = string.Empty;
        public int Gameimage = 1;

        public games()
        {

            InitializeComponent();
            string title = MainWindow.clickedGame;
            string creator = string.Empty;
            string description = string.Empty; ;
            string cover = string.Empty;
            Play.IsEnabled = false;

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
            gamecreator.Content = creator;

            string imagePath = @"D:\Vizsgamunka\C#\Amuse\Amuse\Assets\" + cover;
            BitmapImage image = new BitmapImage(new Uri(imagePath));
            Header.Source = image;

            string imagePath2 = @"D:\Vizsgamunka\C#\Amuse\Amuse\Assets\" + Gameimage + ".jpg";
            BitmapImage image2 = new BitmapImage(new Uri(imagePath2));
            currentPics.Source = image2;

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
            try {
                Process.Start(pathToExe);
            }
            catch (Win32Exception ex) { 
                MessageBox.Show("Win32 error occurred:" + ex.Message);
            }

        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog gameSearche = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = gameSearche.ShowDialog();
            if (result == true)
            {
                pathToExe = gameSearche.FileName;
            }
            Play.IsEnabled = true;
        }

        private void nextPictBt_Click(object sender, RoutedEventArgs e)
        {
            if (Gameimage < 3)
            {
                Gameimage++;
                string imagePath = @"D:\Vizsgamunka\C#\Amuse\Amuse\Assets\" +Gameimage +".jpg";
                BitmapImage image = new BitmapImage(new Uri(imagePath));
                currentPics.Source = image;

                prewPicsBt.IsEnabled = true;
            }
            else if (Gameimage == 3)
            {
                nextPictBt.IsEnabled = false;
                prewPicsBt.IsEnabled = true;
            }

        }

        private void prewPicsBt_Click(object sender, RoutedEventArgs e)
        {
            
            if (Gameimage > 1)
            {
                Gameimage--;
                string imagePath = @"D:\Vizsgamunka\C#\Amuse\Amuse\Assets\" + Gameimage + ".jpg";
                BitmapImage image = new BitmapImage(new Uri(imagePath));
                currentPics.Source = image;

                nextPictBt.IsEnabled = true;
            }
            else if (Gameimage == 1)
            {
                prewPicsBt.IsEnabled = false;
                nextPictBt.IsEnabled = true;

            }
        }
    }
}
