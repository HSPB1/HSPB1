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
using System.Diagnostics; //Nötig für das ausführen des Catia Programm
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

        internal void btn_Weiter_Click(object sender, RoutedEventArgs e)
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

        private void btn__Catia_Starten_Click(object sender, RoutedEventArgs e)
        {
            Window1 Berechnung = new Window1();

            //Starten der Catia App ;D ;D ;D 
            string Programmname = "CNEXT.exe";
            Process.Start(Programmname);


            Berechnung.Show();
            
            this.Close();
        }
    }






}
