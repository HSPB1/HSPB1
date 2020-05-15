using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfHSPB1
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

            

        private void trv_RundRohr_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden ;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
        }

        private void trv_HalbrundProfilVoll_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
        }

        private void trv_RundProfilVoll_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
        }

        private void trv_VollmaterialRechteck_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Visible;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
        }

        private void trv_HohlProfilRechteck_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Visible;            
        }

        private void trv_VerzRechteckigeProfile_Selected(object sender, RoutedEventArgs e)
        {
           
        }

        private void trv_VerzRundeProifle_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void trv_VerzRundHohl_Selected(object sender, RoutedEventArgs e)
        {
            
        }

     


        private void Schließen_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
