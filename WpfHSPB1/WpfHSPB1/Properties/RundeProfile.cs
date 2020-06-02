using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using WpfHSPB1;

namespace Profile_Muster
{
    class RundeProfile 
    {   //Eigenschaften Private gegen Fernzugriff
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
                {MessageBox.Show("Das Profil muss einen positiven Wert haben"); 
                }
            }
        }
    }

   class RundVollProfil:RundeProfile
    {   //Eigenschaften Private gegen Fernzugriff
        private double durchmesser;

        //Getter und Setter für Private Variablen
        public double Durchmesser
        {
            get
            {
                return durchmesser;
            }

            set
            {
                if (value > 0)
                {
                    durchmesser = value;
                }
             
            }
        }

        //Methoden für Berechnung
        public double QFläche()
        {
            double qfläche = Math.PI * durchmesser * durchmesser / 4;
            return qfläche;
        }
        public double Volumen()
        {
            double volumen = QFläche() * Länge;
            return volumen;
        }
        public double WiederstandsMoment_Wy()
        {
            double Wy = Math.PI * durchmesser * durchmesser * durchmesser / 32;
            return Wy;
        }
        public double WiederstandsMoment_Wz()
        {
            double Wz = Math.PI * durchmesser * durchmesser * durchmesser / 32;
            return Wz;
        }
        public double FTM_Iy()

        {
            double Iy = Math.PI * durchmesser * durchmesser * durchmesser * durchmesser / 64;
            return Iy;
        }
        public double FTM_Iz()
        {
            double Iz = Math.PI * durchmesser * durchmesser * durchmesser * durchmesser / 64;
            return Iz;
        }
        public double FTM_Polar()
        {
            double polar = FTM_Iy() + FTM_Iz();
            return polar;
        }


    }

    class RundHohlProfil : RundeProfile
    {   //Eigenschaften Private gegen Fernzugriff
        private double durchmesser;
        private double wandstärke;
        //Getter und Setter für Private Variablen
        public double Durchmesser
        {
            get
            {
                return durchmesser;
            }

            set
            {
                if (value > 0)
                {
                    durchmesser = value;
                }
                else
                { MessageBox.Show("Das Profil muss einen positiven Wert haben"); }
            }
        }
        public double Wandstärke
        {
            get
            {
                return wandstärke;
            }

            set
            {
                if (value > 0)
                {
                   wandstärke = value;
                }
                if(value>=durchmesser)
                {
                    MessageBox.Show("Die Wandstärke kann nicht genauso groß oder größer sein wie der Durchmesser") ;
                    
                }
                else
                { MessageBox.Show("Das Profil muss einen positiven Wert haben");
                    
                }
            }
        }

        //Methoden für Berechnung
        public double QFläche()
        {
            double qfläche = (Math.PI * durchmesser * durchmesser / 4) - (Math.PI * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) / 4);
            return qfläche;
        }
        public double Volumen()
        {
            double volumen = QFläche() * Länge;
            return volumen;
        }
        public double WiederstandsMoment_Wy()
        {
            double Wy = Math.PI * (durchmesser * durchmesser * durchmesser * durchmesser - (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke)) / (32 * durchmesser);
            return Wy;
        }
        public double WiederstandsMoment_Wz()
        {
            double Wz = Math.PI * (durchmesser * durchmesser * durchmesser * durchmesser - (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke)) / (32 * durchmesser);
            return Wz;
        }
        public double FTM_Iy()

        {
            double Iy = Math.PI * (durchmesser * durchmesser * durchmesser * durchmesser - (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke)) / 64;
            return Iy;
        }
        public double FTM_Iz()
        {
            double Iz = Math.PI * (durchmesser * durchmesser * durchmesser * durchmesser - (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke) * (durchmesser - 2 * wandstärke)) / 64;
            return Iz;
        }
        public double FTM_Polar()
        {
            double polar = FTM_Iy() + FTM_Iz();
            return polar;
        }

    }

    class HalbrundProfil : RundeProfile
    {   //Eigenschaften Private gegen Fernzugriff
        private double radius;
       
        //Getter und Setter für Private Variablen
        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value > 0)
                {
                    radius= value;
                }
                else
                { MessageBox.Show("Das Profil muss einen positiven Wert haben");  }
            }
        }
      

        //Methoden für Berechnung
        public double QFläche()
        {
            double qfläche = Math.PI * radius * radius / 2;
            return qfläche;
        }
        public double Volumen()
        {
            double volumen = QFläche() * Länge;
            return volumen;
        }
        public double WiederstandsMoment_Wy()
        {
            double Wy = 0.1908 * radius * radius;
            return Wy;
        }
        public double WiederstandsMoment_Wz()
        {
            double Wz = (Math.PI * (radius * radius * radius * radius)) / 8;
            return Wz;
        }
        public double FTM_Iy()

        {
            double Iy = 0.1098 * radius * radius * radius * radius;
            return Iy;
        }
        public double FTM_Iz()
        {
            double Iz = (Math.PI * ((2 * radius) * (2 * radius) * (2 * radius))) / 64;
            return Iz;
        }
        public double FTM_Polar()
        {
            double polar = 00;
            return polar;
        }

    }


}
