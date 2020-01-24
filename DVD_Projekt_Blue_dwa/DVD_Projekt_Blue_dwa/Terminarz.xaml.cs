using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;
using System.Windows.Forms;

namespace DVD_Projekt_Blue_dwa
{
    /// <summary>
    /// Logika interakcji dla klasy Terminarz.xaml
    /// </summary>
    public partial class Terminarz : Window
    {
        public string id_terminarza;
        public string xdd_id;
        public Terminarz()
        {
            InitializeComponent();
            var path_2 = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\pracownicy_wersja_RODO.db");
            try
            {
                id1_block.Text = File.ReadLines(path_2).Skip(0).Take(1).First();
                id2_block.Text = File.ReadLines(path_2).Skip(1).Take(1).First();
                id3_block.Text = File.ReadLines(path_2).Skip(2).Take(1).First();
                id4_block.Text = File.ReadLines(path_2).Skip(3).Take(1).First();
                id5_block.Text = File.ReadLines(path_2).Skip(4).Take(1).First();
                id6_block.Text = File.ReadLines(path_2).Skip(5).Take(1).First();

            }
            catch (System.InvalidOperationException)
            {

            }
            if (id1_block.Text != "")
            {
                id1_button.IsEnabled = true;
            }
            if (id2_block.Text != "")
            {
                id2_button.IsEnabled = true;
            }
            if (id3_block.Text != "")
            {
                id3_button.IsEnabled = true;
            }
            if (id4_block.Text != "")
            {
                id4_button.IsEnabled = true;
            }
            if (id5_block.Text != "")
            {
                id5_button.IsEnabled = true;
            }
            if (id6_block.Text != "")
            {
                id6_button.IsEnabled = true;
            }
        }

        private void id1_button_Click(object sender, RoutedEventArgs e)
        {
            xdd_id = "@1.";
            this.Close();
        }
        private void id2_button_Click(object sender, RoutedEventArgs e)
        {
            xdd_id = "@2.";
            this.Close();
        }
        private void id3_button_Click(object sender, RoutedEventArgs e)
        {
            xdd_id = "@3.";
            this.Close();
        }
        private void id4_button_Click(object sender, RoutedEventArgs e)
        {
            xdd_id = "@4.";
            this.Close();
        }
        private void id5_button_Click(object sender, RoutedEventArgs e)
        {
            xdd_id = "@5.";
            this.Close();
        }
        private void id6_button_Click(object sender, RoutedEventArgs e)
        {
            xdd_id = "@6.";
            this.Close();
        }

 
    }
}
