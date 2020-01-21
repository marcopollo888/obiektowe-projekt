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
using System.Linq;

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

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            int i = 1;
            int licznik = 0;
            var path = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\pracownicy.db");
            var path_2 = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\pracownicy_bez_wrażliwych_danych.db");

            if ( Imię.Text == "" || Nazwisko.Text == "" || Nickname.Text == "" || Mail.Text == "" || Telefon.Text == "" || Dywizja.Text == "")
            {
                MessageBox.Show("Wymagane jest podanie wszystkich danych");
            }
            else
            {
                if (File.ReadAllLines(path).Length >= 7)
                {
                    MessageBox.Show("Po analizie rynku przeprowadzonej przez spółkę, oszacowaliśmy, że zwiększenie liczby pracowników powyżej 6 wprowadzi negatywną atmosferę wśród załogi");
                }
                else
                {
                    string newLine = Environment.NewLine;
                    File.AppendAllText(path, id_pracownika.Text +"; " + Imię.Text + "; " + Nazwisko.Text + "; " + Nickname.Text + "; " + Dywizja.Text + "; " + Mail.Text + "; " + Telefon.Text + newLine);
                    File.AppendAllText(path_2, id_pracownika.Text + "; " + Nickname.Text + "; " + Dywizja.Text + newLine);
                    MessageBox.Show("Dodano nowego pracownika.");
                    Imię.Text = null;
                    Nazwisko.Text = null;
                    Nickname.Text = null;
                    Mail.Text = null;
                    Telefon.Text = null;
                    Dywizja.Text = null;

                    do
                    {
                        string poszukiwane_id = "@" + i + ".";
                        if (!File.ReadAllText(path).Contains(poszukiwane_id))
                        {
                            id_pracownika.Text = poszukiwane_id;
                            licznik++;
                        }
                        i++;
                    } while (i != 7 && licznik != 1);
                    if (File.ReadAllLines(path).Length >= 6)
                    {
                        MessageBox.Show("Uruchamiam pokazywanie zespołu, jednak nabór zostaje wyłączony, ze względu na limit miejsc");
                        id_pracownika = null;
                    }

                }

            }
        }

        private void Odśwież_Click(object sender, RoutedEventArgs e)
        {
            var path = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\pracownicy.db");
            Wyświetlenie_pracowników.Text = null;
            Wyświetlenie_pracowników.Text = File.ReadAllText(path);
        }

        private void usuń_pracownika_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
