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
    /// Logika interakcji dla klasy Archiwum_zleceń.xaml
    /// </summary>
    public partial class Archiwum_zleceń : Window
    {
        public Archiwum_zleceń()
        {
            InitializeComponent();
            var path_z = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\zamówienia.db");
            lista_zleceń.Text = File.ReadAllText(path_z);

        }

        private void wracaj_do_pokeballa_3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain_Window = new MainWindow();
            objMain_Window.Show();
            this.Close();
        }
    }
}
