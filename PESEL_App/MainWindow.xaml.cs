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

namespace PESEL_App
{
    /// <summary>
    /// Program generuje numer PESEL.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Guzik, który geneuje numer PESEL zgodny z wymogami.
        /// </summary>
        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            if (dpDateBirth.SelectedDate == null)
            {
                MessageBox.Show("Dodaj datę urodzenia!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //c to char, czyli znak np c1_2 to znak 1 i 2
                string c1_2, c3_4, c5_6, c7, c8, c9, c10, c11;
                string date = dpDateBirth.SelectedDate.Value.ToShortDateString();
                //Data z DatePicker
                string dayDP = date.Substring(0, 2);
                int monthDP = Int32.Parse(date.Substring(3, 2));
                int yearDP = Int32.Parse(date.Substring(6, 4));
                c5_6 = dayDP;

                //Sprawdzenie stulecia      
                c3_4 = "";
                if (yearDP >= 1800 && yearDP <= 1899)
                {
                    monthDP += 80;
                    c3_4 = monthDP.ToString();
                }
                else if (yearDP >= 2000 && yearDP <= 2099)
                {
                    monthDP += 20;
                    c3_4 = monthDP.ToString();
                }
                else if (yearDP >= 2100 && yearDP <= 2199)
                {
                    monthDP += 40;
                    c3_4 = monthDP.ToString();
                }
                else if (yearDP >= 2200 && yearDP <= 2299)
                {
                    monthDP += 60;
                    c3_4 = monthDP.ToString();
                }
                else if (yearDP >= 1900 && yearDP <= 1999)
                {
                    if (monthDP < 10)
                    {
                        c3_4 = "0" + monthDP.ToString();
                    }
                    else
                    {
                        c3_4 = monthDP.ToString();
                    }
                }

                //Skrócenie roku np z 1999 na 99.
                c1_2 = yearDP.ToString().Substring(2, 2);

                //Losowanie wartości dla cyfr 7-9 (numer serii)
                Random random = new Random();
                c7 = random.Next(0, 10).ToString();
                c8 = random.Next(0, 10).ToString();
                c9 = random.Next(0, 10).ToString();

                //Losowanie cyfry oznaczającej płeć.
                c10 = "";
                if (rbK.IsChecked == true)
                {
                    c10 = (random.Next(0, 5) * 2).ToString();
                    c11 = Calculations(c1_2, c3_4, c5_6, c7, c8, c9, c10);
                }
                else if (rbM.IsChecked == true)
                {
                    c10 = (random.Next(1, 6) * 2 - 1).ToString();
                    c11 = Calculations(c1_2, c3_4, c5_6, c7, c8, c9, c10);
                }
                else
                {
                    MessageBox.Show("Zaznacz płeć!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                //c11 = Calculations(c1_2, c3_4, c5_6, c7, c8, c9, c10);
            }
        }

        /// <summary>
        /// Obliczenia dla sumy kontrolnej.
        /// </summary>
        private string Calculations(string c1_2, string c3_4, string c5_6, string c7, string c8, string c9, string c10)
        {
            string c11;
            //Mnożenie pierwszych 10 cyfr przez wyznaczone mnożniki.
            int result = 1 * Int32.Parse(c1_2.Substring(0, 1)) + 3 * Int32.Parse(c1_2.Substring(1, 1))
                + 7 * Int32.Parse(c3_4.Substring(0, 1)) + 9 * Int32.Parse(c3_4.Substring(1, 1))
                + 1 * Int32.Parse(c5_6.Substring(0, 1)) + 3 * Int32.Parse(c5_6.Substring(1, 1))
                + 7 * Int32.Parse(c7) + 9 * Int32.Parse(c8) + 1 * Int32.Parse(c9) + 3 * Int32.Parse(c10);

            int x = result % 10;
            c11 = ((10 - x) % 10).ToString();

            txtPesel.Text = c1_2 + c3_4 + c5_6 + c7 + c8 + c9 + c10 + c11;
            return c11;
        }

        /// <summary>
        /// Guzik, który czyści pole z numerem PESEL.
        /// </summary>
        private void btnClear_Click(object sender, RoutedEventArgs e) => txtPesel.Text = "";
    }
}
