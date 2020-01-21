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
    /// Logika interakcji dla klasy Terminarz.xaml
    /// </summary>
    public partial class Terminarz : Window
    {
        int zmienna;
        public Terminarz()
        {
            InitializeComponent();
            kalendarz_id2.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id3.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id4.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id5.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id6.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
        }

        private void przycisk_id1_Click(object sender, RoutedEventArgs e)
        {
            zmienna = 1;
            this.Close();
        }
        /* public void przycisk_id2_Click(object sender, RoutedEventArgs e)
         {
             zmienna = 2;
             this.Close();
         }
         public void przycisk_id3_Click(object sender, RoutedEventArgs e)
         {
             zmienna = 3;
             this.Close();
         }
         public void przycisk_id4_Click(object sender, RoutedEventArgs e)
         {
             zmienna = 4;
             this.Close();
         }
         public void przycisk_id5_Click(object sender, RoutedEventArgs e)
         {
             zmienna = 5;
             this.Close();
         }
         public void przycisk_id6_Click(object sender, RoutedEventArgs e)
         {
             zmienna = 6;
             this.Close();
         }
         */
    }
}
