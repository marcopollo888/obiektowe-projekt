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

        void aktualizacja_id()
        {
            var path = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\pracownicy.db");
            int i = 1;
            int licznik = 0;
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
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {

            var path = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\pracownicy.db");
            var path_2 = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\pracownicy_wersja_RODO.db");

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
                    File.AppendAllText(path_2, Imię.Text + "; " + Nickname.Text + "; " + Dywizja.Text + "; " + Mail.Text + newLine);
                    MessageBox.Show("Dodano nowego pracownika.");
                    Imię.Text = null;
                    Nazwisko.Text = null;
                    Nickname.Text = null;
                    Mail.Text = null;
                    Telefon.Text = null;
                    Dywizja.Text = null;
                    id_pracownika.Text = null;
                    aktualizacja_id();
                    Odśwież_Click(sender, e);
                    if (File.ReadAllLines(path).Length >= 6)
                    {
                        MessageBox.Show("Uruchamiam pokazywanie zespołu, jednak nabór zostaje wyłączony, ze względu na limit miejsc");
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
            string szukaj = lista_usuwalnych.Text;
            var path = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\pracownicy.db");
            var plik = new List<string>(System.IO.File.ReadAllLines(path));
            for (int i = plik.Count() - 1; i >= 0; i--)
            {
                if (plik[i].Contains(szukaj))
                {
                    plik.RemoveAt(i);
                }
            }
            File.WriteAllLines(path, plik.ToArray());
            aktualizacja_id();
            Odśwież_Click(sender, e);
        }

        private void wracaj_do_pokeball_1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain_Window = new MainWindow();
            objMain_Window.Show();
            this.Close();
        }
    }
}
