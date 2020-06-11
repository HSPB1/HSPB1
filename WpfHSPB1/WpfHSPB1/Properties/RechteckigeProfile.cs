using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows;
using WpfHSPB1;

namespace Profile_Muster
{
    class RechteckigeProfile
    {
        // Eigenschaften

        private double länge;
        public double Länge
        {
            get
            {
                return länge;
            }

            set
            {
                if (value > 0)
                {
                    länge = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!","Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
    }

   
    class RechteckVoll: RechteckigeProfile
    {
        //Eigenschaften Private gegen Fernzugriff
        private double höhe;
        private double breite;

        //Getter und Setter für Private Variablen
        public double Höhe
        {
            get
            { return höhe; }

            set
            {
                if(value >0)
                {
                    höhe = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double Breite
        {
            get
            { return breite; }

            set
            {
                if (value > 0)
                {
                    breite = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }

        //Methoden für Berechnung
        public double QFläche()
        {
            double qfläche = höhe * breite;
            return qfläche;
        }
        public double Volumen()
        {
            double volumen = QFläche() * Länge;
            return volumen;
        }
        public double WiederstandsMoment_Wy()
        {
            double Wy = breite * höhe * höhe / 6;
            return Wy;
        }
        public double WiederstandsMoment_Wz()
        {
            double Wz = höhe * breite * breite / 6;
            return Wz;
        }
        public double FTM_Iy()

        {
            double Iy = breite * höhe * höhe * höhe / 12;
            return Iy;
        }
        public double FTM_Iz()
        {
            double Iz = höhe * breite * breite * breite / 12;
            return Iz;
        }
        public double FTM_Polar()
        {
            double polar = FTM_Iy() + FTM_Iz();
            return polar;
        }
    }

    class RechteckHohl:RechteckigeProfile
    {
        //Eigenschaften Private gegen Fernzugriff
        private double höhe;
        private double breite;
        private double wandstärke;

        //Getter und Setter für Private Variablen
        public double Höhe
        {
            get
            { return höhe; }

            set
            {
                if (value > 0)
                {
                    höhe = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double Breite
        {
            get
            { return breite; }

            set
            {
                if (value > 0)
                {
                    breite = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double Wandstärke
        {
            get
            { return wandstärke; }

            set
            {
                if (value > 0)
                {
                    wandstärke = value;
                }

                if(value >= breite/2)
                { MessageBox.Show("Die Wandstärke darf nicht größer als das Profil sein!", "Eingabefehler" , MessageBoxButton.OK, MessageBoxImage.Error);
                   
                }

                if(value<=0)
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }


        //Methoden für Berechnung
        public double QFläche()
        {
            double qfläche = (höhe * breite) - ((höhe - 2 * wandstärke) * (breite - 2 * wandstärke));
            return qfläche;
        }
        public double Volumen()
        {
            double volumen = QFläche() * Länge;
            return volumen;
        }
        public double WiederstandsMoment_Wy()
        {
            double Wy = ((breite * höhe * höhe * höhe) - ((breite - 2 * wandstärke) * (höhe - 2 * wandstärke) * (höhe - 2 * wandstärke) * (höhe - 2 * wandstärke))) / (6 * höhe);
            return Wy;
        }
        public double WiederstandsMoment_Wz()
        {
            double Wz = ((höhe * breite * breite * breite) - ((höhe - 2 * wandstärke) * (breite - 2 * wandstärke) * (breite - 2 * wandstärke) * (breite - 2 * wandstärke))) / (6 * breite);
            return Wz;
        }
        public double FTM_Iy()

        {
            double Iy = ((breite * höhe * höhe * höhe) - ((breite - 2 * wandstärke) * (höhe - 2 * wandstärke) * (höhe - 2 * wandstärke) * (höhe - 2 * wandstärke))) / 12;
            return Iy;
        }   
        public double FTM_Iz()
        {
            double Iz = ((höhe * breite * breite * breite) - ((höhe - 2 * wandstärke) * (breite - 2 * wandstärke) * (breite - 2 * wandstärke) * (breite - 2 * wandstärke))) / 12;
            return Iz;
        }
        public double FTM_Polar()
        {
            double polar = FTM_Iy() + FTM_Iz();
            return polar;
        }
    }


    class SechseckVoll:RechteckigeProfile
    {
        //Eigenschaften Private gegen Fernzugriff
        private double radius;

        //Getter und Setter für Private Variablen
        public double Radius
        {
            get
            { return radius; }

            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }



        public double QFläche()
        {
            double qfläche = 3 * (Math.Sqrt(3)) / 2 * (radius * radius);
            return qfläche;
        }
        public double Volumen()
        {
            double volumen = QFläche() * Länge;
            return volumen;
        }
        public double WiederstandsMoment_Wy()
        {
            double Wy = radius * radius * radius * 5 / 8;
            return Wy;
        }
        public double WiederstandsMoment_Wz()
        {
            double Wz = 5 * (Math.Sqrt(3)) / 16 * (radius * radius * radius);
            return Wz;
        }
        public double FTM_Iy()

        {
            double Iy = 5 * (Math.Sqrt(3)) / 16 * (radius * radius * radius * radius);
            return Iy;
        }
        public double FTM_Iz()
        {
            double Iz = 5 * (Math.Sqrt(3)) / 16 * (radius * radius * radius * radius);
            return Iz;
        }
        public double FTM_Polar()
        {
            double polar = FTM_Iy() + FTM_Iz();
            return polar;
        }


    }



}
