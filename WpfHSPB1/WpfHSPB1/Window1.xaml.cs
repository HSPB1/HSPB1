using System;
using System.Windows;
using System.Windows.Controls;
using Profile_Muster;



namespace WpfHSPB1
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    /// 





    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        RechteckVoll rechteckVoll;
        RechteckHohl rechteckHohl;
        SechseckVoll neuSechseckVoll;
        RundVollProfil neuRundVoll;
        RundHohlProfil neuRundHohl;
        HalbrundProfil neuHalbRund;
        TProfil neuTProfil;
        UProfil neuUProfil;
        IProfil neuIProfil;
        LProfil neuLProfil;
        ExcelApi neu = null;

        internal void trv_RundRohr_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Hidden;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Visible;
           
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;

            TxtBox_Rohr_Durchmesser.Clear();
            TxtBox_Rohr_Länge.Clear();
            TxtBox_Rohr_Wandstärke.Clear();

        }

        internal void trv_HalbrundProfilVoll_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Hidden;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Visible;
            grd_Rohr.Visibility = Visibility.Hidden;
          
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;

            TxtBox_HaRu_Länge.Clear();
            TxtBox_HaRu_Radius.Clear();
           

        }

        internal void trv_RundProfilVoll_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Hidden;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Visible;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
          
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;

            TxtBox_RuVo_Durchmesser.Clear();
            TxtBox_RuVo_Länge.Clear();

        }

        internal void trv_VollmaterialRechteck_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Visible;
            grd_Ergebnisse.Visibility = Visibility.Hidden;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
         
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;

            TxtBox_ReVo_Breite.Clear();
            TxtBox_ReVo_Höhe.Clear();
            TxtBox_ReVo_Länge.Clear();

            
      

        }

        internal void trv_HohlProfilRechteck_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Hidden;
            grd_RechteckHohl.Visibility = Visibility.Visible;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
         
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;

            TxtBox_ReHo_Breite.Clear();
            TxtBox_ReHo_Höhe.Clear();
            TxtBox_ReHo_Länge.Clear();
            TxtBox_ReHo_Wandstärke.Clear();

        }
        internal void trv_VollmaterialSechseck_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Hidden;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
          
            grd_VollmaterialSechseck.Visibility = Visibility.Visible;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;

            TxtBox_SeVo_Länge.Clear();
            TxtBox_SeVo_Radius.Clear();
           

        }
        internal void trv_LProfil_Selected(object sender, RoutedEventArgs e) 
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Hidden;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
    
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Visible;

            TxtBox_LPro_Breite.Clear();
            TxtBox_LPro_Höhe.Clear();
            TxtBox_LPro_Länge.Clear();
            TxtBox_LPro_Wandstärkeb.Clear();
            TxtBox_LPro_Wandstärkeh.Clear();
            
        }

        internal void trv_TProfil_Selected(object sender, RoutedEventArgs e) 
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Hidden;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
          
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Visible;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;

            TxtBox_TPro_Breite.Clear();
            TxtBox_TPro_Höhe.Clear();
            TxtBox_TPro_Länge.Clear();
            TxtBox_TPro_Wandstärkeb.Clear();
            TxtBox_TPro_Wandstärkeh.Clear();
            
        }

        internal void trv_UProfil_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Hidden;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
      
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Visible;
            grd_IProfil.Visibility = Visibility.Hidden;
            grd_LProfil.Visibility = Visibility.Hidden;

            TxtBox_UPro_Breite.Clear();
            TxtBox_UPro_Höhe.Clear();
            TxtBox_UPro_Länge.Clear();
            TxtBox_UPro_Wandstärkeb.Clear();
            TxtBox_UPro_Wandstärkeh.Clear();

        }
        internal void trv_IProfil_Selected(object sender, RoutedEventArgs e)
        {
            grd_Aufforderung.Visibility = Visibility.Hidden;
            grd_RechteckVoll.Visibility = Visibility.Hidden;
            grd_Ergebnisse.Visibility = Visibility.Hidden;
            grd_RechteckHohl.Visibility = Visibility.Hidden;
            grd_RundVoll.Visibility = Visibility.Hidden;
            grd_HalbRund.Visibility = Visibility.Hidden;
            grd_Rohr.Visibility = Visibility.Hidden;
        
            grd_VollmaterialSechseck.Visibility = Visibility.Hidden;
            grd_TProfil.Visibility = Visibility.Hidden;
            grd_UProfil.Visibility = Visibility.Hidden;
            grd_IProfil.Visibility = Visibility.Visible;
            grd_LProfil.Visibility = Visibility.Hidden;

            TxtBox_IPro_Breite.Clear();
            TxtBox_IPro_Höhe.Clear();
            TxtBox_IPro_Länge.Clear();
            TxtBox_IPro_Wandstärkeb.Clear();
            TxtBox_IPro_Wandstärkeh.Clear();
            

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
            if (MessageBox.Show("Soll das Programm beendet werden?", "Programmende", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
                System.Environment.Exit(0);
                                   
        }




        //Button Berechnung
        //Rechteckige Profile
        private void btn_ReVo_berechnung_Click(object sender, RoutedEventArgs e)
        {
            //Erzeugen des Objekts für ein RechteckVollprofil
            rechteckVoll = new RechteckVoll();
            CatiaAPIConection Neu = new CatiaAPIConection();
        
            try
            { 
                                             
                    rechteckVoll.Höhe = Convert.ToDouble(TxtBox_ReVo_Höhe.Text);
                    rechteckVoll.Breite = Convert.ToDouble(TxtBox_ReVo_Breite.Text);
                    rechteckVoll.Länge = Convert.ToDouble(TxtBox_ReVo_Länge.Text);

                    double preis = 0;
                    double gewicht = 0;

             
                


                {
                    //Hier Beginnen Die Comboxen Für ErgebnisFenster
                    //Für Qfläche
                    if (cbx_Qfläche.Text == "mm²")

                    {
                        double qfläche = rechteckVoll.QFläche() * 1;
                        lbl_qfläche.Content = qfläche.ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "cm²")
                    {

                        double qfläche = rechteckVoll.QFläche()/100;
                        lbl_qfläche.Content = qfläche.ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "m²")
                    {

                        double qfläche = rechteckVoll.QFläche()/1000;
                        lbl_qfläche.Content = qfläche.ToString("0.###"); 

                    }

                    //Für Volumen
                    if (cbx_Volumen.Text == "mm³")

                    {
                        double volumen = rechteckVoll.Volumen() * 1;
                        lbl_volumen.Content = volumen.ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "cm³")
                    {
                        double volumen = rechteckVoll.Volumen() /1000;
                        lbl_volumen.Content = volumen.ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "m³")
                    {
                        double volumen = rechteckVoll.Volumen() / 1000000;
                        lbl_volumen.Content = volumen.ToString("0.###"); 

                    }

                    //Für Wiederstandsmoment Wx
                    if (cbx_Wx.Text == "mm³")

                    {
                        double wx = rechteckVoll.WiederstandsMoment_Wy() * 1;
                        lbl_Wy.Content = wx.ToString("0.###");

                    }

                    if (cbx_Wx.Text == "cm³")
                    {
                        double wx = rechteckVoll.WiederstandsMoment_Wy() / 1000;
                        lbl_Wy.Content = wx.ToString("0.###");

                    }

                    if (cbx_Wx.Text == "m³")
                    {
                        double wx = rechteckVoll.WiederstandsMoment_Wy() / 1000000;
                        lbl_Wy.Content = wx.ToString("0.###");


                    }


                    //Für Wiederstandsmoment Wy
                    if (cbx_Wy.Text == "mm³")

                    {
                        double wy= rechteckVoll.WiederstandsMoment_Wz() * 1;
                        lbl_Wz.Content = wy.ToString("0.###");

                    }

                    if (cbx_Wy.Text == "cm³")
                    {
                        double wy = rechteckVoll.WiederstandsMoment_Wz() /1000;
                        lbl_Wz.Content = wy.ToString("0.###");

                    }

                    if (cbx_Wy.Text == "m³")
                    {
                        double wy = rechteckVoll.WiederstandsMoment_Wz() / 1000000;
                        lbl_Wz.Content = wy.ToString("0.###"); 

                    }


                    //Für TrägheitsMoment Ix
                    if (cbx_Ix.Text == "mm^4")

                    {
                        double ix= rechteckVoll.FTM_Iy() * 1;
                        lbl_Iy.Content = ix.ToString("0.###");

                    }

                    if (cbx_Ix.Text == "cm^4")
                    {
                        double ix = rechteckVoll.FTM_Iy() /10000;
                        lbl_Iy.Content = ix.ToString("0.###");

                    }


                    //Für TrägheitsMoment Iy
                    if (cbx_Iy.Text == "mm^4")

                    {
                        double iy = rechteckVoll.FTM_Iz() * 1;
                        Lbl_Iz.Content = iy.ToString("0.###");

                    }

                    if (cbx_Iy.Text == "cm^4")
                    {
                        double iy = rechteckVoll.FTM_Iz() /10000;
                        Lbl_Iz.Content = iy.ToString("0.###");

                    }


                    //Für TrägheitsMoment Polar
                    if (cbx_Polar.Text == "mm^4")

                    {
                        double polar= rechteckVoll.FTM_Polar() * 1;
                        lbl_Polar.Content = polar.ToString("0.###");

                    }

                    if (cbx_Polar.Text == "cm^4")
                    {
                        double polar = rechteckVoll.FTM_Polar() /10000;
                        lbl_Polar.Content = polar.ToString("0.###");

                    }
                    //Hier Enden Die Comboboxen!
                }//Comboboxen Ergebnisfenster

                 //Materialauswahl
                if (cb_Material.Text == "Stahl")
                    {
                        gewicht = rechteckVoll.Volumen() * 0.00000785;
                        preis = gewicht * 1.5;

                    }
                if (cb_Material.Text == "Aluminium")
                    {
                        gewicht = rechteckVoll.Volumen() * 0.0000027;
                         preis = gewicht * 2.5;
                    }


                grd_Ergebnisse.Visibility = Visibility.Visible;

                //Schwerpunkt
                lbl_GX.Content = (rechteckVoll.Breite / 2).ToString("0.###");
                lbl_Gy.Content = (rechteckVoll.Höhe / 2).ToString("0.###");
                lbl_Gz.Content = (rechteckVoll.Länge / 2).ToString("0.###");

                

                lbl_Preis.Content = preis.ToString("0.###");
                lbl_Gewicht.Content = gewicht.ToString("0.###");


                if (neu == null)
                {
                    neu = new ExcelApi();
                    neu.ExelControll();

                }

                neu.ExcelReVo(rechteckVoll);


                if (Neu.CatiaLaeuft())
                {
                    Neu.CatiaLaeuft();
                    Neu.ErzeugePart();
                    Neu.ErzeugeSkizze();
                    Neu.ErzeugeProfilRechteckVoll(rechteckVoll);
                    Neu.ErzeugeExtrusionVoll(rechteckVoll);
                }
                else
                {
                   MessageBox.Show("Laufende Catia Application nicht gefunden");
                }


            }
            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }

            

        }

        private void btn_ReHo_berechnung_Click(object sender, RoutedEventArgs e)
        {
            rechteckHohl = new RechteckHohl();
            CatiaAPIConection Neu = new CatiaAPIConection();

            try
            {

                rechteckHohl.Höhe = Convert.ToDouble(TxtBox_ReHo_Höhe.Text);
                rechteckHohl.Breite = Convert.ToDouble(TxtBox_ReHo_Breite.Text);
                rechteckHohl.Länge = Convert.ToDouble(TxtBox_ReHo_Länge.Text);
                rechteckHohl.Wandstärke = Convert.ToDouble(TxtBox_ReHo_Wandstärke.Text);


                double gewicht = 0;
                double preis = 0;

               

                {
                    //Hier Beginnen Die Comboxen Für ErgebnisFenster

                    //Für Qfläche
                    if (cbx_Qfläche.Text == "mm²")

                    {
                        lbl_qfläche.Content = (rechteckHohl.QFläche() * 1).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "cm²")
                    {
                        lbl_qfläche.Content = (rechteckHohl.QFläche() / 100).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "m²")
                    {
                        lbl_qfläche.Content = (rechteckHohl.QFläche() / 10000).ToString("0.###");

                    }

                    //Für Volumen
                    if (cbx_Volumen.Text == "mm³")

                    {
                        lbl_volumen.Content = (rechteckHohl.Volumen() * 1).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "cm³")
                    {
                        lbl_volumen.Content = (rechteckHohl.Volumen() / 1000).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "m³")
                    {
                        lbl_volumen.Content = (rechteckHohl.Volumen() / 1000000).ToString("0.###");

                    }

                    //Für Wiederstandsmoment Wx
                    if (cbx_Wx.Text == "mm³")

                    {
                        lbl_Wy.Content = (rechteckHohl.WiederstandsMoment_Wy() * 1).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "cm³")
                    {
                        lbl_Wy.Content = (rechteckHohl.WiederstandsMoment_Wy() / 1000).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "m³")
                    {
                        lbl_Wy.Content = (rechteckHohl.WiederstandsMoment_Wy() / 1000000).ToString("0.###");

                    }


                    //Für Wiederstandsmoment Wy
                    if (cbx_Wy.Text == "mm³")

                    {
                        lbl_Wz.Content = (rechteckHohl.WiederstandsMoment_Wz() * 1).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "cm³")
                    {
                        lbl_Wz.Content = (rechteckHohl.WiederstandsMoment_Wz() / 1000).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "m³")
                    {
                        lbl_Wz.Content = (rechteckHohl.WiederstandsMoment_Wz() / 1000000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Ix
                    if (cbx_Ix.Text == "mm^4")

                    {
                        lbl_Iy.Content = (rechteckHohl.FTM_Iy() * 1).ToString("0.###");

                    }

                    if (cbx_Ix.Text == "cm^4")
                    {
                        lbl_Iy.Content = (rechteckHohl.FTM_Iy() / 10000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Iy
                    if (cbx_Iy.Text == "mm^4")

                    {
                        Lbl_Iz.Content = (rechteckHohl.FTM_Iz() * 1).ToString("0.###");

                    }

                    if (cbx_Iy.Text == "cm^4")
                    {
                        Lbl_Iz.Content = (rechteckHohl.FTM_Iz() / 10000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Polar
                    if (cbx_Polar.Text == "mm^4")

                    {
                        lbl_Polar.Content = (rechteckHohl.FTM_Polar() * 1).ToString("0.###");

                    }

                    if (cbx_Polar.Text == "cm^4")
                    {
                        lbl_Polar.Content = (rechteckHohl.FTM_Polar() / 10000).ToString("0.###");

                    }

                    //Hier Enden Die Comboboxen!
                }//Comboboxen Ergebnisfenster

                //Materialauswahl
                if (cb_Material_ReHo.Text == "Stahl")
                {
                    gewicht = rechteckHohl.Volumen() * 0.00000785;
                    preis = gewicht * 1.5;

                }

                if (cb_Material_ReHo.Text == "Aluminium")
                {
                    gewicht = rechteckHohl.Volumen() * 0.0000027;
                    preis = gewicht * 2.5;
                }


                grd_Ergebnisse.Visibility = Visibility.Visible;


                //Schwerpunkt
                lbl_GX.Content = (rechteckHohl.Breite / 2).ToString("0.###");
                lbl_Gy.Content = (rechteckHohl.Höhe / 2).ToString("0.###");
                lbl_Gz.Content = (rechteckHohl.Länge / 2).ToString("0.###");

                lbl_Gewicht.Content = gewicht.ToString("0.###");
                lbl_Preis.Content = preis.ToString("0.###");


                if (neu == null)
                {
                    neu = new ExcelApi();
                    neu.ExelControll();

                }

                neu.ExcelReHo(rechteckHohl);

                if (Neu.CatiaLaeuft())
                {
                    Neu.CatiaLaeuft();
                    Neu.ErzeugePart();
                    Neu.ErzeugeSkizze();
                    Neu.ErzeugeProfilRechteckHohl(rechteckHohl);
                    Neu.ErzeugeExtrusionRechteckHohl(rechteckHohl);
                }

                else
                {
                    MessageBox.Show("Laufende Catia Application nicht gefunden");
                }
            }


            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }
        
       private void btn_SeVo_berechnung_Click(object sender, RoutedEventArgs e)
        {   //Erzeugen eines Objektes vom Typ SechseckVollProfiö
             neuSechseckVoll = new SechseckVoll();
            CatiaAPIConection Neu = new CatiaAPIConection();

            try
            {

              
                    neuSechseckVoll.Radius = Convert.ToDouble(TxtBox_SeVo_Radius.Text);
                    neuSechseckVoll.Länge = Convert.ToDouble(TxtBox_SeVo_Länge.Text);
                
                    double gewicht = 0;
                    double preis = 0;


                {
                    //Hier Beginnen Die Comboxen Für ErgebnisFenster

                    //Für Qfläche
                    if (cbx_Qfläche.Text == "mm²")

                    {
                        lbl_qfläche.Content = (neuSechseckVoll.QFläche() * 1).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "cm²")
                    {
                        lbl_qfläche.Content = (neuSechseckVoll.QFläche() / 100).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "m²")
                    {
                        lbl_qfläche.Content = (neuSechseckVoll.QFläche() / 10000).ToString("0.###");

                    }

                    //Für Volumen
                    if (cbx_Volumen.Text == "mm³")

                    {
                        lbl_volumen.Content = (neuSechseckVoll.Volumen() * 1).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "cm³")
                    {
                        lbl_volumen.Content =( neuSechseckVoll.Volumen() / 1000).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "m³")
                    {
                        lbl_volumen.Content = (neuSechseckVoll.Volumen() / 1000000).ToString("0.###");

                    }

                    //Für Wiederstandsmoment Wx
                    if (cbx_Wx.Text == "mm³")

                    {
                        lbl_Wy.Content =( neuSechseckVoll.WiederstandsMoment_Wy() * 1).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "cm³")
                    {
                        lbl_Wy.Content = (neuSechseckVoll.WiederstandsMoment_Wy() / 1000).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "m³")
                    {
                        lbl_Wy.Content = (neuSechseckVoll.WiederstandsMoment_Wy() / 1000000).ToString("0.###");

                    }


                    //Für Wiederstandsmoment Wy
                    if (cbx_Wy.Text == "mm³")

                    {
                        lbl_Wz.Content = (neuSechseckVoll.WiederstandsMoment_Wz() * 1).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "cm³")
                    {
                        lbl_Wz.Content = (neuSechseckVoll.WiederstandsMoment_Wz() / 1000).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "m³")
                    {
                        lbl_Wz.Content = (neuSechseckVoll.WiederstandsMoment_Wz() / 1000000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Ix
                    if (cbx_Ix.Text == "mm^4")

                    {
                        lbl_Iy.Content = (neuSechseckVoll.FTM_Iy() * 1).ToString("0.###");

                    }

                    if (cbx_Ix.Text == "cm^4")
                    {
                        lbl_Iy.Content =( neuSechseckVoll.FTM_Iy() / 10000).ToString("0.###");

                    }




                    //Für TrägheitsMoment Iy
                    if (cbx_Iy.Text == "mm^4")

                    {
                        Lbl_Iz.Content = (neuSechseckVoll.FTM_Iz() * 1).ToString("0.###");

                    }

                    if (cbx_Iy.Text == "cm^4")
                    {
                        Lbl_Iz.Content = (neuSechseckVoll.FTM_Iz() / 10000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Polar
                    if (cbx_Polar.Text == "mm^4")

                    {
                        lbl_Polar.Content = (neuSechseckVoll.FTM_Polar() * 1).ToString("0.###");

                    }

                    if (cbx_Polar.Text == "cm^4")
                    {
                        lbl_Polar.Content = (neuSechseckVoll.FTM_Polar() / 10000).ToString("0.###");

                    }//Hier Enden Die Comboboxen!
                } // Comboboxen für Ergebnisfenster
                    
                    ///Auswahl Stahl
                    if (cb_Material_SeVoll.Text == "Stahl")
                    {///Berechnung
                        gewicht = neuSechseckVoll.Volumen() * 0.00000785;
                        preis = gewicht * 1.5;

                    }
                    /// Auswahl Aluminim
                    if (cb_Material_SeVoll.Text == "Aluminium")
                    {///Berechnung
                        gewicht = neuSechseckVoll.Volumen() * 0.0000027;
                        preis = gewicht * 2.5;
                    }

                    grd_Ergebnisse.Visibility = Visibility.Visible;

                //Schwerpunkt
                lbl_GX.Content = (neuSechseckVoll.Radius).ToString("0.###");
                lbl_Gy.Content = (neuSechseckVoll.Radius * 0.8667).ToString("0.###");
                lbl_Gz.Content = (neuSechseckVoll.Länge / 2).ToString("0.###");

                lbl_Gewicht.Content = gewicht.ToString("0.###");
                lbl_Preis.Content = preis.ToString("0.###");


                if (neu == null)
                {
                    neu = new ExcelApi();
                    neu.ExelControll();

                }


                neu.ExcelSeVo(neuSechseckVoll);


                if (Neu.CatiaLaeuft())
                {
                    Neu.CatiaLaeuft();
                    Neu.ErzeugePart();
                    Neu.ErzeugeSkizze();
                    Neu.ErzeugeSechseckVoll(neuSechseckVoll);
                    Neu.ErzeugeExtrusionSechseck(neuSechseckVoll);
                }
                else
                {
                    MessageBox.Show("Laufende Catia Application nicht gefunden");
                }

            }

            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        //Runde Profile
        private void btn_RuVo_berechnung_Click(object sender, RoutedEventArgs e)
        {       //Erzeugen eines Objektes vom Typ RunVollProfil
            neuRundVoll = new RundVollProfil();
            CatiaAPIConection Neu = new CatiaAPIConection();

            try
            {
            
                    neuRundVoll.Durchmesser = Convert.ToDouble(TxtBox_RuVo_Durchmesser.Text);
                    neuRundVoll.Länge = Convert.ToDouble(TxtBox_RuVo_Länge.Text);    

                    double gewicht = 0;
                    double preis = 0;


                {

                    //Hier Beginnen Die Comboxen Für ErgebnisFenster

                    //Für Qfläche
                    if (cbx_Qfläche.Text == "mm²")

                    {
                        lbl_qfläche.Content = (neuRundVoll.QFläche() * 1).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "cm²")
                    {
                        lbl_qfläche.Content = (neuRundVoll.QFläche() / 100).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "m²")
                    {
                        lbl_qfläche.Content = (neuRundVoll.QFläche() / 10000).ToString("0.###");

                    }

                    //Für Volumen
                    if (cbx_Volumen.Text == "mm³")

                    {
                        lbl_volumen.Content = (neuRundVoll.Volumen() * 1).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "cm³")
                    {
                        lbl_volumen.Content = (neuRundVoll.Volumen() / 1000).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "m³")
                    {
                        lbl_volumen.Content = (neuRundVoll.Volumen() / 1000000).ToString("0.###");

                    }

                    //Für Wiederstandsmoment Wx
                    if (cbx_Wx.Text == "mm³")

                    {
                        lbl_Wy.Content = (neuRundVoll.WiederstandsMoment_Wy() * 1).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "cm³")
                    {
                        lbl_Wy.Content = (neuRundVoll.WiederstandsMoment_Wy() / 1000).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "m³")
                    {
                        lbl_Wy.Content = (neuRundVoll.WiederstandsMoment_Wy() / 1000000).ToString("0.###");

                    }


                    //Für Wiederstandsmoment Wy
                    if (cbx_Wy.Text == "mm³")

                    {
                        lbl_Wy.Content = (neuRundVoll.WiederstandsMoment_Wz() * 1).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "cm³")
                    {
                        lbl_Wy.Content = (neuRundVoll.WiederstandsMoment_Wz() / 1000).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "m³")
                    {
                        lbl_Wy.Content = (neuRundVoll.WiederstandsMoment_Wz() / 1000000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Ix
                    if (cbx_Ix.Text == "mm^4")

                    {
                        lbl_Iy.Content = (neuRundVoll.FTM_Iy() * 1).ToString("0.###");

                    }

                    if (cbx_Ix.Text == "cm^4")
                    {
                        lbl_Iy.Content = (neuRundVoll.FTM_Iy() / 10000).ToString("0.###");

                    }




                    //Für TrägheitsMoment Iy
                    if (cbx_Iy.Text == "mm^4")

                    {
                        Lbl_Iz.Content = (neuRundVoll.FTM_Iz() * 1).ToString("0.###");

                    }

                    if (cbx_Iy.Text == "cm^4")
                    {
                        Lbl_Iz.Content = (neuRundVoll.FTM_Iz() / 10000).ToString("0.###");

                    }

                    //Für TrägheitsMoment Polar
                    if (cbx_Polar.Text == "mm^4")

                    {
                        lbl_Polar.Content = (neuRundVoll.FTM_Polar() * 1).ToString("0.###");

                    }

                    if (cbx_Polar.Text == "cm^4")
                    {
                        lbl_Polar.Content = (neuRundVoll.FTM_Polar() / 10000).ToString("0.###");

                    }

                    //Hier Enden Die Comboboxen!
                }//Comboboxen für das Ergebnisfenster 

                    ///Auswahl Stahl
                    if (cb_Material_RuVoll.Text=="Stahl")
                    {///Berechnung
                        gewicht = neuRundVoll.Volumen() * 0.00000785;
                        preis = gewicht * 1.5;
                    }

                    /// Auswahl Aluminim
                    if (cb_Material_RuVoll.Text=="Aluminium")
                    {///Berechnung
                        gewicht = neuRundVoll.Volumen() * 0.0000027;
                        preis = gewicht * 2.5;
                    }


                    grd_Ergebnisse.Visibility = Visibility.Visible;

                //Schwerpunkt
                lbl_GX.Content = (neuRundVoll.Durchmesser / 2).ToString("0.###");
                lbl_Gy.Content = (neuRundVoll.Durchmesser / 2).ToString("0.###");
                lbl_Gz.Content = (neuRundVoll.Länge / 2).ToString("0.###");

                lbl_Gewicht.Content = gewicht.ToString("0.###");
                lbl_Preis.Content = preis.ToString("0.###");

              


                if (neu == null)
                {
                    neu = new ExcelApi();
                    neu.ExelControll();

                }

                neu.ExcelRuVo(neuRundVoll);


                if (Neu.CatiaLaeuft())
                {
                    Neu.CatiaLaeuft();
                    Neu.ErzeugePart();
                    Neu.ErzeugeSkizze();
                    Neu.ErzeugeProfilRundVoll(neuRundVoll);
                    Neu.ErzeugeExtrusionRundVoll(neuRundVoll);
                }
                else
                {
                    MessageBox.Show("Laufende Catia Application nicht gefunden");
                }


            }

            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }
        private void btn_Rohr_berechnung_Click(object sender, RoutedEventArgs e)
        {   
            //Erzeugung eines neuen Objekts der Klasse RundHohlProfil
             neuRundHohl = new RundHohlProfil();
            CatiaAPIConection Neu = new CatiaAPIConection();


            try
            {

                neuRundHohl.Durchmesser = Convert.ToDouble(TxtBox_Rohr_Durchmesser.Text);
                neuRundHohl.Wandstärke = Convert.ToDouble(TxtBox_Rohr_Wandstärke.Text);
                neuRundHohl.Länge = Convert.ToDouble(TxtBox_Rohr_Länge.Text);
                



            double gewicht = 0;
                double preis = 0;



                {


                    //Hier Beginnen Die Comboxen Für ErgebnisFenster

                    //Für Qfläche
                    if (cbx_Qfläche.Text == "mm²")

                    {
                        lbl_qfläche.Content = (neuRundHohl.QFläche() * 1).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "cm²")
                    {
                        lbl_qfläche.Content = (neuRundHohl.QFläche() / 100).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "m²")
                    {
                        lbl_qfläche.Content = (neuRundHohl.QFläche() / 10000).ToString("0.###");

                    }

                    //Für Volumen
                    if (cbx_Volumen.Text == "mm³")

                    {
                        lbl_volumen.Content = (neuRundHohl.Volumen() * 1).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "cm³")
                    {
                        lbl_volumen.Content = (neuRundHohl.Volumen() / 1000).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "m³")
                    {
                        lbl_volumen.Content = (neuRundHohl.Volumen() / 1000000).ToString("0.###");

                    }

                    //Für Wiederstandsmoment Wx
                    if (cbx_Wx.Text == "mm³")

                    {
                        lbl_Wy.Content = (neuRundHohl.WiederstandsMoment_Wy() * 1).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "cm³")
                    {
                        lbl_Wy.Content = (neuRundHohl.WiederstandsMoment_Wy() / 1000).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "m³")
                    {
                        lbl_Wy.Content = (neuRundHohl.WiederstandsMoment_Wy() / 1000000).ToString("0.###");

                    }


                    //Für Wiederstandsmoment Wy
                    if (cbx_Wy.Text == "mm³")

                    {
                        lbl_Wz.Content = (neuRundHohl.WiederstandsMoment_Wz() * 1).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "cm³")
                    {
                        lbl_Wz.Content = (neuRundHohl.WiederstandsMoment_Wz() / 1000).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "m³")
                    {
                        lbl_Wz.Content = (neuRundHohl.WiederstandsMoment_Wz() / 1000000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Ix
                    if (cbx_Ix.Text == "mm^4")

                    {
                        lbl_Iy.Content = (neuRundHohl.FTM_Iy() * 1).ToString("0.###");

                    }

                    if (cbx_Ix.Text == "cm^4")
                    {
                        lbl_Iy.Content = (neuRundHohl.FTM_Iy() / 10000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Iy
                    if (cbx_Iy.Text == "mm^4")

                    {
                        Lbl_Iz.Content = (neuRundHohl.FTM_Iz() * 1).ToString("0.###");

                    }

                    if (cbx_Iy.Text == "cm^4")
                    {
                        Lbl_Iz.Content = (neuRundHohl.FTM_Iz() / 10000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Polar
                    if (cbx_Polar.Text == "mm^4")

                    {
                        lbl_Polar.Content = (neuRundHohl.FTM_Polar() * 1).ToString("0.###");

                    }

                    if (cbx_Polar.Text == "cm^4")
                    {
                        lbl_Polar.Content = (neuRundHohl.FTM_Polar() / 10000).ToString("0.###");

                    }


                    //Hier Enden Die Comboboxen!
                }// Combboxen Ergebnisfenster
                ///Auswahl Stahl
                if (cb_Material_RuHo.Text == "Stahl")
                {///Berechnung
                    gewicht = neuRundHohl.Volumen() * 0.00000785;
                    preis = gewicht * 1.5;
                }
                /// Auswahl Aluminim
                if (cb_Material_RuHo.Text == "Aluminium")
                {///Berechnung
                    gewicht = neuRundHohl.Volumen() * 0.0000027;
                    preis = gewicht * 2.5;
                }


                grd_Ergebnisse.Visibility = Visibility.Visible;

                //Schwerpunkt
                lbl_GX.Content = (neuRundHohl.Durchmesser / 2).ToString("0.###");
                lbl_Gy.Content = (neuRundHohl.Durchmesser / 2).ToString("0.###");
                lbl_Gz.Content = (neuRundHohl.Länge / 2).ToString("0.###");

                lbl_Gewicht.Content = gewicht.ToString("0.###");
                lbl_Preis.Content = preis.ToString("0.###");


                if (neu == null)
                {
                    neu = new ExcelApi();
                    neu.ExelControll();

                }


                neu.ExcelRundHo(neuRundHohl);


                if (Neu.CatiaLaeuft())
                {
                Neu.CatiaLaeuft();
                Neu.ErzeugePart();
                Neu.ErzeugeSkizze();
                Neu.ErzeugeProfilRundHohlProfil(neuRundHohl);
                Neu.ErzeugeExtrusionRundHohlProfil(neuRundHohl);
                }

                else
                {
                MessageBox.Show("Laufende Catia Application nicht gefunden");
                 }

            }

            catch
            {
                MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error);
            }




        }
        private void btn_HaRu_berechnung_Click(object sender, RoutedEventArgs e)
        {   
            //Erzeugun eines Objektes der klasse HalbRundProfil
            neuHalbRund = new HalbrundProfil();
            CatiaAPIConection Neu = new CatiaAPIConection();

            try
            {

             
                    neuHalbRund.Radius = Convert.ToDouble(TxtBox_HaRu_Radius.Text);
                    neuHalbRund.Länge = Convert.ToDouble(TxtBox_HaRu_Länge.Text);

             

                    double gewicht = 0;
                    double preis = 0;

               

                {


                    //Hier Beginnen Die Comboxen Für ErgebnisFenster

                    //Für Qfläche
                    if (cbx_Qfläche.Text == "mm²")

                    {
                        lbl_qfläche.Content = (neuHalbRund.QFläche() * 1).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "cm²")
                    {
                        lbl_qfläche.Content = (neuHalbRund.QFläche() / 100).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "m²")
                    {
                        lbl_qfläche.Content = (neuHalbRund.QFläche() / 10000).ToString("0.###");

                    }

                    //Für Volumen
                    if (cbx_Volumen.Text == "mm³")

                    {
                        lbl_volumen.Content = (neuHalbRund.Volumen() * 1).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "cm³")
                    {
                        lbl_volumen.Content = (neuHalbRund.Volumen() / 1000).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "m³")
                    {
                        lbl_volumen.Content = (neuHalbRund.Volumen() / 1000000).ToString("0.###");

                    }

                    //Für Wiederstandsmoment Wx
                    if (cbx_Wx.Text == "mm³")

                    {
                        lbl_Wy.Content = (neuHalbRund.WiederstandsMoment_Wy() * 1).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "cm³")
                    {
                        lbl_Wy.Content = (neuHalbRund.WiederstandsMoment_Wy() / 1000).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "m³")
                    {
                        lbl_Wy.Content = (neuHalbRund.WiederstandsMoment_Wy() / 1000000).ToString("0.###");

                    }


                    //Für Wiederstandsmoment Wy
                    if (cbx_Wy.Text == "mm³")

                    {
                        lbl_Wz.Content = (neuHalbRund.WiederstandsMoment_Wz() * 1).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "cm³")
                    {
                        lbl_Wz.Content = (neuHalbRund.WiederstandsMoment_Wz() / 1000).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "m³")
                    {
                        lbl_Wz.Content = (neuHalbRund.WiederstandsMoment_Wz() / 1000000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Ix
                    if (cbx_Ix.Text == "mm^4")

                    {
                        lbl_Iy.Content = (neuHalbRund.FTM_Iy() * 1).ToString("0.###");

                    }

                    if (cbx_Ix.Text == "cm^4")
                    {
                        lbl_Iy.Content = (neuHalbRund.FTM_Iy() / 10000).ToString("0.###");

                    }




                    //Für TrägheitsMoment Iy
                    if (cbx_Iy.Text == "mm^4")

                    {
                        Lbl_Iz.Content = (neuHalbRund.FTM_Iz() * 1).ToString("0.###");

                    }

                    if (cbx_Iy.Text == "cm^4")
                    {
                        Lbl_Iz.Content = (neuHalbRund.FTM_Iz() / 10000).ToString("0.###");

                    }





                    //Für TrägheitsMoment Polar
                    if (cbx_Polar.Text == "mm^4")

                    {
                        lbl_Polar.Content = (neuHalbRund.FTM_Polar() * 1).ToString("0.###");

                    }

                    if (cbx_Polar.Text == "cm^4")
                    {
                        lbl_Polar.Content = (neuHalbRund.FTM_Polar() / 10000).ToString("0.###");

                    }


                    //Hier Enden Die Comboboxen!
                }//Comboboxen Ergebnisfenster

                    ///Auswahl Stahl
                    if (cb_Material_HaRu.Text == "Stahl")
                    {///Berechnung
                        gewicht = neuHalbRund.Volumen() * 0.00000785;
                        preis = gewicht * 1.5;

                    }
                    /// Auswahl Aluminim
                    if (cb_Material_HaRu.Text == "Aluminium")
                    {///Berechnung
                        gewicht = neuHalbRund.Volumen() * 0.0000027;
                        preis = gewicht * 2.5;
                    }

                    grd_Ergebnisse.Visibility = Visibility.Visible;

                //Schwerpunkt
                lbl_GX.Content = (neuHalbRund.Radius).ToString("0.###");
                lbl_Gy.Content = ((4 * neuHalbRund.Radius) / (3 * Math.PI)).ToString("0.###");
                lbl_Gz.Content = (neuHalbRund.Länge / 2).ToString("0.###");

                lbl_Gewicht.Content = gewicht.ToString("0.###");
                lbl_Preis.Content = preis.ToString("0.###");

                if (neu == null)
                {
                    neu = new ExcelApi();
                    neu.ExelControll();

                }


                neu.ExcelHaRu(neuHalbRund);

                if (Neu.CatiaLaeuft())
                {
                    Neu.CatiaLaeuft();
                    Neu.ErzeugePart();
                    Neu.ErzeugeSkizze();
                    Neu.ErzeugeProfilHalbRund(neuHalbRund);
                    Neu.ErzeugeExtrusionHalbRund(neuHalbRund);
                }
                else
                {
                    MessageBox.Show("Laufende Catia Application nicht gefunden");
                }



            }

            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error);
            
            }

        }


        //Form Profile
        private void btn_TPro_berechnung_Click(object sender, RoutedEventArgs e)
        {   

            //Erzeugung eines Objektes der Klasse TProfil
             neuTProfil = new TProfil();
            CatiaAPIConection Neu = new CatiaAPIConection();

            try
            {
     
                    neuTProfil.H1 = Convert.ToDouble(TxtBox_TPro_Höhe.Text);
                    neuTProfil.B1 = Convert.ToDouble(TxtBox_TPro_Breite.Text);
                    neuTProfil.Länge = Convert.ToDouble(TxtBox_TPro_Länge.Text);
                    neuTProfil.H2 = Convert.ToDouble(TxtBox_TPro_Wandstärkeh.Text);
                    neuTProfil.B2 = Convert.ToDouble(TxtBox_TPro_Wandstärkeb.Text);
      
                double gewicht = 0;
                    double preis = 0;

              

                {


                    //Hier Beginnen Die Comboxen Für ErgebnisFenster

                    //Für Qfläche
                    if (cbx_Qfläche.Text == "mm²")

                    {
                        lbl_qfläche.Content = (neuTProfil.QFläche() * 1).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "cm²")
                    {
                        lbl_qfläche.Content = (neuTProfil.QFläche() / 100).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "m²")
                    {
                        lbl_qfläche.Content = (neuTProfil.QFläche() / 10000).ToString("0.###");

                    }

                    //Für Volumen
                    if (cbx_Volumen.Text == "mm³")

                    {
                        lbl_volumen.Content = (neuTProfil.Volumen() * 1).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "cm³")
                    {
                        lbl_volumen.Content = (neuTProfil.Volumen() / 1000).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "m³")
                    {
                        lbl_volumen.Content = (neuTProfil.Volumen() / 1000000).ToString("0.###");

                    }

                    //Für Wiederstandsmoment Wx
                    if (cbx_Wx.Text == "mm³")

                    {
                        lbl_Wy.Content = (neuTProfil.WiederstandsMoment_Wy() * 1).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "cm³")
                    {
                        lbl_Wy.Content = (neuTProfil.WiederstandsMoment_Wy()/ 1000).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "m³")
                    {
                        lbl_Wy.Content = (neuTProfil.WiederstandsMoment_Wy() / 1000000).ToString("0.###");

                    }


                    //Für Wiederstandsmoment Wy
                    if (cbx_Wy.Text == "mm³")

                    {
                        lbl_Wz.Content = (neuTProfil.WiederstandsMoment_Wz() * 1).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "cm³")
                    {
                        lbl_Wz.Content = (neuTProfil.WiederstandsMoment_Wz() / 1000).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "m³")
                    {
                        lbl_Wz.Content = (neuTProfil.WiederstandsMoment_Wz() / 1000000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Ix
                    if (cbx_Ix.Text == "mm^4")

                    {
                        lbl_Iy.Content = (neuTProfil.FTM_Iy() * 1).ToString("0.###");

                    }

                    if (cbx_Ix.Text == "cm^4")
                    {
                        lbl_Iy.Content = (neuTProfil.FTM_Iy()/ 10000).ToString("0.###");

                    }




                    //Für TrägheitsMoment Iy
                    if (cbx_Iy.Text == "mm^4")

                    {
                        Lbl_Iz.Content =(neuTProfil.FTM_Iz() * 1).ToString("0.###");

                    }

                    if (cbx_Iy.Text == "cm^4")
                    {
                        Lbl_Iz.Content =( neuTProfil.FTM_Iz() / 10000).ToString("0.###");

                    }





                    //Für TrägheitsMoment Polar
                    if (cbx_Polar.Text == "mm^4")

                    {
                        lbl_Polar.Content = (neuTProfil.FTM_Polar() * 1).ToString("0.###");

                    }

                    if (cbx_Polar.Text == "cm^4")
                    {
                        lbl_Polar.Content = (neuTProfil.FTM_Polar() / 10000).ToString("0.###");

                    }


                    //Hier Enden Die Comboboxen!
                } // Comboboxen Ergebnisfenster

                    ///Auswahl Stahl
                    if (cb_Material_TPro.Text == "Stahl")
                    {///Berechnung
                        gewicht = neuTProfil.Volumen() * 0.00000785;
                        preis = gewicht * 1.5;

                    }
                    /// Auswahl Aluminim
                    if (cb_Material_TPro.Text == "Aluminium")
                    {///Berechnung
                        gewicht = neuTProfil.Volumen() * 0.0000027;
                        preis = gewicht * 2.5;
                    }

                    grd_Ergebnisse.Visibility = Visibility.Visible;

                //Schwerpunkt
                lbl_GX.Content = (neuTProfil.B1 / 2).ToString("0.###");
                lbl_Gy.Content = (((((neuTProfil.H1 - neuTProfil.H2) / 2) * neuTProfil.H1 * neuTProfil.B2) + ((neuTProfil.H1 - (neuTProfil.H2 / 2)) * neuTProfil.B1 * neuTProfil.H2)) / ((neuTProfil.H1 * neuTProfil.B2) + (neuTProfil.B1 * neuTProfil.H2))).ToString("0.###");
                lbl_Gz.Content = (neuTProfil.Länge / 2).ToString("0.###");


                lbl_Gewicht.Content = gewicht.ToString("0.###");
                lbl_Preis.Content = preis.ToString("0.###");

                if (neu == null)
                {
                    neu = new ExcelApi();
                    neu.ExelControll();

                }


                neu.ExcelTProfil(neuTProfil);


                if (Neu.CatiaLaeuft())
                {
                    Neu.CatiaLaeuft();
                    Neu.ErzeugePart();
                    Neu.ErzeugeSkizze();
                    Neu.ErzeugeTProfil(neuTProfil);
                    Neu.ErzeugeExtrusionT(neuTProfil);
                }
                else
                {
                    MessageBox.Show("Laufende Catia Application nicht gefunden");
                }


            }
            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void btn_UPro_berechnung_Click(object sender, RoutedEventArgs e)
        {   

            //Erzeugung des Objektes der Klasse UProfil
            neuUProfil = new UProfil();
            CatiaAPIConection Neu = new CatiaAPIConection();

            try
            {

                neuUProfil.H1 = Convert.ToDouble(TxtBox_UPro_Höhe.Text);
                neuUProfil.B1 = Convert.ToDouble(TxtBox_UPro_Breite.Text);
                neuUProfil.Länge = Convert.ToDouble(TxtBox_UPro_Länge.Text);
                neuUProfil.H2 = Convert.ToDouble(TxtBox_UPro_Wandstärkeh.Text);
                neuUProfil.B2 = Convert.ToDouble(TxtBox_UPro_Wandstärkeb.Text);


                double gewicht = 0;
                double preis = 0;

               

                {

                    //Hier Beginnen Die Comboxen Für ErgebnisFenster

                    //Für Qfläche
                    if (cbx_Qfläche.Text == "mm²")

                    {
                        lbl_qfläche.Content = (neuUProfil.QFläche() * 1).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "cm²")
                    {
                        lbl_qfläche.Content = (neuUProfil.QFläche() / 100).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "m²")
                    {
                        lbl_qfläche.Content = (neuUProfil.QFläche() / 10000).ToString("0.###");

                    }

                    //Für Volumen
                    if (cbx_Volumen.Text == "mm³")

                    {
                        lbl_volumen.Content = (neuUProfil.Volumen() * 1).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "cm³")
                    {
                        lbl_volumen.Content = (neuUProfil.Volumen() / 1000).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "m³")
                    {
                        lbl_volumen.Content = (neuUProfil.Volumen() / 1000000).ToString("0.###");

                    }

                    //Für Wiederstandsmoment Wx
                    if (cbx_Wx.Text == "mm³")

                    {
                         lbl_Wy.Content = (neuUProfil.WiederstandsMoment_Wy() * 1).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "cm³")
                    {
                        lbl_Wy.Content = (neuUProfil.WiederstandsMoment_Wy() / 1000).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "m³")
                    {
                        lbl_Wy.Content = (neuUProfil.WiederstandsMoment_Wy() / 1000000).ToString("0.###");

                    }


                    //Für Wiederstandsmoment Wy
                    if (cbx_Wy.Text == "mm³")

                    {
                        lbl_Wz.Content = (neuUProfil.WiederstandsMoment_Wz() * 1).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "cm³")
                    {
                        lbl_Wz.Content = (neuUProfil.WiederstandsMoment_Wz() / 1000).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "m³")
                    {
                        lbl_Wz.Content = (neuUProfil.WiederstandsMoment_Wz() / 1000000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Ix
                    if (cbx_Ix.Text == "mm^4")

                    {
                        lbl_Iy.Content = (neuUProfil.FTM_Iy() * 1).ToString("0.###");

                    }

                    if (cbx_Ix.Text == "cm^4")
                    {
                        lbl_Iy.Content = (neuUProfil.FTM_Iy() / 10000).ToString("0.###");

                    }




                    //Für TrägheitsMoment Iy
                    if (cbx_Iy.Text == "mm^4")

                    {
                        Lbl_Iz.Content = (neuUProfil.FTM_Iz() * 1).ToString("0.###");

                    }

                    if (cbx_Iy.Text == "cm^4")
                    {
                        Lbl_Iz.Content = (neuUProfil.FTM_Iz() / 10000).ToString("0.###");

                    }





                    //Für TrägheitsMoment Polar
                    if (cbx_Polar.Text == "mm^4")

                    {
                        lbl_Polar.Content = (neuUProfil.FTM_Polar() * 1).ToString("0.###");

                    }

                    if (cbx_Polar.Text == "cm^4")
                    {
                        lbl_Polar.Content = (neuUProfil.FTM_Polar() / 10000).ToString("0.###");

                    }


                    //Hier Enden Die Comboboxen!

                } //Comboxen Ergebnisfenster

                    ///Auswahl Stahl
                    if (cb_Material_UPro.Text == "Stahl")
                    {///Berechnung
                        gewicht = neuUProfil.Volumen() * 0.00000785;
                        preis = gewicht * 1.5;

                    }
                    /// Auswahl Aluminim
                    if (cb_Material_UPro.Text == "Aluminium")
                    {///Berechnung
                        gewicht = neuUProfil.Volumen() * 0.0000027;
                        preis = gewicht * 2.5;
                    }

                    grd_Ergebnisse.Visibility = Visibility.Visible;

                //Schwerpunkt
                lbl_GX.Content = ((((neuUProfil.H1 - (neuUProfil.H2 / 2)) * neuUProfil.H2 * neuUProfil.B1) + ((neuUProfil.H1 / 2) * (neuUProfil.H1 - 2 * neuUProfil.H2) * neuUProfil.B2) + (neuUProfil.H2 * neuUProfil.H2 * neuUProfil.B1 / 2)) / ((neuUProfil.B1 * neuUProfil.H2) + ((neuUProfil.H1 - 2 * neuUProfil.H2) * neuUProfil.B1) + (neuUProfil.H2 * neuUProfil.B1))).ToString("0.###");
                lbl_Gy.Content = (neuUProfil.H1 / 2).ToString("0.###");
                lbl_Gz.Content = (neuUProfil.Länge / 2).ToString("0.###");


                lbl_Gewicht.Content = gewicht.ToString("0.###");
                lbl_Preis.Content = preis.ToString("0.###");



                if (neu == null)
                {
                    neu = new ExcelApi();
                    neu.ExelControll();

                }


                neu.ExcelUProfil(neuUProfil);


                if (Neu.CatiaLaeuft())
                {
                    Neu.CatiaLaeuft();
                    Neu.ErzeugePart();
                    Neu.ErzeugeSkizze();
                    Neu.ErzeugeUProfil(neuUProfil);
                    Neu.ErzeugeExtrusionU(neuUProfil);
                }
                else
                {
                    MessageBox.Show("Laufende Catia Application nicht gefunden");
                }

            }

            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void btn_IPro_berechnung_Click(object sender, RoutedEventArgs e)
        {   
            //Erzeugung eines Objektes der Klasse IProfil
            neuIProfil = new IProfil();
            CatiaAPIConection Neu = new CatiaAPIConection();

            try
            {

                neuIProfil.H1 = Convert.ToDouble(TxtBox_IPro_Höhe.Text);
                neuIProfil.B1 = Convert.ToDouble(TxtBox_IPro_Breite.Text);
                neuIProfil.Länge = Convert.ToDouble(TxtBox_IPro_Länge.Text);
                neuIProfil.H2 = Convert.ToDouble(TxtBox_IPro_Wandstärkeh.Text);
                neuIProfil.B2 = Convert.ToDouble(TxtBox_IPro_Wandstärkeb.Text);

              
                double gewicht = 0;
                double preis = 0;

               


                {

                    //Hier Beginnen Die Comboxen Für ErgebnisFenster

                    //Für Qfläche
                    if (cbx_Qfläche.Text == "mm²")

                    {
                        lbl_qfläche.Content = (neuIProfil.QFläche() * 1).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "cm²")
                    {
                        lbl_qfläche.Content = (neuIProfil.QFläche() / 100).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "m²")
                    {
                        lbl_qfläche.Content = (neuIProfil.QFläche() / 10000).ToString("0.###");

                    }

                    //Für Volumen
                    if (cbx_Volumen.Text == "mm³")

                    {
                        lbl_volumen.Content = (neuIProfil.Volumen() * 1).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "cm³")
                    {
                        lbl_volumen.Content = (neuIProfil.Volumen() / 1000).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "m³")
                    {
                        lbl_volumen.Content = (neuIProfil.Volumen() / 1000000).ToString("0.###");

                    }

                    //Für Wiederstandsmoment Wx
                    if (cbx_Wx.Text == "mm³")

                    {
                        lbl_Wy.Content = (neuIProfil.WiederstandsMoment_Wy() * 1).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "cm³")
                    {
                        lbl_Wy.Content = (neuIProfil.WiederstandsMoment_Wy() / 1000).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "m³")
                    {
                        lbl_Wy.Content = (neuIProfil.WiederstandsMoment_Wy() / 1000000).ToString("0.###");

                    }


                    //Für Wiederstandsmoment Wy
                    if (cbx_Wy.Text == "mm³")

                    {
                        lbl_Wz.Content = (neuIProfil.WiederstandsMoment_Wz() * 1).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "cm³")
                    {
                        lbl_Wz.Content = (neuIProfil.WiederstandsMoment_Wz() / 1000).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "m³")
                    {
                        lbl_Wz.Content = (neuIProfil.WiederstandsMoment_Wz() / 1000000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Ix
                    if (cbx_Ix.Text == "mm^4")

                    {
                        lbl_Iy.Content = (neuIProfil.FTM_Iy() * 1).ToString("0.###");

                    }

                    if (cbx_Ix.Text == "cm^4")
                    {
                        lbl_Iy.Content = (neuIProfil.FTM_Iy() / 10000).ToString("0.###");

                    }




                    //Für TrägheitsMoment Iy
                    if (cbx_Iy.Text == "mm^4")

                    {
                        Lbl_Iz.Content = (neuIProfil.FTM_Iz() * 1).ToString("0.###");

                    }

                    if (cbx_Iy.Text == "cm^4")
                    {
                        Lbl_Iz.Content = (neuIProfil.FTM_Iz() / 10000).ToString("0.###");

                    }





                    //Für TrägheitsMoment Polar
                    if (cbx_Polar.Text == "mm^4")

                    {
                        lbl_Polar.Content =( neuIProfil.FTM_Polar() * 1).ToString("0.###");

                    }

                    if (cbx_Polar.Text == "cm^4")
                    {
                        lbl_Polar.Content = (neuIProfil.FTM_Polar() / 10000).ToString("0.###");

                    }


                    //Hier Enden Die Comboboxen!
                } //Combobox für Ergebnisfenster

                    ///Auswahl Stahl
                    if (cb_Material_IPro.Text == "Stahl")
                    {///Berechnung
                        gewicht = neuIProfil.Volumen() * 0.00000785;
                        preis = gewicht * 1.5;

                    }
                    /// Auswahl Aluminim
                    if (cb_Material_IPro.Text == "Aluminium")
                    {///Berechnung
                        gewicht = neuIProfil.Volumen() * 0.0000027;
                        preis = gewicht * 2.5;
                    }

                    grd_Ergebnisse.Visibility = Visibility.Visible;

                //Schwerpunkt
                lbl_GX.Content = (neuIProfil.B1 / 2).ToString("0.###");
                lbl_Gy.Content = (neuIProfil.H1 / 2).ToString("0.###");
                lbl_Gz.Content = (neuIProfil.Länge / 2).ToString("0.###");

                lbl_Gewicht.Content = gewicht.ToString("0.###");
                lbl_Preis.Content = preis.ToString("0.###");



                if (neu == null)
                {
                    neu = new ExcelApi();
                    neu.ExelControll();

                }


                neu.ExcelIProfil(neuIProfil);


                if (Neu.CatiaLaeuft())
                {
                    Neu.CatiaLaeuft();
                    Neu.ErzeugePart();
                    Neu.ErzeugeSkizze();
                    Neu.ErzeugeIProfil(neuIProfil);
                    Neu.ErzeugeExtrusionI(neuIProfil);
                }
                else
                {
                    MessageBox.Show("Laufende Catia Application nicht gefunden");
                }


            }
            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }
     
        private void btn_LPro_Berechnung_Click(object sender, RoutedEventArgs e)
        {
            neuLProfil = new LProfil();
            CatiaAPIConection Neu = new CatiaAPIConection();

            try
            {

                neuLProfil.H1 = Convert.ToDouble(TxtBox_LPro_Höhe.Text);
                neuLProfil.B1 = Convert.ToDouble(TxtBox_LPro_Breite.Text);
                neuLProfil.Länge = Convert.ToDouble(TxtBox_LPro_Länge.Text);
                neuLProfil.H2 = Convert.ToDouble(TxtBox_LPro_Wandstärkeh.Text);
                neuLProfil.B2 = Convert.ToDouble(TxtBox_LPro_Wandstärkeb.Text);
           
                double gewicht = 0;
                double preis = 0;

               


                {
                    //Hier Beginnen Die Comboxen Für ErgebnisFenster

                    //Für Qfläche
                    if (cbx_Qfläche.Text == "mm²")

                    {
                        lbl_qfläche.Content =( neuLProfil.QFläche() * 1).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "cm²")
                    {
                        lbl_qfläche.Content =( neuLProfil.QFläche() / 100).ToString("0.###");

                    }

                    if (cbx_Qfläche.Text == "m²")
                    {
                        lbl_qfläche.Content = (neuLProfil.QFläche() / 10000).ToString("0.###");

                    }

                    //Für Volumen
                    if (cbx_Volumen.Text == "mm³")

                    {
                        lbl_volumen.Content = (neuLProfil.Volumen() * 1).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "cm³")
                    {
                        lbl_volumen.Content = (neuLProfil.Volumen() / 1000).ToString("0.###");

                    }

                    if (cbx_Volumen.Text == "m³")
                    {
                        lbl_volumen.Content = (neuLProfil.Volumen() / 1000000).ToString("0.###");

                    }

                    //Für Wiederstandsmoment Wx
                    if (cbx_Wx.Text == "mm³")

                    {
                        lbl_Wy.Content = (neuLProfil.WiederstandsMoment_Wy() * 1).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "cm³")
                    {
                        lbl_Wy.Content = (neuLProfil.WiederstandsMoment_Wy() / 1000).ToString("0.###");

                    }

                    if (cbx_Wx.Text == "m³")
                    {
                        lbl_Wy.Content = (neuLProfil.WiederstandsMoment_Wy() / 1000000).ToString("0.###");

                    }


                    //Für Wiederstandsmoment Wy
                    if (cbx_Wy.Text == "mm³")

                    {
                        lbl_Wz.Content = (neuLProfil.WiederstandsMoment_Wz() * 1).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "cm³")
                    {
                        lbl_Wz.Content = (neuLProfil.WiederstandsMoment_Wz() / 1000).ToString("0.###");

                    }

                    if (cbx_Wy.Text == "m³")
                    {
                        lbl_Wz.Content = (neuLProfil.WiederstandsMoment_Wz() / 1000000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Ix
                    if (cbx_Ix.Text == "mm^4")

                    {
                        lbl_Iy.Content = (neuLProfil.FTM_Iy() * 1).ToString("0.###");

                    }

                    if (cbx_Ix.Text == "cm^4")
                    {
                        lbl_Iy.Content = (neuLProfil.FTM_Iy() / 10000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Iy
                    if (cbx_Iy.Text == "mm^4")

                    {
                        Lbl_Iz.Content = (neuLProfil.FTM_Iz() * 1).ToString("0.###");

                    }

                    if (cbx_Iy.Text == "cm^4")
                    {
                        Lbl_Iz.Content = (neuLProfil.FTM_Iz() / 10000).ToString("0.###");

                    }


                    //Für TrägheitsMoment Polar
                    if (cbx_Polar.Text == "mm^4")

                    {
                        lbl_Polar.Content = (neuLProfil.FTM_Polar() * 1).ToString("0.###");

                    }

                    if (cbx_Polar.Text == "cm^4")
                    {
                        lbl_Polar.Content = (neuLProfil.FTM_Polar() / 10000).ToString("0.###");

                    }


                    //Hier Enden Die Comboboxen!
                }//Combobox Ergebnisfenster

                    ///Auswahl Stahl
                    if (cb_Material_LPro.Text == "Stahl")
                    {///Berechnung
                        gewicht = neuLProfil.Volumen() * 0.00000785;
                        preis = gewicht * 1.5;

                    }
                    /// Auswahl Aluminim
                    if (cb_Material_LPro.Text == "Aluminium")
                    {///Berechnung
                        gewicht = neuLProfil.Volumen() * 0.0000027;
                        preis = gewicht * 2.5;
                    }

                    grd_Ergebnisse.Visibility = Visibility.Visible;

                //Schwerpunkt
                lbl_GX.Content = (((neuLProfil.B2 / 2 * neuLProfil.H1 * neuLProfil.B2) + (((neuLProfil.B1 - neuLProfil.B2) / 2 + neuLProfil.B2) * neuLProfil.H2 * (neuLProfil.B1 - neuLProfil.B2))) / ((neuLProfil.H1 * neuLProfil.B2) + (neuLProfil.H2 * (neuLProfil.B1 - neuLProfil.B2)))).ToString("0.###");
                lbl_Gy.Content = (((neuLProfil.H1 * neuLProfil.H1 * neuLProfil.B2 / 2) + (neuLProfil.H2 * (neuLProfil.B1 - neuLProfil.B2) * neuLProfil.H2 / 2)) / ((neuLProfil.H1 * neuLProfil.B2) + (neuLProfil.H2 * (neuLProfil.B1 - neuLProfil.B2)))).ToString("0.###");
                lbl_Gz.Content = (neuLProfil.Länge / 2).ToString("0.###");

                lbl_Gewicht.Content = gewicht.ToString("0.###");
                lbl_Preis.Content = preis.ToString("0.###");



                if (neu == null)
                {
                    neu = new ExcelApi();
                    neu.ExelControll();

                }


                neu.ExcelLProfil(neuLProfil);


                if (Neu.CatiaLaeuft())
                {
                    Neu.CatiaLaeuft();
                    Neu.ErzeugePart();
                    Neu.ErzeugeSkizze();
                    Neu.ErzeugeLProfil(neuLProfil);
                    Neu.ErzeugeExtrusionL(neuLProfil);
                }
                else
                {
                    MessageBox.Show("Laufende Catia Application nicht gefunden");
                }


            }
            catch
            { MessageBox.Show("Ihre Eingabe war Fehlerhaft! Bitte verwenden Sie nur Zahlen!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void btn_Schwerpunkt(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Schwerpunkt Gx: " + lbl_GX.Content + Environment.NewLine + "Schwerpunkt Gy: " + lbl_Gy.Content + Environment.NewLine + "Schwerpunkt Gz: " + lbl_Gz.Content , "Schwerpunktsberechnung" ,MessageBoxButton.OK , MessageBoxImage.Information);
        }
        //Hier Enden die Berechnungsbuttons


        private void cb_Material_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }




        //Comboboxen (Umrechnung)
        private void cbx_Qfläche_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Bedingung Rechteckige Profile
            if (rechteckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Qfläche.SelectedIndex == 0)
                {

                    lbl_qfläche.Content = Convert.ToDouble(rechteckVoll.QFläche()) * 1;



                }

                if (cbx_Qfläche.SelectedIndex == 1)
                {


                    lbl_qfläche.Content = Convert.ToDouble(rechteckVoll.QFläche()) / 100;

                }

                if (cbx_Qfläche.SelectedIndex == 2)
                {

                    lbl_qfläche.Content = Convert.ToDouble(rechteckVoll.QFläche()) / 10000;

                }

            }
            if (rechteckHohl != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Qfläche.SelectedIndex == 0)
                {

                    lbl_qfläche.Content = Convert.ToDouble(rechteckHohl.QFläche()) * 1;



                }

                if (cbx_Qfläche.SelectedIndex == 1)
                {


                    lbl_qfläche.Content = Convert.ToDouble(rechteckHohl.QFläche()) / 100;

                }

                if (cbx_Qfläche.SelectedIndex == 2)
                {

                    lbl_qfläche.Content = Convert.ToDouble(rechteckHohl.QFläche()) / 10000;

                }

            }
            if (neuSechseckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Qfläche.SelectedIndex == 0)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuSechseckVoll.QFläche()) * 1;



                }

                if (cbx_Qfläche.SelectedIndex == 1)
                {


                    lbl_qfläche.Content = Convert.ToDouble(neuSechseckVoll.QFläche()) / 100;

                }

                if (cbx_Qfläche.SelectedIndex == 2)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuSechseckVoll.QFläche()) / 10000;

                }

            }
            //Bedingung RundeProfile
            if (neuRundVoll != null)
            {
                if (cbx_Qfläche.SelectedIndex == 0)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuRundVoll.QFläche()) * 1;



                }

                if (cbx_Qfläche.SelectedIndex == 1)
                {


                    lbl_qfläche.Content = Convert.ToDouble(neuRundVoll.QFläche()) / 100;

                }

                if (cbx_Qfläche.SelectedIndex == 2)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuRundVoll.QFläche()) / 10000;

                }
            }
            if (neuRundHohl != null)
            {
                if (cbx_Qfläche.SelectedIndex == 0)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuRundHohl.QFläche()) * 1;



                }

                if (cbx_Qfläche.SelectedIndex == 1)
                {


                    lbl_qfläche.Content = Convert.ToDouble(neuRundHohl.QFläche()) / 100;

                }

                if (cbx_Qfläche.SelectedIndex == 2)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuRundHohl.QFläche()) / 10000;

                }
            }
            if (neuHalbRund != null)
            {
                if (cbx_Qfläche.SelectedIndex == 0)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuHalbRund.QFläche()) * 1;



                }

                if (cbx_Qfläche.SelectedIndex == 1)
                {


                    lbl_qfläche.Content = Convert.ToDouble(neuHalbRund.QFläche()) / 100;

                }

                if (cbx_Qfläche.SelectedIndex == 2)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuHalbRund.QFläche()) / 10000;

                }
            }
            //Bedingung Formprofile
            if (neuTProfil != null)
            {
                if (cbx_Qfläche.SelectedIndex == 0)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuTProfil.QFläche()) * 1;



                }

                if (cbx_Qfläche.SelectedIndex == 1)
                {


                    lbl_qfläche.Content = Convert.ToDouble(neuTProfil.QFläche()) / 100;

                }

                if (cbx_Qfläche.SelectedIndex == 2)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuTProfil.QFläche()) / 10000;

                }
            }
            if (neuLProfil != null)
            {
                if (cbx_Qfläche.SelectedIndex == 0)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuLProfil.QFläche()) * 1;



                }

                if (cbx_Qfläche.SelectedIndex == 1)
                {


                    lbl_qfläche.Content = Convert.ToDouble(neuLProfil.QFläche()) / 100;

                }

                if (cbx_Qfläche.SelectedIndex == 2)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuLProfil.QFläche()) / 10000;

                }
            }
            if (neuUProfil != null)
            {
                if (cbx_Qfläche.SelectedIndex == 0)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuUProfil.QFläche()) * 1;



                }

                if (cbx_Qfläche.SelectedIndex == 1)
                {


                    lbl_qfläche.Content = Convert.ToDouble(neuUProfil.QFläche()) / 100;

                }

                if (cbx_Qfläche.SelectedIndex == 2)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuUProfil.QFläche()) / 10000;

                }
            }
            if (neuIProfil != null)
            {
                if (cbx_Qfläche.SelectedIndex == 0)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuIProfil.QFläche()) * 1;



                }

                if (cbx_Qfläche.SelectedIndex == 1)
                {


                    lbl_qfläche.Content = Convert.ToDouble(neuIProfil.QFläche()) / 100;

                }

                if (cbx_Qfläche.SelectedIndex == 2)
                {

                    lbl_qfläche.Content = Convert.ToDouble(neuIProfil.QFläche()) / 10000;

                }
            }

        }

        private void cbx_Volumen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Bedingung Rechteckige Profile
            if (rechteckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Volumen.SelectedIndex == 0)
                {

                    lbl_volumen.Content = Convert.ToDouble(rechteckVoll.Volumen()) * 1;



                }

                if (cbx_Volumen.SelectedIndex == 1)
                {


                    lbl_volumen.Content = Convert.ToDouble(rechteckVoll.Volumen()) / 1000;

                }

                if (cbx_Volumen.SelectedIndex == 2)
                {

                    lbl_volumen.Content = Convert.ToDouble(rechteckVoll.Volumen()) / 1000000;

                }

            }
            if (rechteckHohl != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Volumen.SelectedIndex == 0)
                {

                    lbl_volumen.Content = Convert.ToDouble(rechteckHohl.Volumen()) * 1;



                }

                if (cbx_Volumen.SelectedIndex == 1)
                {


                    lbl_volumen.Content = Convert.ToDouble(rechteckHohl.Volumen()) / 1000;

                }

                if (cbx_Volumen.SelectedIndex == 2)
                {

                    lbl_volumen.Content = Convert.ToDouble(rechteckHohl.Volumen()) / 1000000;

                }

            }
            if (neuSechseckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Volumen.SelectedIndex == 0)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuSechseckVoll.Volumen()) * 1;



                }

                if (cbx_Volumen.SelectedIndex == 1)
                {


                    lbl_volumen.Content = Convert.ToDouble(neuSechseckVoll.Volumen()) / 1000;

                }

                if (cbx_Volumen.SelectedIndex == 2)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuSechseckVoll.Volumen()) / 1000000;

                }

            }
            //Bedingung RundeProfile
            if (neuRundVoll != null)
            {
                if (cbx_Volumen.SelectedIndex == 0)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuRundVoll.Volumen()) * 1;



                }

                if (cbx_Volumen.SelectedIndex == 1)
                {


                    lbl_volumen.Content = Convert.ToDouble(neuRundVoll.Volumen()) / 1000;

                }

                if (cbx_Volumen.SelectedIndex == 2)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuRundVoll.Volumen()) / 1000000;

                }
            }
            if (neuRundHohl != null)
            {
                if (cbx_Volumen.SelectedIndex == 0)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuRundHohl.Volumen()) * 1;



                }

                if (cbx_Volumen.SelectedIndex == 1)
                {


                    lbl_volumen.Content = Convert.ToDouble(neuRundHohl.Volumen()) / 1000;

                }

                if (cbx_Volumen.SelectedIndex == 2)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuRundHohl.Volumen()) / 1000000;

                }
            }
            if (neuHalbRund != null)
            {
                if (cbx_Volumen.SelectedIndex == 0)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuHalbRund.Volumen()) * 1;



                }

                if (cbx_Volumen.SelectedIndex == 1)
                {


                    lbl_volumen.Content = Convert.ToDouble(neuHalbRund.Volumen()) / 1000;

                }

                if (cbx_Volumen.SelectedIndex == 2)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuHalbRund.Volumen()) / 1000000;

                }
            }
            //Bedingung Formprofile
            if (neuTProfil != null)
            {
                if (cbx_Volumen.SelectedIndex == 0)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuTProfil.Volumen()) * 1;



                }

                if (cbx_Volumen.SelectedIndex == 1)
                {


                    lbl_volumen.Content = Convert.ToDouble(neuTProfil.Volumen()) / 1000;

                }

                if (cbx_Volumen.SelectedIndex == 2)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuTProfil.Volumen()) / 1000000;

                }
            }
            if (neuLProfil != null)
            {
                if (cbx_Volumen.SelectedIndex == 0)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuLProfil.Volumen()) * 1;



                }

                if (cbx_Volumen.SelectedIndex == 1)
                {


                    lbl_volumen.Content = Convert.ToDouble(neuLProfil.Volumen()) / 1000;

                }

                if (cbx_Volumen.SelectedIndex == 2)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuLProfil.Volumen()) / 1000000;

                }
            }
            if (neuUProfil != null)
            {
                if (cbx_Volumen.SelectedIndex == 0)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuUProfil.Volumen()) * 1;



                }

                if (cbx_Volumen.SelectedIndex == 1)
                {


                    lbl_volumen.Content = Convert.ToDouble(neuUProfil.Volumen()) / 1000;

                }

                if (cbx_Volumen.SelectedIndex == 2)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuUProfil.Volumen()) / 1000000;

                }
            }
            if (neuIProfil != null)
            {
                if (cbx_Volumen.SelectedIndex == 0)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuIProfil.Volumen()) * 1;



                }

                if (cbx_Volumen.SelectedIndex == 1)
                {


                    lbl_volumen.Content = Convert.ToDouble(neuIProfil.Volumen()) / 1000;

                }

                if (cbx_Volumen.SelectedIndex == 2)
                {

                    lbl_volumen.Content = Convert.ToDouble(neuIProfil.Volumen()) / 1000000;

                }
            }


        }

        private void cbx_Wx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Bedingung Rechteckige Profile
            if (rechteckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Wx.SelectedIndex == 0)
                {

                    lbl_Wy.Content = Convert.ToDouble(rechteckVoll.WiederstandsMoment_Wy()) * 1;



                }

                if (cbx_Wx.SelectedIndex == 1)
                {


                    lbl_Wy.Content = Convert.ToDouble(rechteckVoll.WiederstandsMoment_Wy()) / 1000;

                }

                if (cbx_Wx.SelectedIndex == 2)
                {

                    lbl_Wy.Content = Convert.ToDouble(rechteckVoll.WiederstandsMoment_Wy()) / 1000000;

                }

            }
            if (rechteckHohl != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Wx.SelectedIndex == 0)
                {

                    lbl_Wy.Content = Convert.ToDouble(rechteckHohl.WiederstandsMoment_Wy()) * 1;



                }

                if (cbx_Wx.SelectedIndex == 1)
                {


                    lbl_Wy.Content = Convert.ToDouble(rechteckHohl.WiederstandsMoment_Wy()) / 1000;

                }

                if (cbx_Wx.SelectedIndex == 2)
                {

                    lbl_Wy.Content = Convert.ToDouble(rechteckHohl.WiederstandsMoment_Wy()) / 1000000;

                }

            }
            if (neuSechseckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Wx.SelectedIndex == 0)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuSechseckVoll.WiederstandsMoment_Wy()) * 1;



                }

                if (cbx_Wx.SelectedIndex == 1)
                {


                    lbl_Wy.Content = Convert.ToDouble(neuSechseckVoll.WiederstandsMoment_Wy()) / 1000;

                }

                if (cbx_Wx.SelectedIndex == 2)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuSechseckVoll.WiederstandsMoment_Wy()) / 1000000;

                }

            }
            //Bedingung RundeProfile
            if (neuRundVoll != null)
            {
                if (cbx_Wx.SelectedIndex == 0)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuRundVoll.WiederstandsMoment_Wy()) * 1;



                }

                if (cbx_Wx.SelectedIndex == 1)
                {


                    lbl_Wy.Content = Convert.ToDouble(neuRundVoll.WiederstandsMoment_Wy()) / 1000;

                }

                if (cbx_Wx.SelectedIndex == 2)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuRundVoll.WiederstandsMoment_Wy()) / 1000000;

                }
            }
            if (neuRundHohl != null)
            {
                if (cbx_Wx.SelectedIndex == 0)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuRundHohl.WiederstandsMoment_Wy()) * 1;



                }

                if (cbx_Wx.SelectedIndex == 1)
                {


                    lbl_Wy.Content = Convert.ToDouble(neuRundHohl.WiederstandsMoment_Wy()) / 1000;

                }

                if (cbx_Wx.SelectedIndex == 2)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuRundHohl.WiederstandsMoment_Wy()) / 1000000;

                }
            }
            if (neuHalbRund != null)
            {
                if (cbx_Wx.SelectedIndex == 0)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuHalbRund.WiederstandsMoment_Wy()) * 1;



                }

                if (cbx_Wx.SelectedIndex == 1)
                {


                    lbl_Wy.Content = Convert.ToDouble(neuHalbRund.WiederstandsMoment_Wy()) / 1000;

                }

                if (cbx_Wx.SelectedIndex == 2)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuHalbRund.WiederstandsMoment_Wy()) / 1000000;

                }
            }
            //Bedingung Formprofile
            if (neuTProfil != null)
            {
                if (cbx_Wx.SelectedIndex == 0)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuTProfil.WiederstandsMoment_Wy()) * 1;



                }

                if (cbx_Wx.SelectedIndex == 1)
                {


                    lbl_Wy.Content = Convert.ToDouble(neuTProfil.WiederstandsMoment_Wy()) / 1000;

                }

                if (cbx_Wx.SelectedIndex == 2)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuTProfil.WiederstandsMoment_Wy()) / 1000000;

                }
            }
            if (neuLProfil != null)
            {
                if (cbx_Wx.SelectedIndex == 0)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuLProfil.WiederstandsMoment_Wy()) * 1;



                }

                if (cbx_Wx.SelectedIndex == 1)
                {


                    lbl_Wy.Content = Convert.ToDouble(neuLProfil.WiederstandsMoment_Wy()) / 1000;

                }

                if (cbx_Wx.SelectedIndex == 2)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuLProfil.WiederstandsMoment_Wy()) / 1000000;

                }
            }
            if (neuUProfil != null)
            {
                if (cbx_Wx.SelectedIndex == 0)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuUProfil.WiederstandsMoment_Wy()) * 1;



                }

                if (cbx_Wx.SelectedIndex == 1)
                {


                    lbl_Wy.Content = Convert.ToDouble(neuUProfil.WiederstandsMoment_Wy()) / 1000;

                }

                if (cbx_Wx.SelectedIndex == 2)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuUProfil.WiederstandsMoment_Wy()) / 1000000;

                }
            }
            if (neuIProfil != null)
            {
                if (cbx_Wx.SelectedIndex == 0)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuIProfil.WiederstandsMoment_Wy()) * 1;



                }

                if (cbx_Wx.SelectedIndex == 1)
                {


                    lbl_Wy.Content = Convert.ToDouble(neuIProfil.WiederstandsMoment_Wy()) / 1000;

                }

                if (cbx_Wx.SelectedIndex == 2)
                {

                    lbl_Wy.Content = Convert.ToDouble(neuIProfil.WiederstandsMoment_Wy()) / 1000000;

                }
            }
        }

        private void cbx_Wy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Bedingung Rechteckige Profile
            if (rechteckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Wy.SelectedIndex == 0)
                {

                    lbl_Wz.Content = Convert.ToDouble(rechteckVoll.WiederstandsMoment_Wz()) * 1;



                }

                if (cbx_Wy.SelectedIndex == 1)
                {


                    lbl_Wz.Content = Convert.ToDouble(rechteckVoll.WiederstandsMoment_Wz()) / 1000;

                }

                if (cbx_Wy.SelectedIndex == 2)
                {

                    lbl_Wz.Content = Convert.ToDouble(rechteckVoll.WiederstandsMoment_Wz()) / 1000000;

                }

            }
            if (rechteckHohl != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Wy.SelectedIndex == 0)
                {

                    lbl_Wz.Content = Convert.ToDouble(rechteckHohl.WiederstandsMoment_Wz()) * 1;



                }

                if (cbx_Wy.SelectedIndex == 1)
                {


                    lbl_Wz.Content = Convert.ToDouble(rechteckHohl.WiederstandsMoment_Wz()) / 1000;

                }

                if (cbx_Wx.SelectedIndex == 2)
                {

                    lbl_Wz.Content = Convert.ToDouble(rechteckHohl.WiederstandsMoment_Wz()) / 1000000;

                }

            }
            if (neuSechseckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Wy.SelectedIndex == 0)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuSechseckVoll.WiederstandsMoment_Wz()) * 1;



                }

                if (cbx_Wy.SelectedIndex == 1)
                {


                    lbl_Wz.Content = Convert.ToDouble(neuSechseckVoll.WiederstandsMoment_Wz()) / 1000;

                }

                if (cbx_Wy.SelectedIndex == 2)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuSechseckVoll.WiederstandsMoment_Wz()) / 1000000;

                }

            }
            //Bedingung RundeProfile
            if (neuRundVoll != null)
            {
                if (cbx_Wy.SelectedIndex == 0)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuRundVoll.WiederstandsMoment_Wz()) * 1;



                }

                if (cbx_Wy.SelectedIndex == 1)
                {


                    lbl_Wz.Content = Convert.ToDouble(neuRundVoll.WiederstandsMoment_Wz()) / 1000;

                }

                if (cbx_Wy.SelectedIndex == 2)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuRundVoll.WiederstandsMoment_Wz()) / 1000000;

                }
            }
            if (neuRundHohl != null)
            {
                if (cbx_Wy.SelectedIndex == 0)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuRundHohl.WiederstandsMoment_Wz()) * 1;



                }

                if (cbx_Wy.SelectedIndex == 1)
                {


                    lbl_Wz.Content = Convert.ToDouble(neuRundHohl.WiederstandsMoment_Wz()) / 1000;

                }

                if (cbx_Wy.SelectedIndex == 2)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuRundHohl.WiederstandsMoment_Wz()) / 1000000;

                }
            }
            if (neuHalbRund != null)
            {
                if (cbx_Wy.SelectedIndex == 0)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuHalbRund.WiederstandsMoment_Wz()) * 1;



                }

                if (cbx_Wy.SelectedIndex == 1)
                {


                    lbl_Wz.Content = Convert.ToDouble(neuHalbRund.WiederstandsMoment_Wz()) / 1000;

                }

                if (cbx_Wy.SelectedIndex == 2)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuHalbRund.WiederstandsMoment_Wz()) / 1000000;

                }
            }
            //Bedingung Formprofile
            if (neuTProfil != null)
            {
                if (cbx_Wy.SelectedIndex == 0)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuTProfil.WiederstandsMoment_Wz()) * 1;



                }

                if (cbx_Wy.SelectedIndex == 1)
                {


                    lbl_Wz.Content = Convert.ToDouble(neuTProfil.WiederstandsMoment_Wz()) / 1000;

                }

                if (cbx_Wy.SelectedIndex == 2)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuTProfil.WiederstandsMoment_Wz()) / 1000000;

                }
            }
            if (neuLProfil != null)
            {
                if (cbx_Wy.SelectedIndex == 0)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuLProfil.WiederstandsMoment_Wz()) * 1;



                }

                if (cbx_Wy.SelectedIndex == 1)
                {


                    lbl_Wz.Content = Convert.ToDouble(neuLProfil.WiederstandsMoment_Wz()) / 1000;

                }

                if (cbx_Wy.SelectedIndex == 2)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuLProfil.WiederstandsMoment_Wz()) / 1000000;

                }
            }
            if (neuUProfil != null)
            {
                if (cbx_Wy.SelectedIndex == 0)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuUProfil.WiederstandsMoment_Wz()) * 1;



                }

                if (cbx_Wy.SelectedIndex == 1)
                {


                    lbl_Wz.Content = Convert.ToDouble(neuUProfil.WiederstandsMoment_Wz()) / 1000;

                }

                if (cbx_Wy.SelectedIndex == 2)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuUProfil.WiederstandsMoment_Wz()) / 1000000;

                }
            }
            if (neuIProfil != null)
            {
                if (cbx_Wy.SelectedIndex == 0)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuIProfil.WiederstandsMoment_Wz()) * 1;



                }

                if (cbx_Wy.SelectedIndex == 1)
                {


                    lbl_Wz.Content = Convert.ToDouble(neuIProfil.WiederstandsMoment_Wz()) / 1000;

                }

                if (cbx_Wy.SelectedIndex == 2)
                {

                    lbl_Wz.Content = Convert.ToDouble(neuIProfil.WiederstandsMoment_Wz()) / 1000000;

                }
            }
        }

        private void cbx_Ix_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Bedingung Rechteckige Profile
            if (rechteckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Ix.SelectedIndex == 0)
                {

                    lbl_Iy.Content = Convert.ToDouble(rechteckVoll.FTM_Iy()) * 1;



                }


                if (cbx_Ix.SelectedIndex == 1)
                {

                    lbl_Iy.Content = Convert.ToDouble(rechteckVoll.FTM_Iy()) / 10000;

                }

            }
            if (rechteckHohl != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Ix.SelectedIndex == 0)
                {

                    lbl_Iy.Content = Convert.ToDouble(rechteckHohl.FTM_Iy()) * 1;



                }


                if (cbx_Ix.SelectedIndex == 1)
                {

                    lbl_Iy.Content = Convert.ToDouble(rechteckHohl.FTM_Iy()) / 10000;

                }

            }
            if (neuSechseckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Ix.SelectedIndex == 0)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuSechseckVoll.FTM_Iy()) * 1;



                }


                if (cbx_Ix.SelectedIndex == 1)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuSechseckVoll.FTM_Iy()) / 10000;

                }

            }
            //Bedingung RundeProfile
            if (neuRundVoll != null)
            {
                if (cbx_Ix.SelectedIndex == 0)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuRundVoll.FTM_Iy()) * 1;



                }


                if (cbx_Ix.SelectedIndex == 1)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuRundVoll.FTM_Iy()) / 10000;

                }
            }
            if (neuRundHohl != null)
            {
                if (cbx_Ix.SelectedIndex == 0)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuRundHohl.FTM_Iy()) * 1;



                }

                if (cbx_Ix.SelectedIndex == 1)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuRundHohl.FTM_Iy()) / 10000;

                }
            }
            if (neuHalbRund != null)
            {
                if (cbx_Ix.SelectedIndex == 0)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuHalbRund.FTM_Iy()) * 1;



                }


                if (cbx_Ix.SelectedIndex == 1)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuHalbRund.FTM_Iy()) / 10000;

                }
            }
            //Bedingung Formprofile
            if (neuTProfil != null)
            {
                if (cbx_Ix.SelectedIndex == 0)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuTProfil.FTM_Iy()) * 1;



                }


                if (cbx_Ix.SelectedIndex == 1)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuTProfil.FTM_Iy()) / 10000;

                }
            }
            if (neuLProfil != null)
            {
                if (cbx_Ix.SelectedIndex == 0)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuLProfil.FTM_Iy()) * 1;



                }


                if (cbx_Ix.SelectedIndex == 1)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuLProfil.FTM_Iy()) / 10000;

                }
            }
            if (neuUProfil != null)
            {
                if (cbx_Ix.SelectedIndex == 0)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuUProfil.FTM_Iy()) * 1;



                }



                if (cbx_Ix.SelectedIndex == 1)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuUProfil.FTM_Iy()) / 10000;

                }
            }
            if (neuIProfil != null)
            {
                if (cbx_Ix.SelectedIndex == 0)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuIProfil.FTM_Iy()) * 1;



                }


                if (cbx_Ix.SelectedIndex == 1)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuIProfil.FTM_Iy()) / 10000;

                }
            }
        }

        private void cbx_Iy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Bedingung Rechteckige Profile
            if (rechteckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Iy.SelectedIndex == 0)
                {

                    Lbl_Iz.Content = Convert.ToDouble(rechteckVoll.FTM_Iz()) * 1;



                }


                if (cbx_Iy.SelectedIndex == 1)
                {

                    Lbl_Iz.Content = Convert.ToDouble(rechteckVoll.FTM_Iz()) / 10000;

                }

            }
            if (rechteckHohl != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Iy.SelectedIndex == 0)
                {

                    Lbl_Iz.Content = Convert.ToDouble(rechteckHohl.FTM_Iz()) * 1;



                }


                if (cbx_Iy.SelectedIndex == 1)
                {

                    Lbl_Iz.Content = Convert.ToDouble(rechteckHohl.FTM_Iz()) / 10000;

                }

            }
            if (neuSechseckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Iy.SelectedIndex == 0)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuSechseckVoll.FTM_Iz()) * 1;



                }


                if (cbx_Iy.SelectedIndex == 1)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuSechseckVoll.FTM_Iz()) / 10000;

                }

            }
            //Bedingung RundeProfile
            if (neuRundVoll != null)
            {
                if (cbx_Iy.SelectedIndex == 0)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuRundVoll.FTM_Iz()) * 1;



                }


                if (cbx_Iy.SelectedIndex == 1)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuRundVoll.FTM_Iz()) / 10000;

                }
            }
            if (neuRundHohl != null)
            {
                if (cbx_Iy.SelectedIndex == 0)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuRundHohl.FTM_Iz()) * 1;



                }

                if (cbx_Iy.SelectedIndex == 1)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuRundHohl.FTM_Iz()) / 10000;

                }
            }
            if (neuHalbRund != null)
            {
                if (cbx_Iy.SelectedIndex == 0)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuHalbRund.FTM_Iz()) * 1;



                }


                if (cbx_Iy.SelectedIndex == 1)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuHalbRund.FTM_Iz()) / 10000;

                }
            }
            //Bedingung Formprofile
            if (neuTProfil != null)
            {
                if (cbx_Iy.SelectedIndex == 0)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuTProfil.FTM_Iz()) * 1;



                }


                if (cbx_Iy.SelectedIndex == 1)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuTProfil.FTM_Iz()) / 10000;

                }
            }
            if (neuLProfil != null)
            {
                if (cbx_Iy.SelectedIndex == 0)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuLProfil.FTM_Iz()) * 1;



                }


                if (cbx_Iy.SelectedIndex == 1)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuLProfil.FTM_Iz()) / 10000;

                }
            }
            if (neuUProfil != null)
            {
                if (cbx_Iy.SelectedIndex == 0)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuUProfil.FTM_Iz()) * 1;



                }



                if (cbx_Iy.SelectedIndex == 1)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuUProfil.FTM_Iz()) / 10000;

                }
            }
            if (neuIProfil != null)
            {
                if (cbx_Iy.SelectedIndex == 0)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuIProfil.FTM_Iz()) * 1;



                }


                if (cbx_Iy.SelectedIndex == 1)
                {

                    Lbl_Iz.Content = Convert.ToDouble(neuIProfil.FTM_Iz()) / 10000;

                }
            }

        }

        private void cbx_Polar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Bedingung Rechteckige Profile
            if (rechteckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Polar.SelectedIndex == 0)
                {

                    lbl_Polar.Content = Convert.ToDouble(rechteckVoll.FTM_Polar()) * 1;



                }


                if (cbx_Polar.SelectedIndex == 1)
                {

                    lbl_Polar.Content = Convert.ToDouble(rechteckVoll.FTM_Polar()) / 10000;

                }

            }
            if (rechteckHohl != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Polar.SelectedIndex == 0)
                {

                    lbl_Polar.Content = Convert.ToDouble(rechteckHohl.FTM_Polar()) * 1;



                }


                if (cbx_Polar.SelectedIndex == 1)
                {

                    lbl_Polar.Content = Convert.ToDouble(rechteckHohl.FTM_Polar()) / 10000;

                }

            }
            if (neuSechseckVoll != null)// objekt Rechteckvoll global definieren
            {
                if (cbx_Polar.SelectedIndex == 0)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuSechseckVoll.FTM_Polar()) * 1;



                }


                if (cbx_Polar.SelectedIndex == 1)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuSechseckVoll.FTM_Polar()) / 10000;

                }

            }
            //Bedingung RundeProfile
            if (neuRundVoll != null)
            {
                if (cbx_Polar.SelectedIndex == 0)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuRundVoll.FTM_Polar()) * 1;



                }


                if (cbx_Polar.SelectedIndex == 1)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuRundVoll.FTM_Polar()) / 10000;

                }
            }
            if (neuRundHohl != null)
            {
                if (cbx_Polar.SelectedIndex == 0)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuRundHohl.FTM_Polar()) * 1;



                }

                if (cbx_Polar.SelectedIndex == 1)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuRundHohl.FTM_Polar()) / 10000;

                }
            }
            if (neuHalbRund != null)
            {
                if (cbx_Polar.SelectedIndex == 0)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuHalbRund.FTM_Polar()) * 1;



                }


                if (cbx_Polar.SelectedIndex == 1)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuHalbRund.FTM_Polar()) / 10000;

                }
            }
            //Bedingung Formprofile
            if (neuTProfil != null)
            {
                if (cbx_Polar.SelectedIndex == 0)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuTProfil.FTM_Polar()) * 1;



                }


                if (cbx_Polar.SelectedIndex == 1)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuTProfil.FTM_Polar()) / 10000;

                }
            }
            if (neuLProfil != null)
            {
                if (cbx_Polar.SelectedIndex == 0)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuLProfil.FTM_Polar()) * 1;



                }


                if (cbx_Polar.SelectedIndex == 1)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuLProfil.FTM_Polar()) / 10000;

                }
            }
            if (neuUProfil != null)
            {
                if (cbx_Polar.SelectedIndex == 0)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuUProfil.FTM_Polar()) * 1;



                }



                if (cbx_Polar.SelectedIndex == 1)
                {

                    lbl_Iy.Content = Convert.ToDouble(neuUProfil.FTM_Polar()) / 10000;

                }
            }
            if (neuIProfil != null)
            {
                if (cbx_Polar.SelectedIndex == 0)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuIProfil.FTM_Polar()) * 1;



                }


                if (cbx_Polar.SelectedIndex == 1)
                {

                    lbl_Polar.Content = Convert.ToDouble(neuIProfil.FTM_Polar()) / 10000;

                }
            }
        }
    }
    

   

}
