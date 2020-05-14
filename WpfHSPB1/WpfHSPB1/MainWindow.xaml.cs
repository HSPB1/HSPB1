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

namespace WpfHSPB1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Weiter_Click(object sender, RoutedEventArgs e)
        {
            //Objekterzeugung

            Window1 Berechnung = new Window1();


            //Aufruf des neuen Fensters
            Berechnung.Show();

            //schließt dieses Fenster bei Ausführung des neuen!
            this.Close();
        }

        private void btn_Beenden_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }






}
