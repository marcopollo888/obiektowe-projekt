﻿using System;
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
        public Terminarz()
        {
            InitializeComponent();           
            kalendarz_id1.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id2.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id3.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id4.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id5.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id6.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
        }

        public void przycisk_id1_Click(object sender, RoutedEventArgs e)
        {
            Okno_Zleceń objokno_Zleceń = new Okno_Zleceń();
            objokno_Zleceń.kalendarz_zleceń.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            //this.NavigationService.Navigate(new Uri("Okno_Zleceń.xaml", UriKind.Relative));
            //objokno_Zleceń.Items.Refresh();
            this.Close();
        }
    }
}
