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

namespace DVD_Projekt_Blue_dwa
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

        }

        private void Imię_Click(object sender, EventArgs e)
        {
            Imię.Text = string.Empty;
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            //File.WriteAllText("C:\\Users\\Marek\\Desktop\\pracownicy.db", Imię.Text + ";" + Nazwisko.Text + ";" + Nickname.Text + ";" + Mail.Text + ";" + Telefon.Text);
        }
    }
}
