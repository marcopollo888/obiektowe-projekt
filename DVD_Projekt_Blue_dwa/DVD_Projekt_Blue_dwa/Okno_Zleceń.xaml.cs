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
using System.Linq;
using System.IO;

namespace DVD_Projekt_Blue_dwa
{
    /// <summary>
    /// Logika interakcji dla klasy Okno_Zleceń.xaml
    /// </summary>
    public partial class Okno_Zleceń : Window
    { 
        double kwota_dywizji;
        double kwota_początkowa;
        double kwota_końcowa;
        string data_zleconka;

        public Okno_Zleceń()
        {
            InitializeComponent();
            wybierz_date_zlecenia.BlackoutDates.Add(new CalendarDateRange(DateTime.Today.AddDays(-500), DateTime.Today));
        }

        private void I_Checked(object sender, RoutedEventArgs e)
        {
            if (I.IsChecked == true)
            {
                II.IsChecked = false;
                III.IsChecked = false;
                dowolny_checkbox.IsChecked = false;
            }
        }

        private void II_Checked(object sender, RoutedEventArgs e)
        {
            if (II.IsChecked == true)
            {
                I.IsChecked = false;
                III.IsChecked = false;
                dowolny_checkbox.IsChecked = false;
            }
        }

        private void III_Checked(object sender, RoutedEventArgs e)
        {
            if (III.IsChecked == true)
            {
                I.IsChecked = false;
                II.IsChecked = false;
                dowolny_checkbox.IsChecked = false;
            }
        }

        private void dowolny_checkbox_Checked(object sender, RoutedEventArgs e)
        {
            if (dowolny_checkbox.IsChecked == true)
            {
                I.IsChecked = false;
                II.IsChecked = false;
                III.IsChecked = false;
            }
        }

        private void wybierz_pracownika_Click(object sender, RoutedEventArgs e)
        {
            Terminarz objTerminarz = new Terminarz();
            objTerminarz.Show();
        }

        private void data_zlecenia_Click(object sender, RoutedEventArgs e)
        {
            data_zleconka = wybierz_date_zlecenia.Text;
            MessageBox.Show("Dodana");
        }

        private void oblicz_Click(object sender, RoutedEventArgs e)
        {
            if (dywizja_aktualna.Text == "Żelazo")
            {
                kwota_początkowa = 38;
            }
            else if (dywizja_aktualna.Text == "Brąz")
            {
                kwota_początkowa = 70;
            }
            else if (dywizja_aktualna.Text == "Srebro")
            {
                kwota_początkowa = 110;
            }
            else if (dywizja_aktualna.Text == "Złoto")
            {
                kwota_początkowa = 170;
            }
            else if (dywizja_aktualna.Text == "Platyna")
            {
                kwota_początkowa = 310;
            }
            else if (dywizja_aktualna.Text == "Diament")
            {
                kwota_początkowa = 460;
            }
            else if (dywizja_aktualna.Text == "Mistrz")
            {
                kwota_początkowa = 710;
            }
            else if (dywizja_aktualna.Text == "Arcymistrz")
            {
                kwota_początkowa = 1237;
            }
            if (dywizja_oczekiwana.Text == "Pretendent")
            {
                kwota_dywizji = 2137;
            }
            else if (dywizja_oczekiwana.Text == "Brąz")
            {
                kwota_dywizji = 70;
            }
            else if (dywizja_oczekiwana.Text == "Srebro")
            {
                kwota_dywizji = 110;
            }
            else if (dywizja_oczekiwana.Text == "Złoto")
            {
                kwota_dywizji = 170;
            }
            else if (dywizja_oczekiwana.Text == "Platyna")
            {
                kwota_dywizji = 310;
            }
            else if (dywizja_oczekiwana.Text == "Diament")
            {
                kwota_dywizji = 460;
            }
            else if (dywizja_oczekiwana.Text == "Mistrz")
            {
                kwota_dywizji = 710;
            }
            else if (dywizja_oczekiwana.Text == "Arcymistrz")
            {
                kwota_dywizji = 1237;
            }
            if((I.IsChecked == false && II.IsChecked == false && III.IsChecked == false && dowolny_checkbox.IsChecked == false) && typ_usługi.Text != "coaching")
            {
                MessageBox.Show("Proszę podać godziny, podczas których pracownik może wejść na konto");
            }
            else
            {
                kwota_końcowa = kwota_dywizji - kwota_początkowa;
                if(typ_usługi.Text == "duoq")
                {
                    kwota_końcowa = kwota_końcowa + 0.4 * kwota_końcowa;
                }
                przewidywana_cena.Text = kwota_końcowa.ToString();
                if (typ_usługi.Text == "coaching")
                {
                    kwota_końcowa = 50;
                    przewidywana_cena.Text = kwota_końcowa.ToString();
                    dywizja_aktualna.Text = null;
                    MessageBox.Show("OK.");
                    przewidywana_cena.Text = null;
                }
                if (kwota_końcowa < 0)
                {
                    MessageBox.Show("Dobra Johny, masz tę robotę, bądź jutro na 8 z własnym laptopem (zlecenie ujemne, nie będziemy nikomu dopłacać_");
                    dywizja_aktualna.Text = null;
                    przewidywana_cena.Text = null;
                }
            }
        }

