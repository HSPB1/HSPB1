using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using WpfHSPB1;

namespace Profile_Muster
{
    class FormProfile
    {
        //Eigenschaften Private gegen Fernzugriff
        private double länge;

        //Getter und Setter für Private Variablen
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
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            
            }
        }
    }

    class TProfil : FormProfile
    {
        //Eigenschaften Private gegen Fernzugriff
        private double h;
        private double b;
        private double H;
        private double B;


        //Getter und Setter für Private Variablen
        public double H2
        {
            get
            { return h; }

            set
            {
                if (value > 0)
                {
                    h = value;
                }
                if (value >= H)
                { MessageBox.Show("Die Wandstärke darf nicht größer als das Profil sein!", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                if (value <= 0)
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double B2
        {
            get
            { return b; }

            set
            {
                if (value > 0)
                {
                    b = value;
                }
                if (value >= B)
                { MessageBox.Show("Die Wandstärke darf nicht größer als das Profil sein!", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error); }

                if (value <= 0)
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double H1
        {
            get
            { return H; }

            set
            {
                if (value > 0)
                {
                    H = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double B1
        {
            get
            { return B; }

            set
            {
                if (value > 0)
                {
                    B = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }


        //Zwischenergebnisse
        public double e2()
        {
             double e2 = ((b * H * H + (B - b) * h * h) * 0.5) / (b * H + (B - b) * h);
            return e2;
        }   
        public double y()
        {
            double y = (b * H + (B - b) * h);
            return y;
        }
        public double z()
        {
            double z = (b * H * H * H + (B - b) * h * h * h) / 3;
            return z;
        }

        //Methoden für Berechnung
        public double QFläche()
        {
            double qfläche = (H * B) - ((H - h) * (B - b));
            return qfläche;
        }
        public double Volumen()
        {
            double volumen = QFläche() * Länge;
            return volumen;
        }
        public double WiederstandsMoment_Wy()
        {
            double Wy = FTM_Iy() / (H - e2());
            return Wy;
        }
        public double WiederstandsMoment_Wz()
        {
            double Wz = (h * B * B * B + (H - h) * b * b * b) / (6 * B);
            return Wz;
        }
        public double FTM_Iy()

        {
            double Iy = z() - y() * (e2() * e2());
            return Iy;
        }
        public double FTM_Iz()
        {
            double Iz = (h * B * B * B + (H - h) * b * b * b) / 12;
            return Iz;
        }
        public double FTM_Polar()
        {
            double polar = FTM_Iy() + FTM_Iz();
            return polar;
        }
    }

    class UProfil:FormProfile
    {

        //Eigenschaften Private gegen Fernzugriff
        private double h;
        private double b;
        private double H;
        private double B;


        //Getter und Setter für Private Variablen
        public double H2
        {
            get
            { return h; }

            set
            {
                if (value > 0)
                {
                    h = value;
                }
                if (value >= H/2)
                { MessageBox.Show("Die Wandstärke darf nicht größer als das Profil sein!", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error); }

                if (value <= 0)
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double B2
        {
            get
            { return b; }

            set
            {
                if (value > 0)
                {
                    b = value;
                }
                if (value >= B)
                { MessageBox.Show("Die Wandstärke darf nicht größer als das Profil sein!", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error); }

                if (value <= 0)
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double H1
        {
            get
            { return H; }

            set
            {
                if (value > 0)
                {
                    H = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double B1
        {
            get
            { return B; }

            set
            {
                if (value > 0)
                {
                    B = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }


        //Zwischenergebnisse
        public double e3()
        {
            double e3 = (2 * h * B * B + (H - 2 * h) * b * b) * 0.5 / (2 * h * B + (H - 2 * h) * b);
            return e3;
        }
        public double y()
        {
            double y = (2 * h * B + (H - 2 * h) * b);
            return y;
        }
        public double x()
        {
            double x = (2 * h * B * B * B + (H - 2 * h) * b * b * b) / 3;
            return x;
        }

        //Methoden für Berechnung


        public double QFläche()
        {
            double qfläche = (H * B) - ((H - 2 * h) * (B - b));
            return qfläche;
        }
        public double Volumen()
        {
            double volumen = QFläche() * Länge;
            return volumen;
        }
        public double WiederstandsMoment_Wy()
        {
            double Wy = (B * H * H * H - (B - b) * ((H - 2 * h) * (H - 2 * h) * (H - 2 * h))) / 6 / H;
            return Wy;
        }
        public double WiederstandsMoment_Wz()
        {
            double Wz = FTM_Iz() / (B - e3());
            return Wz;
        }
        public double FTM_Iy()

        {
            double Iy = (B * H * H * H - (B - b) * ((H - 2 * h) * (H - 2 * h) * (H - 2 * h))) / 12;
            return Iy;
        }
        public double FTM_Iz()
        {
            double Iz = x() - (y() * e3() * e3());
            return Iz;
        } 
        public double FTM_Polar()
        {
            double polar = FTM_Iy() + FTM_Iz();
            return polar;
        }
    }

    class IProfil:FormProfile
    {
        //Eigenschaften Private gegen Fernzugriff
        private double h;
        private double b;
        private double H;
        private double B;


        //Getter und Setter für Private Variablen
        public double H2
        {
            get
            { return h; }

            set
            {
                if (value > 0)
                {
                    h = value;
                }
                if (value >= H)
                { MessageBox.Show("Die Wandstärke darf nicht größer als das Profil sein!", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error); }

                if (value <= 0)
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double B2
        {
            get
            { return b; }

            set
            {
                if (value > 0)
                {
                    b = value;
                }
                if (value >= B/2)
                { MessageBox.Show("Die Wandstärke darf nicht größer als das Profil sein!", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error); }

                if (value <= 0)
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double H1
        {
            get
            { return H; }

            set
            {
                if (value > 0)
                {
                    H = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double B1
        {
            get
            { return B; }

            set
            {
                if (value > 0)
                {
                    B = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }

        //Methoden für Berechnung
        public double QFläche()
        {
            double qfläche = (H * B) - ((H - 2 * h) * (B - b));
            return qfläche;
        }
        public double Volumen()
        {
            double volumen = QFläche() * Länge;
            return volumen;
        }
        public double WiederstandsMoment_Wy()
        {
            double Wy = (B * H * H * H - (B - b) * ((H - 2 * h) * (H - 2 * h) * (H - 2 * h))) / 6 / H;
            return Wy;
        }
        public double WiederstandsMoment_Wz()
        {
            double Wz = (2 * h * B * B * B + (H - 2 * h) * b * b * b) / (6 * B);
            return Wz;
        }
        public double FTM_Iy()

        {
            double Iy = (B * H * H * H - (B - b) * ((H - 2 * h) * (H - 2 * h) * (H - 2 * h))) / 12;
            return Iy;
        }
        public double FTM_Iz()
        {
            double Iz = (2 * h * B * B * B + (H - 2 * h) * b * b * b) / 12;
            return Iz;
        }
        public double FTM_Polar()
        {
            double polar = FTM_Iy() + FTM_Iz();
            return polar;
        }
    }

    class LProfil : FormProfile
    {
        //Eigenschaften Private gegen Fernzugriff
        private double h;
        private double b;
        private double H;
        private double B;


        //Getter und Setter für Private Variablen
        public double H1
        {
            get
            { return H; }

            set
            {
                if (value > 0)
                {
                    H = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double B1
        {
            get
            { return B; }

            set
            {
                if (value > 0)
                {
                    B = value;
                }
                else
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double H2
        {
            get
            { return h; }

            set
            {
                if (value > 0)
                {
                    h = value;
                }
                if (value >= H)
                { MessageBox.Show("Die Wandstärke darf nicht größer als das Profil sein!", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error); }

                if (value <= 0)
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        public double B2
        {
            get
            { return b; }

            set
            {
                if (value > 0)
                {
                    b = value;
                }
                if (value >= B)
                { MessageBox.Show("Die Wandstärke darf nicht größer als das Profil sein!", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error); }

                if (value <= 0)
                { MessageBox.Show("Bitte geben Sie einen positiven Wert ein!", "Eingabefehler!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }


        //Zwischenergebnisse
        public double e2()
        {
            double e2 = ((b * H * H + (B - b) * h * h) * 0.5) / (b * H + (B - b) * h);
            return e2;
        }
        public double y()
        {
            double y = (b * H + (B - b) * h);
            return y;
        }
        public double z()
        {
            double z = (b * H * H * H + (B - b) * h * h * h) / 3;
            return z;
        }

        //Methoden für Berechnung


        public double QFläche()
        {
            double qfläche = (H * B) - ((H - h) * (B - b));
            return qfläche;
        }
        public double Volumen()
        {
            double volumen = QFläche() * Länge;
            return volumen;
        }
        public double WiederstandsMoment_Wy()
        {
            double Wy = FTM_Iy() / (H - e2());
            return Wy;
        }
        public double WiederstandsMoment_Wz()
        {
            double Wz = (h * B * B * B + (H - h) * b * b * b) / (6 * B);
            return Wz;
        }
        public double FTM_Iy()

        {
            double Iy = z() - y() * (e2() * e2());
            return Iy;
        }
        public double FTM_Iz()
        {
            double Iz = (h * B * B * B + (H - h) * b * b * b) / 12;
            return Iz;
        }
        public double FTM_Polar()
        {
            double polar = FTM_Iy() + FTM_Iz();
            return polar;
        }
    }


}







