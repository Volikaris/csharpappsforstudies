using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zad2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Boolean isNotEmpty = false;
        /// <summary>
        /// MOŻNA DOWOLNIE ZMIENIC SCIEZKE ZAPISU PLIKU ;)
        /// </summary>
        string path = @"d:\testplik\MyFile.txt";
        public MainWindow()
        {
            try
            {
                StreamWriter sw = File.CreateText(path);
            }
            catch
            {
                Exception e = new Exception();
            }
            InitializeComponent();
            wysZam.Click += WysZam_Click;
            usunZam.Click += UsunZam_Click;
            czyscDane.Click += CzyscDane_Click;
            czyscPizza.Click += CzyscPizza_Click;
            dodZam.Click += DodZam_Click;
            daneZam2.Items.Add("Jan Kowalski");
            daneZam2.Items.Add("Kazimierz Nowak");
            daneZam2.Items.Add("Jerzy Kiler");
            daneZam2.Items.Add("Aleksander Pompka");
            nazwaPizzy.Items.Add("Miesna");
            nazwaPizzy.Items.Add("Wegetarianska");
            nazwaPizzy.Items.Add("Hawajska");
            nazwaPizzy.Items.Add("Meksykanska");
        }
        private void checkBeforeSend()
        {
            isNotEmpty = false;
            if(daneZam2.Text != "" && nazwaPizzy.Text != "")
            {
                if(rButton1.IsChecked == true || rButton2.IsChecked == true || rButton3.IsChecked == true || rButton4.IsChecked == true)
                {
                    if(dodSer.IsChecked == true)
                    {
                        if(dodSer2.Text == "")
                        {
                            poleZam.Text += "Nie wybrano dodatkowego sera!\n";
                            return;
                        }
                    }
                    if (dodSos.IsChecked == true)
                    {
                        if (dodSos2.Text == "")
                        {
                            poleZam.Text += "Nie wybrano dodatkowego sosu!\n";
                            return;
                        }
                    }
                    if (dodNap.IsChecked == true)
                    {
                        if (dodNap2.Text == "")
                        {
                            poleZam.Text += "Nie wybrano dodatkowego napoju!\n";
                            return;
                        }
                    }
                    isNotEmpty = true;
                }
                else
                {
                    poleZam.Text += "Nie wybrano spodu pizzy!\n";
                    return;
                }
            }
            else
            {
                poleZam.Text += "Nie podano danych klienta/pizzy!\n";
                return;
            }
        }
        private void DodZam_Click(object sender, RoutedEventArgs e)
        {
            checkBeforeSend();
            if (!isNotEmpty) return;
            poleZam.Text += daneZam2.Text + "\n";
            poleZam.Text += "--\n";
            poleZam.Text += nazwaPizzy.Text + " na " + getSpod() + "\n";
            poleZam.Text += getDodSer();
            poleZam.Text += getDodSos();
            poleZam.Text += getDodNap();
            poleZam.Text += "--\n";

            daneZam2.Text = "";
            nazwaPizzy.Text = "";
            rButton1.IsChecked = false;
            rButton2.IsChecked = false;
            rButton3.IsChecked = false;
            rButton4.IsChecked = false;
            dodSer.IsChecked = false;
            dodSos.IsChecked = false;
            dodNap.IsChecked = false;
            dodSer2.Text = "";
            dodSos2.Text = "";
            dodNap2.Text = "";
        }
        private void CzyscPizza_Click(object sender, RoutedEventArgs e)
        {
            nazwaPizzy.Text = "";
        }
        private void CzyscDane_Click(object sender, RoutedEventArgs e)
        {
            daneZam2.Text = "";
        }
        private void UsunZam_Click(object sender, RoutedEventArgs e)
        {
            clearAll();
        }
        private void WysZam_Click(object sender, RoutedEventArgs e)
        {
            poleZam.Text += "\n--\nZamówienia zostały zaakceptowane\n--\n";
        }
        private void clearAll()
        {
            poleZam.Text = "";
            dodSer2.Text = "";
            dodSos2.Text = "";
            dodNap2.Text = "";
            nazwaPizzy.Text = "";
        }
        private String getSpod()
        {
            if (rButton1.IsChecked == true)
            {
                return "zwykłym spodzie";
            }
            else if (rButton2.IsChecked == true)
            {
                return "ultracienkim spodzie";
            }
            else if (rButton3.IsChecked == true)
            {
                return "grubym spodzie";
            }
            else if (rButton4.IsChecked == true)
            {
                return "specjalnym podwójnym grubym spodzie";
            }
            else
            {
                return "";
            }
        }
        private String getDodSer()
        {
            if(dodSer.IsChecked == true)
            {
                return dodSer.Content + ": " + dodSer2.Text + "\n";
            }
            else
            {
                return "";
            }
        }
        private String getDodSos()
        {
            if (dodSos.IsChecked == true)
            {
                return dodSos.Content + ": " + dodSos2.Text + "\n";
            }
            else
            {
                return "";
            }
        }
        private String getDodNap()
        {
            if (dodNap.IsChecked == true)
            {
                return dodNap.Content + ": " + dodNap2.Text + "\n";
            }
            else
            {
                return "";
            }
        }
        

        private void ZapiszPlik_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(poleZam.Text);
                    poleZam.Text = "";
                }
            }
            catch
            {
                Exception ex = new Exception();
            }
        }
        private void WczytajPlik_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        poleZam.Text += s + "\n";
                    }
                }
            }
            catch
            {
                Exception ex = new Exception();
            }
        }

        private void DaneZam2_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                if(daneZam2.Text != "")
                    for(int i = 0; i< daneZam2.Items.Count; i++)
                    {
                        if(daneZam2.Text == daneZam2.Items[i].ToString())
                        {
                            daneZam2.Text = "";
                            return;
                        }
                    }
                    daneZam2.Items.Add(daneZam2.Text);
                daneZam2.Text = "";
            }
        }
        private void WyczyscPlik_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("");
                }
            }
            catch
            {
                Exception ex = new Exception();
            }
        }
        private void WyczyscWszystko_Click(object sender, RoutedEventArgs e)
        {
            clearAll();
            daneZam2.Items.Clear();
            nazwaPizzy.Items.Clear();
        }
    }
}
