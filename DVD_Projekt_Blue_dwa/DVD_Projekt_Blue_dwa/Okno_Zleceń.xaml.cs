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
using System.Windows.Forms;

namespace DVD_Projekt_Blue_dwa
{
    /// <summary>
    /// Logika interakcji dla klasy Okno_Zleceń.xaml
    /// </summary>
    public partial class Okno_Zleceń : Window
    { 
        double dywizja_żelazo = 1.5;
        double dywizja_brąz = 2;
        double dywizja_srebro = 2.5;
        double dywizja_złoto = 3;
        double dywizja_platyna = 4;
        double dywizja_diament = 5;
        double dywizja_mistrz = 10;
        double dywizja_arcymistrz = 15;
        double kwota_końcowa;
        double kwota_początkowa;
        double kwota_od_zera;
        double przelicznik;
        public Okno_Zleceń()
        {
            InitializeComponent();

        }

        private void I_Checked(object sender, RoutedEventArgs e)
        {
            if (I.IsChecked == true)
            {
                II.IsChecked = false;
                III.IsChecked = false;
                IV.IsChecked = false;
            }
        }

        private void II_Checked(object sender, RoutedEventArgs e)
        {
            if (II.IsChecked == true)
            {
                I.IsChecked = false;
                III.IsChecked = false;
                IV.IsChecked = false;
            }
        }

        private void III_Checked(object sender, RoutedEventArgs e)
        {
            if (III.IsChecked == true)
            {
                I.IsChecked = false;
                II.IsChecked = false;
                IV.IsChecked = false;
            }
        }

        private void IV_Checked(object sender, RoutedEventArgs e)
        {
            if (IV.IsChecked == true)
            {
                I.IsChecked = false;
                II.IsChecked = false;
                III.IsChecked = false;
            }
        }


        private void dywizja_aktualna_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lp_za_grę.Text == "minimalnie 16")
            {
                przelicznik = 1.5;
                if (dywizja_aktualna.Text == "Złoto")
                {
                    kwota_początkowa = (7 * dywizja_srebro + 7 * dywizja_brąz + 7 * dywizja_żelazo) * przelicznik;
                }
            }
        }
        private void dywizja_oczekiwana_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lp_za_grę.Text == "minimalnie 16")
            {
                przelicznik = 1.5;
                if (dywizja_oczekiwana.Text == "Pretendent")
                {
                    kwota_od_zera = (12 * dywizja_arcymistrz + 10 * dywizja_mistrz + 7 * dywizja_diament + 7 * dywizja_platyna + 7 * dywizja_złoto + 7 * dywizja_srebro + 7 * dywizja_brąz + 7 * dywizja_żelazo) * przelicznik;
                    kwota_końcowa = kwota_od_zera - kwota_początkowa;
                    przewidywana_cena.Text = Convert.ToString(kwota_końcowa);
                }
            }

        }

        private void wybierz_termin_Click(object sender, RoutedEventArgs e)
        {
            Terminarz objTerminarz = new Terminarz();
            objTerminarz.Show();
           // if(objTerminarz.zmienna == 1)
           // {
          //      kalendarz_zleceń.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
           // }
        }
    }
}

