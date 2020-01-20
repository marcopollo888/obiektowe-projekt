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
    /// Logika interakcji dla klasy terminarz_dostęp_gościnny.xaml
    /// </summary>
    public partial class terminarz_dostęp_gościnny : Window
    {
        public terminarz_dostęp_gościnny()
        {
            InitializeComponent();
            kalendarz_id1.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id2.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id3.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id4.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id5.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
            kalendarz_id6.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
        }
    }
}
