using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace DVD_Projekt_Blue_dwa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Pracownicy_Click(object sender, RoutedEventArgs e)
        {
            int i = 1;
            int licznik = 0;
            int log = 0;
            var path = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\pracownicy.db");

            Window1 objWindow1 = new Window1();
            do
            {
                string poszukiwane_id = "@" + i + ".";
                if (!File.ReadAllText(path).Contains(poszukiwane_id))
                {
                    objWindow1.id_pracownika.Text = poszukiwane_id;
                    licznik++;
                }
                i++;
            } while (i!=7 && licznik != 1);
            if (File.ReadAllLines(path).Length >= 7)
             {
                MessageBox.Show("Uruchamiam pokazywanie zespołu, jednak nabór zostaje wyłączony, ze względu na limit miejsc");
            }
            objWindow1.Show();
            this.Close();
        }

        private void Zlecenia_Click(object sender, RoutedEventArgs e)
        {
            Okno_Zleceń objokno_Zleceń = new Okno_Zleceń();
            objokno_Zleceń.Show();
            this.Close();
        }

        private void Lista_Zleceń_Click(object sender, RoutedEventArgs e)
        {
            Archiwum_zleceń objArchiwum_zleceń = new Archiwum_zleceń();
            objArchiwum_zleceń.Show();
            this.Close();
        }

        private void logowanie_Click(object sender, RoutedEventArgs e)
        {
            Logowanie objLogowanie = new Logowanie();
            objLogowanie.Show();
            this.Close();
        }
    }
}
