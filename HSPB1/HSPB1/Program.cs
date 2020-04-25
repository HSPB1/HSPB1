using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSPB1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menükopf
            Console.WriteLine("\t\t \t \t \t _______________________________________________ \n");
            Console.WriteLine("\t\t\t\t\t\t\t Profilrechner\n");
            Console.WriteLine("\t\t \t \t \t _______________________________________________ \n");


            // Materialabfrage
            Console.WriteLine("\t\t\t\t\t\t Bitte wählen Sie Ihren Werkstoff aus\n");
            Console.WriteLine("\t\t\t\t\t\t|Für Stahl geben Sie die 1 ein!|");
            Console.WriteLine("\t\t\t\t\t\t|Für Aluminium geben Sie die 2 ein!|");

            int Material = Convert.ToInt32(Console.ReadLine());


            // Profil Geometrie
            Console.WriteLine("\t\t\t\t\t\tWählen Sie Ihr Profil aus\n");
            Console.WriteLine("\t\t\t\t\t\t|Für Vollmaterial geben Sie die 1 ein!|");
            Console.WriteLine("\t\t\t\t\t\t|Für Hohlprofil geben Sie die 2 ein!|");

            int Profil = Convert.ToInt32(Console.ReadLine());


            //Usereingabe Profil

            Console.WriteLine("Bitte geben Sie die Höhe des Profils ein!");
            float höhe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie die Breite des Profils ein!");
            float breite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie die Länge des Profils ein!");
            float länge = Convert.ToInt32(Console.ReadLine());

            float wandstärke = 0;
            if (Profil == 2)
            {

                Console.WriteLine("Bitte geben Sie die Wandstärke ein!");
                wandstärke = Convert.ToInt32(Console.ReadLine());


            }



            //Querschnittsfläche

            float qfläche = höhe * breite;

            if (Profil == 2)
            {


                qfläche = qfläche - (höhe - (2 * wandstärke)) * (breite - (2 * wandstärke));

            }

            Console.WriteLine("Die Querschnittsfläche ist: " + qfläche + "mm²");

            //Volumen

            float volumen = qfläche * länge;
            Console.WriteLine("Das Volumen beträgt:" + volumen + "mm³");

            //Gewicht

            double dichtestahl = 0.00785; // g/mm²
            double dichtealu = 0.0026989; //g/mm²
            double gewicht = 0;

            if (Material == 2)
            {
                gewicht = dichtealu * volumen;
            }
            else {
                gewicht = dichtestahl * volumen;
            }

            gewicht = gewicht / 1000;

            Console.WriteLine("Das Gewicht beträgt: " + gewicht + "Kg");

            //Fächenträgheitsmoment
            
            float flächeträg = 0;

            if(Profil ==1)
            { 
                flächeträg = höhe * breite / 12 * (höhe * höhe + breite * breite); 
            }

            if(Profil ==2)
            {
                flächeträg = (breite * höhe * höhe * höhe) - ((breite - (2 * wandstärke)) * (höhe - (2 * wandstärke)) * (höhe - (2 * wandstärke)) * (höhe - (2 * wandstärke))) / 12;
            }
             flächeträg = flächeträg/10000;
            Console.WriteLine("Das Flächenträgheitsmoment beträgt: " + flächeträg + "cm^4");







            Console.ReadKey();
        }
    }
}
