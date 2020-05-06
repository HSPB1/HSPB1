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

            Profilberechnung Rechteck = new Profilberechnung();     // Erzeugen des Objekts  Rechteck



            // Programmablauf!!

            Rechteck.Kopf();                          // Programmstart und Initialisierung der Methoden
            Rechteck.Eingabe_Profilgeometrie();       // Eingabe ob vollmaterial oder Halbzeug
            Rechteck.Eingabe_Parameter();             // Eingabe der Profilparameter wie höhe breite und länge
            Rechteck.Eingabe_Werkstoff();             // Eingabe des Werkstoffes wie z.B. Stahl oder Aluminium
            Rechteck.Bestätigung_Der_Eingaben();      // Bestätigung der Eingabe und mit möglichkeit auf neustart der Parametereingabe 
            Rechteck.Ergebnise();                     // Anzeige der Ergebnisse mit möglichkeit auf neustart des Programms und auf Beenden






        }
    }







    class Profil_Parameter
    {
        //Eingenschaften des Profils mit Deklaration und get,set Methode
        public double höhe { get; set; }
        public double breite { get; set; }
        public double länge { get; set; }
        public double wandstärke { get; set; }
        public double dichte { get; set; }
        public string Werkstoff { get; set; }
        public string Geometrie { get; set; }

        //Methoden (Matematisch) ab hier Beginnen die Methoden
        public double QFläche()                     // Methode zur Berechnung der Querschnittsfläche
        {
            double ergebnis = 0;                    // Deklaration/Initialisierung der Variablen "ergebnis" 

            if (Geometrie == "Vollmaterial")
            {
                ergebnis = breite * höhe;

            }   // Bedingung zur Berechnung falls Vollmaterial ausgewählt wurde

            if (Geometrie == "Hohlprofil")
            {
                ergebnis = (breite * höhe) - (höhe - (2 * wandstärke)) * (breite - (2 * wandstärke));

            }    // Bedingung zur Berechnung falls Holprofil ausgewählt wurde

            return ergebnis;                      // Zurückgeben des Wertes an QFläche damit mit dem Ergebnis weitergerechnet werden kann

        }



        public double Volumen()
        {
            double ergebnis = QFläche() * länge;
            return ergebnis;

        }                 // Methoder zur Berechnung des Volumens

        public double Gewicht()
        {
            double ergebnis = (dichte * Volumen()) / 1000;
            return ergebnis;
        }                 // Methode zur Berechnung des Volumens

        public double FlächeTrägheitsMoment()
        {
            double ergebnis = 0;


            if (Geometrie == "Vollmaterial")
            {
                ergebnis = (höhe * breite / 12 * (höhe * höhe + breite * breite)) / 1000;

            }

            if (Geometrie == "Hohlprofil")
            {
                ergebnis = ((breite * höhe * höhe * höhe) - ((breite - (2 * wandstärke)) * (höhe - (2 * wandstärke)) * (höhe - (2 * wandstärke)) * (höhe - (2 * wandstärke))) / 12) / 1000;

            }
            return ergebnis;
        }

    }  //Klaase in der Profilparameter abgeleg sind und Initialisiert werden + Mathematische Methoden zur berechnung von Fläche, Volumen etc.

    class Profilberechnung : Profil_Parameter
    {

        public void Kopf() // Kopfzeile /Info was  soll das Programm tun
        {
            Console.WriteLine(" ___________________________");
            Console.WriteLine("|                           |");
            Console.WriteLine("|      Profilrechner        |");
            Console.WriteLine("|___________________________|");
            Console.WriteLine("\n");
            Console.WriteLine("|:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::|");
            Console.WriteLine(" -> Hinweis: Dieses Programm berechnet Ihnen die Fläche, das Volumen, das Gewicht und das Flächenträgheitsmoment! <- ");
            Console.WriteLine("|:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::|");
            Console.WriteLine("\n");

        }

        public void Eingabe_Profilgeometrie() // Eingabe Über das Halbzeug ob Vollmaterial oder Hohlprofil
        {
            int eingabe;        //Deklaration der Variablen Eingabe für später


            do      //Do while Schleife für Menüwiederholung bei falscher Eingabe
            {
                Console.WriteLine(" ______________________________________________________________________________________________ ");    //geschriebenes Layout für Menü
                Console.WriteLine("| Was für ein Profil soll es sein?                                                             |");
                Console.WriteLine("|----------------------------------------------------------------------------------------------|");
                Console.WriteLine("|-> für Vollmaterial drücken Sie die      (1) bestätigen Sie mit Enter!                        |");
                Console.WriteLine("|-> für Hohlprofil drücken Sie die        (2) bestätigen Sie mit Enter!                        |");
                Console.WriteLine("|______________________________________________________________________________________________|");
                eingabe = Convert.ToInt32(Console.ReadLine());  //Eingabe des users für Wertzuweisung

                switch (eingabe)
                {
                    case 1:
                        Geometrie = "Vollmaterial";
                        Console.Clear();
                        break;

                    case 2:
                        Geometrie = "Hohlprofil";
                        Console.WriteLine(" _____________________________________________________________________________________");
                        Console.WriteLine("|Bitte gebene Sie eine Wandstärke in mm und in Zahlen ein!  bestätigen Sie mit Enter! |");
                        Console.WriteLine("|_____________________________________________________________________________________|");
                        wandstärke = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Kopf();
                        Falsche_Eingabe();
                        break;

                } //switchblocl als Kontrollstruktur für Eingaben mit Initialisierung der Variablen Geometrie und Wandstärke
            } while (eingabe < 1 || eingabe > 2); // Bedingung für Wiederholung



        }   // 



        // Information/Menue für Parameter breite, höhe und länge
        public void Eingabe_Parameter()
        {
            Kopf(); // Programmkopf nochmal ausführen
            Console.WriteLine(" ____________________________________________________________________________________ "); //geschriebenes Layout für Menü
            Console.WriteLine("| Wie Breit ist Profil was berechnet werden soll?                                    |");
            Console.WriteLine("|------------------------------------------------------------------------------------|");
            Console.WriteLine("|-> Bitte geben Sie die Breite in mm und in Zahlen ein und bestätigen Sie mit Enter! |");
            Console.WriteLine("|____________________________________________________________________________________|");
            breite = Convert.ToDouble(Console.ReadLine()); // initialisieren des Parameters

            Console.Clear(); //Reinigung der Konosle
            Kopf();           // Programmkopf nochmal ausführen
            Console.WriteLine(" _____________________________________________________________________________________ ");//geschriebenes Layout für Menü
            Console.WriteLine("| Wie Hoch ist das  Profil was berechnet werden soll?                                 |");
            Console.WriteLine("|-------------------------------------------------------------------------------------|");
            Console.WriteLine("|-> Bitte geben Sie die Höhe in mm und in Zahlen ein an und bestätigen Sie mit Enter! |");
            Console.WriteLine("|_____________________________________________________________________________________|");
            höhe = Convert.ToDouble(Console.ReadLine()); // initialisieren des Parameters

            Console.Clear();    //Reinigung der Konosle
            Kopf();              // Programmkopf nochmal ausführen
            Console.WriteLine(" ______________________________________________________________________________________________ ");//geschriebenes Layout für Menü
            Console.WriteLine("| Wie lang ist das Profil?                                                                     |");
            Console.WriteLine("|----------------------------------------------------------------------------------------------|");
            Console.WriteLine("|-> Bitte geben Sie die Länge des Profils in mm und in Zahlen an und bestätigen Sie mit Enter! |");
            Console.WriteLine("|______________________________________________________________________________________________|");
            länge = Convert.ToDouble(Console.ReadLine()); // initialisieren des Parameters

            Console.Clear();    //Reinigung der Konosle
        } // Methode für Eingabe Parameter


        public void Eingabe_Werkstoff()
        {
            Kopf();     // Programmkopf nochmal ausführen
            int eingabe; // Deklariern von Eingabe
            do           // Do while schleife für Wiederholung bei Fehleingae
            {
                Console.WriteLine(" ___________________________________________________________________________ ");     //Layout Menue für Eingabe 
                Console.WriteLine("|Aus welchem Material soll das Profil sein?                                 |");
                Console.WriteLine("|-------------------------------------------------------------------------- |");
                Console.WriteLine("|-> für Stahl drücken Sie die        -> (1)  bestätigen Sie mit Enter!      |");
                Console.WriteLine("|-> für Aluminium drücken Sie die    -> (2)  bestätigen Sie mit Enter       |");
                Console.WriteLine("|___________________________________________________________________________|");

                eingabe = Convert.ToInt32(Console.ReadLine());      //initialisiern von Eingabe

                switch (eingabe)            //Switchblock als Kontrollstruktur
                {
                    case 1:                     // Case 1 und 2  Initialisieren Werkstoff und Dichte 
                        Werkstoff = "Stahl";
                        dichte = 0.00785; // g/mm² Stahl
                        Console.Clear();
                        break;

                    case 2:
                        Werkstoff = "Aluminium";
                        dichte = 0.0026989; //g/mm² Alu
                        Console.Clear();
                        break;

                    default:                            // Wiederholung der Eingabe
                        Console.Clear();
                        Kopf();
                        Falsche_Eingabe();

                        break;

                }

            } while (eingabe < 1 || eingabe > 2); // Bedinung der Schleife



        }  //Methode fpr Eingabe Werkstoff
        public void Bestätigung_Der_Eingaben()
        {
            Kopf();
            int eingabe;
            do
            {

                if (Geometrie == "Vollmaterial")
                {
                    Console.WriteLine(" _______________________________________________________________________________________________");
                    Console.WriteLine("| Wollen Sie dieses Profil berechnen lassen?                                                    |");
                    Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
                    Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
                    Console.WriteLine(" -> " + Geometrie + " mit den Maßen " + breite + " mm x " + höhe + " mm" + " und einer Länge von " + länge + " mm");
                    Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                    ___________________________|");
                    Console.WriteLine("|-> Drücken Sie für Ja die       (1) und bestätigen Sie mit Enter!  |");
                    Console.WriteLine("|-> Drücken Sie für Nein die     (2) und bestätigen Sie mit Enter!  |");
                    Console.WriteLine("|___________________________________________________________________|");


                }

                if (Geometrie == "Hohlprofil")
                {
                    Console.WriteLine(" ______________________________________________________________________________________________________");
                    Console.WriteLine("| Wollen Sie dieses Profil berechnen lassen?                                                           |");
                    Console.WriteLine("|------------------------------------------------------------------------------------------------------|");
                    Console.WriteLine("|------------------------------------------------------------------------------------------------------|");
                    Console.WriteLine(" -> " + Geometrie + " mit den Maßen " + breite + "mm x " + höhe + "mm x mit einer Wandstärke von " + wandstärke + "mm" + " und einer länge von " + länge + " mm ");
                    Console.WriteLine("|------------------------------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                    __________________________________|");
                    Console.WriteLine("|-> Drücken Sie für Ja die       (1) und bestätigen Sie mit Enter!  |");
                    Console.WriteLine("|-> Drücken Sie für Nein die     (2) und bestätigen Sie mit Enter!  |");
                    Console.WriteLine("|___________________________________________________________________|");


                }

                eingabe = Convert.ToInt32(Console.ReadLine());

                switch (eingabe)
                {
                    case 1:
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Kopf();
                        Eingabe_Profilgeometrie();
                        Eingabe_Parameter();
                        Eingabe_Werkstoff();
                        Bestätigung_Der_Eingaben();
                        break;

                }

            } while (eingabe < 1 || eingabe > 2);

        } // Methode zur Überprüfung der Parameter an User
        public void Falsche_Eingabe()
        {

            Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            Console.WriteLine("|Bitte Wiederholen Sie Ihre Eingabe und wählen Sie eines der Ihnen angezeigten Positionen!| ");
            Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            Console.WriteLine("\n");


        }           // Methode Für Falsche Eingabe

        public void Ergebnise()
        {
            int eingabe;


            if (Geometrie == "Vollmaterial")            // Ifbedingung für Ausgabe an User ohne Wandstäre als Vollmaterial
            {
                Console.WriteLine("\n");
                Console.WriteLine(" __________________________________");
                Console.WriteLine("|Ergebnis für Ihr gewältes Profil: |");
                Console.WriteLine("|__________________________________|\n");
                Console.WriteLine(" -> " + Geometrie + " mit den Maßen " + breite + " mm x " + höhe + " mm" + " und einer Länge von " + länge + " mm");
                Console.WriteLine("\n");
                Console.WriteLine(" -> Die Querschnittsfläche beträgt: " + QFläche() + " mm²");
                Console.WriteLine(" -> Ihr Volumen: " + Volumen() + " mm³");
                Console.WriteLine(" -> Das Gewicht: " + Gewicht() + " Kg ");
                Console.WriteLine(" -> Das Flächenträgheitsmoment beträgt: " + FlächeTrägheitsMoment() + " cm^4 ");

            }

            if (Geometrie == "Hohlprofil")      //ifBedinung für Ausgabe an User mit Wandstärke und Hohlprofil
            {
                Console.WriteLine("\n");
                Console.WriteLine(" __________________________________");
                Console.WriteLine("|Ergebnis für Ihr gewältes Profil: |");
                Console.WriteLine("|__________________________________|\n");
                Console.WriteLine(" -> " + Geometrie + " mit den Maßen " + breite + " mm x " + höhe + " mm x mit einer Wandstärke von " + wandstärke + " mm" + " und einer länge von " + länge + " mm ");
                Console.WriteLine("\n");
                Console.WriteLine(" -> Die Querschnittsfläche beträgt: " + QFläche() + " mm² ");
                Console.WriteLine(" -> Ihr Volumen des Profils entspricht : " + Volumen() + " mm³");
                Console.WriteLine(" -> Das Gewicht des Profils entspricht : " + Gewicht() + " Kg ");
                Console.WriteLine(" -> Das Flächenträgheitsmoment beträgt : " + FlächeTrägheitsMoment() + " cm^4");


            }

            do
            {
                Console.WriteLine("\n\n");
                Console.WriteLine(" __________________________________________________________________________________________");
                Console.WriteLine("| Wollen Sie ein weiteres Profil berechnen lassen?                                         |");
                Console.WriteLine("|------------------------------------------------------------------------------------------|");
                Console.WriteLine("|------------------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                                          |");
                Console.WriteLine("|-> Drücken Sie für Ja die                              (1) und bestätigen Sie mit Enter!  |");
                Console.WriteLine("|-> Drücken Sie für Nein die (Beendet das Programm)     (2) und bestätigen Sie mit Enter!  |");
                Console.WriteLine("|__________________________________________________________________________________________|");
                eingabe = Convert.ToInt32(Console.ReadLine());

                switch (eingabe)
                {
                    case 1:             // Neue Menü Ausführung
                        Console.Clear();
                        Kopf();
                        Eingabe_Profilgeometrie();
                        Eingabe_Parameter();
                        Eingabe_Werkstoff();
                        Bestätigung_Der_Eingaben();
                        Ergebnise();

                        break;

                    case 2:         //Beenden des Programms
                        Console.WriteLine("Das Programm wird nach drücken von Eingabetaste geschlossen!");
                        Console.ReadKey();
                        break;

                    default:        // Falsche Eingabe
                        Falsche_Eingabe();
                        break;
                }

            } while (eingabe < 1 || eingabe > 2);

        } // Anzeige der Ergebnisse für User mit Bedingung um ggf. Programm zu Beenden oder ein neues Profil berechnen zu lasen!

    }     //Klasse in der die Methoden für das Menü hinterlegt sind


}// Version 1.04
