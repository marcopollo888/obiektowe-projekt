using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace DVD_Projekt_Blue_dwa
{
    /// <summary>
    /// Logika interakcji dla klasy Logowanie.xaml
    /// </summary>
    public partial class Logowanie : Window
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void zaloguj_Click(object sender, RoutedEventArgs e)
        {
            
            if(login.Text == "alfa" && hasełko.Text == "dystrybuanta")
            {
                MainWindow objMain_Window = new MainWindow();
                objMain_Window.Show();
                this.Close();
            }
        }
        
    }
}
