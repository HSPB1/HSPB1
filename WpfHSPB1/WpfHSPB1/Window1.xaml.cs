using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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



        internal void trv_RundRohr_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Visible;
            grd_material.Visibility = Visibility.Visible;
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;
        }

        internal void trv_HalbrundProfilVoll_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Visible;
            grd_Rohr.Visibility = Visibility.Hidden;
            grd_material.Visibility = Visibility.Visible;
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;
        }

        internal void trv_RundProfilVoll_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Visible;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
            grd_material.Visibility = Visibility.Visible;
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;


        }

        internal void trv_VollmaterialRechteck_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Visible;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
            grd_material.Visibility = Visibility.Visible;
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;

        }

        internal void trv_HohlProfilRechteck_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Visible;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
            grd_material.Visibility = Visibility.Visible;
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;


        }
        internal void trv_VollmaterialSechseck_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
            grd_material.Visibility = Visibility.Visible;
            grd_VollmaterialSechseck.Visibility = Visibility.Visible;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;

        }
        internal void trv_LProfil_Selected(object sender, RoutedEventArgs e) 
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
            grd_material.Visibility = Visibility.Visible;
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Visible;

        }
        internal void trv_TProfil_Selected(object sender, RoutedEventArgs e) 
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
            grd_material.Visibility = Visibility.Visible;
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Visible;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;


        }

        internal void trv_UProfil_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
            grd_material.Visibility = Visibility.Visible;
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Visible;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;


        }
        internal void trv_IProfil_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Visible;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
            grd_material.Visibility = Visibility.Visible;
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Visible;
            grd_LProfil.Visibility = Visibility.Hidden;


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


        private void trv_VerzProfile_Selected(object sender, RoutedEventArgs e)
        {

        }

        

        






        private void Schließen_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_ReVo_berechnung_Click(object sender, RoutedEventArgs e)
        {   
            
            try
            {
      
                
                
                    double höhe = Convert.ToDouble(TxtBox_ReVo_Höhe.Text);
                    double breite = Convert.ToDouble(TxtBox_ReVo_Breite.Text);
                    double länge = Convert.ToDouble(TxtBox_ReVo_Länge.Text);

                    double qfläche = höhe * breite;
                    double volumen = qfläche * länge;
                    double Wy = breite * höhe * höhe / 6;
                    double Wz = höhe * breite * breite / 6;
                    double Iy = breite * höhe * höhe * höhe / 12;
                    double Iz = höhe * breite * breite * breite / 12;
                    double Polar = Iy + Iz;

                    double gewicht = 0;
                    double preis = 0;

                    if (höhe < 0 || breite < 0 || länge < 0)
                    {
                        MessageBox.Show("Ihre Parameter Eingabe war Fehlerhaft");
                    }
                        

                    if (cbi_Stahl.IsSelected)
                    {
                        gewicht = volumen * 0.00000785;
                        preis = gewicht * 1.5;

                    }

                    if (cbi_Aluminium.IsSelected)
                    {
                        gewicht = volumen * 0.0000027;
                        preis = gewicht * 2.5;
                    }

                    lbl_Gewicht.Content = gewicht;
                    lbl_Preis.Content = preis;
                    lbl_qfläche.Content = qfläche;
                    lbl_volumen.Content = volumen;
                    lbl_Wy.Content = Wy;
                    lbl_Wz.Content = Wz;
                    lbl_Iy.Content = Iy;
                    Lbl_Iz.Content = Iz;
                    lbl_Polar.Content = Polar;
                
            }
            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!"); }

            

        }

        private void btn_ReHo_berechnung_Click(object sender, RoutedEventArgs e)
        {

            try
            {
             
                    double höhe = Convert.ToDouble(TxtBox_ReHo_Höhe.Text);
                    double breite = Convert.ToDouble(TxtBox_ReHo_Breite.Text);
                    double länge = Convert.ToDouble(TxtBox_ReHo_Länge.Text);
                    double wandstärke = Convert.ToDouble(TxtBox_ReHo_Wandstärke.Text);

                    double qfläche = (höhe * breite) - ((höhe - 2 * wandstärke) * (breite - 2 * wandstärke));
                    double volumen = qfläche * länge;
                    double Wy = ((breite * höhe * höhe * höhe) - ((breite - 2 * wandstärke) * (höhe - 2 * wandstärke) * (höhe - 2 * wandstärke) * (höhe - 2 * wandstärke))) / (6 * höhe);
                    double Wz = ((höhe * breite * breite * breite) - ((höhe - 2 * wandstärke) * (breite - 2 * wandstärke) * (breite - 2 * wandstärke) * (breite - 2 * wandstärke))) / (6 * breite);
                    double Iy = ((breite * höhe * höhe * höhe) - ((breite - 2 * wandstärke) * (höhe - 2 * wandstärke) * (höhe - 2 * wandstärke) * (höhe - 2 * wandstärke))) / 12;
                    double Iz = ((höhe * breite * breite * breite) - ((höhe - 2 * wandstärke) * (breite - 2 * wandstärke) * (breite - 2 * wandstärke) * (breite - 2 * wandstärke))) / 12;
                    double Polar = Iy + Iz;

                    double gewicht = 0;
                    double preis = 0;

                    if(höhe <=0 || breite <=0 || länge <=0 || wandstärke <= 0)
                    {
                    MessageBox.Show("Ihre Parameter Eingabe war Fehlerhaft");
                     }

                    if (cbi_Stahl.IsSelected)
                    {
                        gewicht = volumen * 0.00000785;
                        preis = gewicht * 1.5;

                    }

                    if (cbi_Aluminium.IsSelected)
                    {
                        gewicht = volumen * 0.0000027;
                        preis = gewicht * 2.5;
                    }

                    lbl_Gewicht.Content = gewicht;
                    lbl_Preis.Content = preis;
                    lbl_qfläche.Content = qfläche;
                    lbl_volumen.Content = volumen;
                    lbl_Wy.Content = Wy;
                    lbl_Wz.Content = Wz;
                    lbl_Iy.Content = Iy;
                    Lbl_Iz.Content = Iz;
                    lbl_Polar.Content = Polar;
                
            }

            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!"); }
        }
        

        private void btn_RuVo_berechnung_Click(object sender, RoutedEventArgs e)
        {/// Sind Parameter eingegeben worden

            try
            {
            
                    double durchmesser = Convert.ToDouble(TxtBox_RuVo_Durchmesser.Text);
                    double länge = Convert.ToDouble(TxtBox_RuVo_Länge.Text);
                    ///Berechnungen
                    double qfläche = Math.PI * durchmesser * durchmesser / 4;
                    double volumen = qfläche * länge;
                    double Wy = Math.PI * durchmesser * durchmesser * durchmesser / 32;
                    double Wz = Math.PI * durchmesser * durchmesser * durchmesser / 32;
                    double Iy = Math.PI * durchmesser * durchmesser * durchmesser * durchmesser / 64;
                    double Iz = Math.PI * durchmesser * durchmesser * durchmesser * durchmesser / 64;
                    double Polar = Iy + Iz;


                    double gewicht = 0;
                    double preis = 0;

                    if(durchmesser <=0 || länge <=0)
                    {
                        MessageBox.Show("Ihre Parameter Eingabe war Fehlerhaft");
                    }


                    ///Auswahl Stahl
                    if (cbi_Stahl.IsSelected)
                    {///Berechnung
                        gewicht = volumen * 0.00000785;
                        preis = gewicht * 1.5;

                    }
                    /// Auswahl Aluminim
                    if (cbi_Aluminium.IsSelected)
                    {///Berechnung
                        gewicht = volumen * 0.0000027;
                        preis = gewicht * 2.5;
                    }
                    ///Ausgabe der berechneten Werte für das Profil Vollmaterial Rund
                    lbl_Gewicht.Content = gewicht;
                    lbl_Preis.Content = preis;
                    lbl_qfläche.Content = qfläche;
                    lbl_volumen.Content = volumen;
                    lbl_Wy.Content = Wy;
                    lbl_Wz.Content = Wz;
                    lbl_Iy.Content = Iy;
                    Lbl_Iz.Content = Iz;
                    lbl_Polar.Content = Polar;

                
            }

            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!"); }
        }

        private void btn_SeVo_berechnung_Click(object sender, RoutedEventArgs e)
        {/// Sind Parameter eingegeben worden

            try
            {

              
                    double radius = Convert.ToDouble(TxtBox_SeVo_Radius.Text);
                    double länge = Convert.ToDouble(TxtBox_SeVo_Länge.Text);
                    ///Berechnungen
                    double qfläche = 3 * (Math.Sqrt(3)) / 2 * (radius * radius);
                    double volumen = qfläche * länge;
                    double Wy = radius * radius * radius * 5 / 8;
                    double Wz = 5 * (Math.Sqrt(3)) / 16 * (radius * radius * radius);
                    double Iy = 5 * (Math.Sqrt(3)) / 16 * (radius * radius * radius * radius);
                    double Iz = 5 * (Math.Sqrt(3)) / 16 * (radius * radius * radius * radius);
                    double Polar = Iy + Iz;


                    double gewicht = 0;
                    double preis = 0;

                    if(radius <=0 || länge <=0)
                    {
                        MessageBox.Show("Ihre Parameter Eingabe war Fehlerhaft");

                    }

                    ///Auswahl Stahl
                    if (cbi_Stahl.IsSelected)
                    {///Berechnung
                        gewicht = volumen * 0.00000785;
                        preis = gewicht * 1.5;

                    }
                    /// Auswahl Aluminim
                    if (cbi_Aluminium.IsSelected)
                    {///Berechnung
                        gewicht = volumen * 0.0000027;
                        preis = gewicht * 2.5;
                    }
                    ///Ausgabe der berechneten Werte für das Profil Vollmaterial Sechseck
                    lbl_Gewicht.Content = gewicht;
                    lbl_Preis.Content = preis;
                    lbl_qfläche.Content = qfläche;
                    lbl_volumen.Content = volumen;
                    lbl_Wy.Content = Wy;
                    lbl_Wz.Content = Wz;
                    lbl_Iy.Content = Iy;
                    Lbl_Iz.Content = Iz;
                    lbl_Polar.Content = Polar;
                

            }

            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!"); }
        }

        private void btn_TPro_berechnung_Click(object sender, RoutedEventArgs e)
        {

            try
            {
     
                    double H = Convert.ToDouble(TxtBox_TPro_Höhe.Text);
                    double B = Convert.ToDouble(TxtBox_TPro_Breite.Text);
                    double länge = Convert.ToDouble(TxtBox_TPro_Länge.Text);
                    double h = Convert.ToDouble(TxtBox_TPro_Wandstärkeh.Text);
                    double b = Convert.ToDouble(TxtBox_TPro_Wandstärkeb.Text);

                ///Zwischenergebnisse
                double e2 = ((b * H * H + (B - b) * h * h) * 0.5) / (b * H + (B - b) * h);
                double y = (b * H + (B - b) * h);
                double z = (b * H * H * H + (B - b) * h * h * h) / 3;


                double qfläche = (H * B) - ((H - h) * (B - b));
                double volumen = qfläche * länge;

                double Wz = (h * B * B * B + (H - h) * b * b * b) / (6 * B);
                double Iy = z - y * (e2 * e2);
                double Iz = (h * B * B * B + (H - h) * b * b * b) / 12;
                double Wy = Iy / (H - e2);
                double Polar = Iy + Iz;

                double gewicht = 0;
                    double preis = 0;

                    if(H <= 0 || B <=0 || länge <=0 || h <=0 || b <=0 )

                    {
                         MessageBox.Show("Ihre Parameter Eingabe war Fehlerhaft");
                    }

                    if (cbi_Stahl.IsSelected)
                    {
                        gewicht = volumen * 0.00000785;
                        preis = gewicht * 1.5;

                    }

                    if (cbi_Aluminium.IsSelected)
                    {
                        gewicht = volumen * 0.0000027;
                        preis = gewicht * 2.5;
                    }

                    lbl_Gewicht.Content = gewicht;
                    lbl_Preis.Content = preis;
                    lbl_qfläche.Content = qfläche;
                    lbl_volumen.Content = volumen;
                    lbl_Wy.Content = Wy;
                    lbl_Wz.Content = Wz;
                    lbl_Iy.Content = Iy;
                    Lbl_Iz.Content = Iz;
                    lbl_Polar.Content = Polar;
                

            }
            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!"); }
        }

        private void btn_UPro_berechnung_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                double H = Convert.ToDouble(TxtBox_UPro_Höhe.Text);
                double B = Convert.ToDouble(TxtBox_UPro_Breite.Text);
                double länge = Convert.ToDouble(TxtBox_UPro_Länge.Text);
                double h = Convert.ToDouble(TxtBox_UPro_Wandstärkeh.Text);
                double b = Convert.ToDouble(TxtBox_UPro_Wandstärkeb.Text);

                ///Zwischenergebnisse
                double e3 = (2 * h * B * B + (H - 2 * h) * b * b) * 0.5 / (2 * h * B + (H - 2 * h) * b);
                double y = (2 * h * B + (H - 2 * h) * b);
                double x = (2 * h * B * B * B + (H - 2 * h) * b * b * b) / 3;

                double qfläche = (H * B) - ((H - 2 * h) * (B - b));
                double volumen = qfläche * länge;


                double Iy = (B * H * H * H - (B - b) * ((H - 2 * h) * (H - 2 * h) * (H - 2 * h))) / 12;
                double Iz = x - (y * e3 * e3);
                double Wy = (B * H * H * H - (B - b) * ((H - 2 * h) * (H - 2 * h) * (H - 2 * h))) / 6 / H;
                double Wz = Iz / (B - e3);
                double Polar = Iy + Iz;

                double gewicht = 0;
                double preis = 0;

                if (H <= 0 || B <= 0 || länge <= 0 || h <= 0 || b <= 0)

                {
                    MessageBox.Show("Ihre Parameter Eingabe war Fehlerhaft");
                }

                if (cbi_Stahl.IsSelected)
                {
                    gewicht = volumen * 0.00000785;
                    preis = gewicht * 1.5;

                }

                if (cbi_Aluminium.IsSelected)
                {
                    gewicht = volumen * 0.0000027;
                    preis = gewicht * 2.5;
                }

                lbl_Gewicht.Content = gewicht;
                lbl_Preis.Content = preis;
                lbl_qfläche.Content = qfläche;
                lbl_volumen.Content = volumen;
                lbl_Wy.Content = Wy;
                lbl_Wz.Content = Wz;
                lbl_Iy.Content = Iy;
                Lbl_Iz.Content = Iz;
                lbl_Polar.Content = Polar;


            }
            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!"); }
        }
        private void btn_IPro_berechnung_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                double H = Convert.ToDouble(TxtBox_IPro_Höhe.Text);
                double B = Convert.ToDouble(TxtBox_IPro_Breite.Text);
                double länge = Convert.ToDouble(TxtBox_IPro_Länge.Text);
                double h = Convert.ToDouble(TxtBox_IPro_Wandstärkeh.Text);
                double b = Convert.ToDouble(TxtBox_IPro_Wandstärkeb.Text);

                double qfläche = (H * B) - ((H - 2 * h) * (B - b));
                double volumen = qfläche * länge;

                double Wz = (2 * h * B * B * B + (H - 2 * h) * b * b * b) / (6 * B);
                double Iy = (B * H * H * H - (B - b) * ((H - 2 * h) * (H - 2 * h) * (H - 2 * h))) / 12;
                double Iz = (2 * h * B * B * B + (H - 2 * h) * b * b * b) / 12;
                double Wy = (B * H * H * H - (B - b) * ((H - 2 * h) * (H - 2 * h) * (H - 2 * h))) / 6 / H;
                double Polar = Iy + Iz;

                double gewicht = 0;
                double preis = 0;

                if (H <= 0 || B <= 0 || länge <= 0 || h <= 0 || b <= 0)

                {
                    MessageBox.Show("Ihre Parameter Eingabe war Fehlerhaft");
                }

                if (cbi_Stahl.IsSelected)
                {
                    gewicht = volumen * 0.00000785;
                    preis = gewicht * 1.5;

                }

                if (cbi_Aluminium.IsSelected)
                {
                    gewicht = volumen * 0.0000027;
                    preis = gewicht * 2.5;
                }

                lbl_Gewicht.Content = gewicht;
                lbl_Preis.Content = preis;
                lbl_qfläche.Content = qfläche;
                lbl_volumen.Content = volumen;
                lbl_Wy.Content = Wy;
                lbl_Wz.Content = Wz;
                lbl_Iy.Content = Iy;
                Lbl_Iz.Content = Iz;
                lbl_Polar.Content = Polar;


            }
            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!"); }
        }
        private void btn_HaRu_berechnung_Click(object sender, RoutedEventArgs e)
        {
            try
            {

             
                    double radius = Convert.ToDouble(TxtBox_HaRu_Radius.Text);
                    double länge = Convert.ToDouble(TxtBox_HaRu_Länge.Text);

                    double qfläche = Math.PI * radius * radius / 2;
                    double volumen = qfläche * länge;
                    double Wy = 0.1908 * radius * radius;
                    double Wz = 00;
                    double Iy = 0.1098 * radius * radius * radius * radius;
                    double Iz = 00;
                    double Polar = 00;

                    double gewicht = 0;
                    double preis = 0;

                    if(radius <= 0 || länge <= 0)
                    {

                        MessageBox.Show("Ihre Parameter Eingabe war Fehlerhaft");

                    }

                    if (cb_Material.Text == "Stahl")
                    {
                        gewicht = volumen * 0.00000785;
                        preis = gewicht * 1.5;

                    }

                    if (cb_Material.Text == "Aluminium")
                    {
                        gewicht = volumen * 0.0000027;
                        preis = gewicht * 2.5;
                    }

                    lbl_Gewicht.Content = gewicht;
                    lbl_Preis.Content = preis;

                    lbl_qfläche.Content = qfläche;
                    lbl_volumen.Content = volumen;
                    lbl_Wy.Content = Wy;
                    lbl_Wz.Content = Wz;
                    lbl_Iy.Content = Iy;
                    Lbl_Iz.Content = Iz;
                    lbl_Polar.Content = Polar;
                
            }

            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!"); }

        }

        private void btn_Rohr_berechnung_Click(object sender, RoutedEventArgs e)
        {

            try
            {
           
                    double durchmesser = Convert.ToDouble(TxtBox_Rohr_Durchmesser.Text);
                    double wandstärke = Convert.ToDouble(TxtBox_Rohr_Wandstärke.Text);
                    double länge = Convert.ToDouble(TxtBox_Rohr_Länge.Text);

                    double qfläche = (Math.PI * durchmesser * durchmesser / 4) - (Math.PI * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) / 4);
                    double volumen = qfläche * länge;
                    double Wy = Math.PI * (durchmesser * durchmesser * durchmesser * durchmesser - (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke)) / (32 * durchmesser);
                    double Wz = Math.PI * (durchmesser * durchmesser * durchmesser * durchmesser - (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke)) / (32 * durchmesser);
                    double Iy = Math.PI * (durchmesser * durchmesser * durchmesser * durchmesser - (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke)) / 64;
                    double Iz = Math.PI * (durchmesser * durchmesser * durchmesser * durchmesser - (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke)) / 64;
                    double Polar = Iy + Iz;

                    double gewicht = 0;
                    double preis = 0;

                    if(durchmesser <= 0 || wandstärke <=0 || länge <=0)

                    {
                         MessageBox.Show("Ihre Parameter Eingabe war Fehlerhaft");

                    }


                    if (cb_Material.Text == "Stahl")

                    {
                        gewicht = volumen * 0.00000785;
                        preis = gewicht * 1.5;

                    }

                    if (cb_Material.Text == "Aluminium")
                    {
                        gewicht = volumen * 0.0000027;
                        preis = gewicht * 2.5;
                    }

                    lbl_Gewicht.Content = gewicht;
                    lbl_Preis.Content = preis;
                    lbl_qfläche.Content = qfläche;
                    lbl_volumen.Content = volumen;
                    lbl_Wy.Content = Wy;
                    lbl_Wz.Content = Wz;
                    lbl_Iy.Content = Iy;
                    Lbl_Iz.Content = Iz;
                    lbl_Polar.Content = Polar;
                

            }

            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!"); }
        }

        private void btn_LPro_Berechnung_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                double H = Convert.ToDouble(TxtBox_LPro_Höhe.Text);
                double B = Convert.ToDouble(TxtBox_LPro_Breite.Text);
                double länge = Convert.ToDouble(TxtBox_LPro_Länge.Text);
                double h = Convert.ToDouble(TxtBox_LPro_Wandstärkeh.Text);
                double b = Convert.ToDouble(TxtBox_LPro_Wandstärkeb.Text);

                ///Zwischenergebnisse
                double e2 = ((b * H * H + (B - b) * h * h) * 0.5) / (b * H + (B - b) * h);
                double y = (b * H + (B - b) * h);
                double z = (b * H * H * H + (B - b) * h * h * h) / 3;


                double qfläche = (H * B) - ((H - h) * (B - b));
                double volumen = qfläche * länge;

                double Wz = (h * B * B * B + (H - h) * b * b * b) / (6 * B);
                double Iy = z - y * (e2 * e2);
                double Iz = (h * B * B * B + (H - h) * b * b * b) / 12;
                double Wy = Iy / (H - e2);
                double Polar = Iy + Iz;

                double gewicht = 0;
                double preis = 0;

                if (H <= 0 || B <= 0 || länge <= 0 || h <= 0 || b <= 0)

                {
                    MessageBox.Show("Ihre Parameter Eingabe war Fehlerhaft");
                }

                if (cbi_Stahl.IsSelected)
                {
                    gewicht = volumen * 0.00000785;
                    preis = gewicht * 1.5;

                }

                if (cbi_Aluminium.IsSelected)
                {
                    gewicht = volumen * 0.0000027;
                    preis = gewicht * 2.5;
                }

                lbl_Gewicht.Content = gewicht;
                lbl_Preis.Content = preis;
                lbl_qfläche.Content = qfläche;
                lbl_volumen.Content = volumen;
                lbl_Wy.Content = Wy;
                lbl_Wz.Content = Wz;
                lbl_Iy.Content = Iy;
                Lbl_Iz.Content = Iz;
                lbl_Polar.Content = Polar;


            }
            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!"); }
        }

        private void cb_Material_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    

   

}