        private void potwierdzam_wybór_Click(object sender, RoutedEventArgs e)
        {

            if (nick_zleceniodawcy.Text == "" || typ_usługi.Text == "" || mail_zleceniodawcy.Text == "" || data_zleconka == null )
            {
                MessageBox.Show("Wymagane jest podanie wszystkich danych");
            }
            else
            {
                if (typ_usługi.Text == "soloq" || typ_usługi.Text == "duoq")
                {
                    dywizja_aktualna.Visibility = Visibility.Visible;
                    dywizja_oczekiwana.Visibility = Visibility.Visible;
                    aktualna_dywizja.Visibility = Visibility.Visible;
                    oczekiwana_dywizja.Visibility = Visibility.Visible;
                    twoja_dywizja.Visibility = Visibility.Hidden;
                    oblicz.Visibility = Visibility.Visible;
                    godzinki.Visibility = Visibility.Visible;
                    I.Visibility = Visibility.Visible;
                    II.Visibility = Visibility.Visible;
                    III.Visibility = Visibility.Visible;
                    dowolny_checkbox.Visibility = Visibility.Visible;
                    przewidywana_cena.Visibility = Visibility.Visible;
                    przewidz_to_ha_ha_ha.Visibility = Visibility.Visible;
                    oblicz.Visibility = Visibility.Visible;
                    zamawiam.Visibility = Visibility.Visible;
                }
                if (typ_usługi.Text == "coaching")
                {
                    dywizja_aktualna.Visibility = Visibility.Visible;
                    dywizja_oczekiwana.Visibility = Visibility.Hidden;
                    aktualna_dywizja.Visibility = Visibility.Hidden;
                    oczekiwana_dywizja.Visibility = Visibility.Hidden;
                    twoja_dywizja.Visibility = Visibility.Visible;
                    oblicz.Visibility = Visibility.Visible;
                    godzinki.Visibility = Visibility.Hidden;
                    I.Visibility = Visibility.Hidden;
                    II.Visibility = Visibility.Hidden;
                    III.Visibility = Visibility.Hidden;
                    dowolny_checkbox.Visibility = Visibility.Hidden;
                    przewidywana_cena.Visibility = Visibility.Visible;
                    przewidz_to_ha_ha_ha.Visibility = Visibility.Visible;
                    oblicz.Visibility = Visibility.Visible;
                    zamawiam.Visibility = Visibility.Visible;
                }
            }
        }

        private void zamawiam_Click(object sender, RoutedEventArgs e)
        {
            string newLine = Environment.NewLine;
            if ((I.IsChecked == false && II.IsChecked == false && III.IsChecked == false && dowolny_checkbox.IsChecked == false ) || dywizja_aktualna.Text == "" || dywizja_oczekiwana.Text == "" || data_zleconka ==  null)
            {
                MessageBox.Show("Wymagane jest podanie wszystkich danych");
            }
            else
            {
                var path_z = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\zamówienia.db");
                File.AppendAllText(path_z, nick_zleceniodawcy.Text + "; " + mail_zleceniodawcy.Text + "; " + typ_usługi.Text + "; " + dywizja_aktualna.Text + "; " + dywizja_oczekiwana.Text + "; " + przewidywana_cena.Text + "; " + data_zleconka + newLine);
                MessageBox.Show("Zamówienie przyjęte");
                nick_zleceniodawcy.Text = null;
                mail_zleceniodawcy.Text = null;
                typ_usługi.Text = null;
                dywizja_aktualna.Text = null;
                dywizja_oczekiwana.Text = null;
                przewidywana_cena.Text = null;
                data_zleconka = null;

            }
        }

        private void wracaj_do_pokeballa_2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain_Window = new MainWindow();
            objMain_Window.Show();
            this.Close();
        }
    }
}

