using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace HSPB1
{

    class Program
    {
        static void Main(string[] args)
        {

            /*Update von Version 1.04 auf Version 1.05
            
            -Methode Programm_Start_Eingabe() hinzugefügt für besseres Aussehen/Struktur und vermeidung von Permanenten Methodenaufruf;
            -Methode Programm_Start_Eingabe() hinzugefügt für besseres Aussehen/Struktur und vermeidung von Permanenten Methodenaufruf;
            -Methode Programmschließen()      hinzugefügt für besseres Aussehen und Struktur mit neuem Text und Layout;
            -Mehtode Catch_Text_Zahl ()       hinzugefügt mit Text und Layout; 
            -Mehtode Catch_Text_Buchstabe()   hinzugefügt mit Text und Layout;
            -Methode Flächenträgheismoment_Axial Ix hinzugefügt mit Berrechnung;
            -Methode FlächenträgheitsMoment_Axial Iy hinzugefügt mit Berrechnung;
            -Methode Flächenträgheitsmoment in FlächentragheitsMoment_Polar umbennant das es ein Polares ist und dessen Berechnung Korregiert!
            -Methode WiederstandsMoment_Axial_Wx hinzugefügt mit berechnung und in Methode_Ergebnise eingebettet;
            -Methode WiederstandsMoment_Axial_Wy hinzugefügt mit berechnung und in Methode_Ergebnise eingebettet;


            - In allen Methoden mit Eingabeaufforderung !!!!Try/Catch-Block!!!: Es können jetzt Sowohl Kommazahlen wie auch Buchstaben eingegeben Werden ohne dass das Programm abstürzt;

            - in Methode Eingabe_Parameter weitere Do-While Schleife, da es Keine Profile gibt mit dem Wert <= 0 ;
            
            - Bug entfernt der das Programm nicht geschlossen hat wegen Permannten Methodenaufruf von Bestätigung_Der_Eingaben();

            - Änderung von Programmablauf;

            - Kommentare geändert und sauber geordnet;

            - Methode Gewichtsberechnung überarbeitet da falsche Ergebnisse!

            
          


            */




            // Erzeugen des Objekts  Rechteck
            Profilberechnung Rechteck = new Profilberechnung();



            // Programmablauf!!

            Rechteck.Programm_Start_Eingabe();
            Rechteck.Program_Ende_Ausgabe();

            Console.ReadKey();








        }
    }






    //Klaase in der Profilparameter abgeleg sind und Initialisiert werden + Mathematische Methoden zur berechnung von Fläche, Volumen etc.
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




        // Methode zur Berechnung der Querschnittsfläche
        public double QFläche()
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


        // Methoder zur Berechnung des Volumens
        public double Volumen()
        {
            double ergebnis = QFläche() * länge;
            return ergebnis;

        }


        // Methode zur Berechnung des Volumens // Überarbeitet
        public double Gewicht()
        {
            double ergebnis = (dichte * Volumen() / 1000);
            return ergebnis;
        }

        // Methode zur Berechnung des Flächenträgheitsmoment (Polar) //NEu
        public double FlächeTrägheitsMoment_Polar()
        {
            double ergebnis = 0;


            if (Geometrie == "Vollmaterial")
            {
                ergebnis = FlächenträgeitsMoment_Axial_Ix() + FlächenträgheitsMoment_Axial_Iy();

            }

            if (Geometrie == "Hohlprofil")
            {
                ergebnis = FlächenträgheitsMoment_Axial_Iy() + FlächenträgeitsMoment_Axial_Ix();

            }
            return ergebnis;
        }

        //Neu Methode zur Berechnung Axiales Flächenträgheismoment Ix
        public double FlächenträgeitsMoment_Axial_Ix()
        {
            double ergebnis = 0;

            if (Geometrie == "Vollmaterial")
            {
                ergebnis = (breite * (höhe * höhe * höhe) / 12) / 10000;
                return ergebnis;
            }

            if (Geometrie == "Hohlprofil")
            {
                double zwischenergebnis = (breite * (höhe * höhe * höhe)) - ((breite - (2 * wandstärke)) * (höhe - (2 * wandstärke)) * (höhe - (2 * wandstärke)) * (höhe - (2 * wandstärke)));
                ergebnis = (zwischenergebnis / 12) / 10000;
                return ergebnis;
            }

            return ergebnis;

        }

        //Neu Methode zur Berechnung Axiales Flächenträgheismoment Iy
        public double FlächenträgheitsMoment_Axial_Iy()
        {
            double ergebnis = 0;

            if (Geometrie == "Vollmaterial")
            {
                ergebnis = (höhe * (breite * breite * breite) / 12) / 10000;
                return ergebnis;
            }

            if (Geometrie == "Hohlprofil")
            {
                double zwischenergebnis = (höhe * (breite * breite * breite)) - ((höhe - (2 * wandstärke)) * (breite - (2 * wandstärke)) * (breite - (2 * wandstärke)) * (breite - (2 * wandstärke)));
                ergebnis = (zwischenergebnis / 12) / 10000;
                return ergebnis;
            }

            return ergebnis;

        }

        //Neu Methode zur Berechnung Axiales Flächenträgheitsmoment Wx
        public double WiederstandsMoment_Axial_Wx()
        {
            double ergebnis = 0;

            if (Geometrie == "Vollmaterial")
            {
                ergebnis = ((breite * höhe * höhe) / 6) / 1000;
                return ergebnis;
            }

            if (Geometrie == "Hohlprofil")
            {
                double zwischenergebnis = (breite * (höhe * höhe * höhe)) - ((breite - 2 * wandstärke) * ((höhe - (2 * wandstärke)) * (höhe - (2 * wandstärke)) * (höhe - (2 * wandstärke))));
                ergebnis = (zwischenergebnis / (6 * höhe)) / 1000;
                return ergebnis;
            }

            return ergebnis;
        }


        public double WiederstandsMoment_Axial_Wy()
        {
            double ergebnis = 0;

            if (Geometrie == "Vollmaterial")
            {
                ergebnis = ((höhe * breite * breite) / 6) / 1000;

            }

            if (Geometrie == "Hohlprofil")
            {
                double zwischenergebnis = (höhe * breite * breite * breite) - ((höhe - 2 * wandstärke) * ((breite - 2 * wandstärke) * (breite - 2 * wandstärke) * (breite - 2 * wandstärke)));
                ergebnis = (zwischenergebnis / (6 * breite)) / 1000;
                return ergebnis;
            }

            return ergebnis;

        }


    }



    //Klasse in der die Methoden für das Menü hinterlegt sind
    class Profilberechnung : Profil_Parameter
    {


        //Neu hinzugefügt: Start des Programms und der Eingaben in neuer MEthode Ausgelagert sieht besser aus!
        public void Programm_Start_Eingabe()
        {
            // Programmablauf!!

            Kopf();                          // Programmstart und Initialisierung der Methoden
            Eingabe_Profilgeometrie();       // Eingabe ob vollmaterial oder Hohlprofil
            Eingabe_Parameter();             // Eingabe der Profilparameter wie höhe breite und länge
            Eingabe_Werkstoff();             // Eingabe des Werkstoffes wie z.B. Stahl oder Aluminium


        }



        // Neu hinzugefügt:  Ausgabe der Ergebnise in Methode ausgelagert 
        public void Program_Ende_Ausgabe()
        {
            Bestätigung_Der_Eingaben();      // Bestätigung der Eingabe und mit möglichkeit auf neustart der Parametereingabe 
            Ergebnise();                     // Anzeige der Ergebnisse mit möglichkeit auf neustart des Programms und auf Beenden

        }


        // Kopfzeile /Info was  soll das Programm tun Layout via Console.WriteLine
        public void Kopf()
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


        // Eingabe Über das Halbzeug ob Vollmaterial oder Hohlprofil
        public void Eingabe_Profilgeometrie()
        {


            int eingabe = 0;

            //Do while Schleife für Menüwiederholung bei falscher Eingabe
            do
            {


                /* Try/catch Block um fehlerhafter eingabe Vorzubeugen! 
                 Funktion: Der Code der gefährdet ist einen Fehler auszugeben wird im Try Block eingegeben bzw. Kopiert
                  sobald dort ein Fehler aufftritt geht dieser in den Catch Block und zeigt an Was ausgegeben werden soll.
                 */


                try
                {
                    //Layout geschriebn via Console.WritLine mit Frage und Eingabeaufforderung

                    Console.WriteLine(" ______________________________________________________________________________________________ ");
                    Console.WriteLine("| Was für ein Profil soll es sein?                                                             |");
                    Console.WriteLine("|----------------------------------------------------------------------------------------------|");
                    Console.WriteLine("|-> für Vollmaterial drücken Sie die      (1) bestätigen Sie mit Enter!                        |");
                    Console.WriteLine("|-> für Hohlprofil drücken Sie die        (2) bestätigen Sie mit Enter!                        |");
                    Console.WriteLine("|______________________________________________________________________________________________|");


                    //Initialisiert die Eingabe des users für Wertzuweisung              
                    eingabe = Convert.ToInt32(Console.ReadLine());


                    //switchblock als Kontrollstruktur für Eingaben mit Initialisierung der Variablen Geometrie und Wandstärke
                    switch (eingabe)
                    {   //Wenn die 1 eingegeben wird:
                        case 1:
                            Geometrie = "Vollmaterial";
                            Console.Clear();
                            break;

                        //Wenn die 2 eingegeben wird
                        case 2:
                            Geometrie = "Hohlprofil";
                            Console.WriteLine(" ____________________________________________________________________________________");
                            Console.WriteLine("|Bitte gebene Sie die Wandstärke in mm und in Zahlen ein!  Bestätigen Sie mit Enter! |");
                            Console.WriteLine("|____________________________________________________________________________________|");
                            wandstärke = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            break;

                        // Wenn eine andere Zahl ausser 1 und 2 Eingegeben wird
                        default:
                            Console.Clear();
                            Kopf();
                            Falsche_Eingabe();
                            break;

                    }
                }
                catch
                { Console.Clear(); Kopf(); Catch_Text_Zahl(); }



                // Bedingung für Wiederholung der Schleife ( während eingabe <1 oder eingabe >2 
            } while (eingabe < 1 || eingabe > 2);




        }



        //Methode Information/Menue mit Eingabe für Parameter breite, höhe und länge
        public void Eingabe_Parameter()
        {
            //Aufruf des Programmkopfes         
            Kopf();

            //Do-While-SChleife für Menuewiederholung bei falscher Eingabe
            do
            {


                //Sieh Methode Eingabe_ProfilGeometrie
                try
                {


                    //geschriebenes Layout für Menü via ConsoleWriteLine mit Eingabeaufforderung
                    Console.WriteLine(" ____________________________________________________________________________________ ");
                    Console.WriteLine("| Wie breit ist das Profil das berechnet werden soll?                                |");
                    Console.WriteLine("|------------------------------------------------------------------------------------|");
                    Console.WriteLine("|-> Bitte geben Sie die Breite in mm und in Zahlen ein und bestätigen Sie mit Enter! |");
                    Console.WriteLine("|____________________________________________________________________________________|");

                    // initialisieren des Parameters (Convert.ToDouble(Conosle ReadLine()) Konvertiert einen eingegebenen Strin in Double Format geht aber nicht mit Buchstaben!!!!
                    breite = Convert.ToDouble(Console.ReadLine());




                    //Reinigung der Konosle
                    Console.Clear();
                    Kopf();

                    //geschriebenes Layout für Menü via ConsoleWriteLine mit Eingabeaufforderung
                    Console.WriteLine(" _____________________________________________________________________________________ ");
                    Console.WriteLine("| Wie hoch ist das  Profil das berechnet werden soll?                                 |");
                    Console.WriteLine("|-------------------------------------------------------------------------------------|");
                    Console.WriteLine("|-> Bitte geben Sie die Höhe in mm und in Zahlen ein an und bestätigen Sie mit Enter! |");
                    Console.WriteLine("|_____________________________________________________________________________________|");
                    höhe = Convert.ToDouble(Console.ReadLine());

                    Console.Clear();
                    Kopf();
                    Console.WriteLine(" ______________________________________________________________________________________________ ");
                    Console.WriteLine("| Wie lang ist das Profil?                                                                     |");
                    Console.WriteLine("|----------------------------------------------------------------------------------------------|");
                    Console.WriteLine("|-> Bitte geben Sie die Länge des Profils in mm und in Zahlen an und bestätigen Sie mit Enter! |");
                    Console.WriteLine("|______________________________________________________________________________________________|");
                    länge = Convert.ToDouble(Console.ReadLine());

                    Console.Clear();





                }
                catch
                { Console.Clear(); Kopf(); Catch_Text_Buchstaben(); }





            } while (breite <= 0 || höhe <= 0 || länge <= 0);


        }

        //Methode für Menue Eingabe Werkstoff
        public void Eingabe_Werkstoff()
        {
            Kopf();
            int eingabe = 0;

            // Do while schleife für Wiederholung bei Fehleingae
            do
            {

                //Siehe Eingabe_ProflGeometrie
                try
                {

                    //geschriebenes Layout für Menü via ConsoleWriteLine mit Eingabeaufforderung
                    Console.WriteLine(" ___________________________________________________________________________ ");
                    Console.WriteLine("|Aus welchem Material soll das Profil sein?                                 |");
                    Console.WriteLine("|-------------------------------------------------------------------------- |");
                    Console.WriteLine("|-> für Stahl drücken Sie die        -> (1)  bestätigen Sie mit Enter!      |");
                    Console.WriteLine("|-> für Aluminium drücken Sie die    -> (2)  bestätigen Sie mit Enter!      |");
                    Console.WriteLine("|___________________________________________________________________________|");


                    //Initialisiert die Eingabe des users für Wertzuweisung              
                    eingabe = Convert.ToInt32(Console.ReadLine());


                    //Switchblock als Kontrollstruktur síehe ProfilGeometrie
                    switch (eingabe)
                    {

                        // Case 1 und 2  Initialisieren Werkstoff und Dichte 
                        case 1:
                            Werkstoff = "Stahl";
                            dichte = 0.00785; // g/mm² Stahl
                            Console.Clear();
                            break;

                        case 2:
                            Werkstoff = "Aluminium";
                            dichte = 0.0026989; //g/mm² Alu
                            Console.Clear();
                            break;

                        // Wiederholung der Eingabe
                        default:
                            Console.Clear();
                            Kopf();
                            Falsche_Eingabe();

                            break;

                    }
                }

                catch
                { Console.Clear(); Kopf(); Catch_Text_Zahl(); }


                // Bedinung der Schleife
            } while (eingabe < 1 || eingabe > 2);



        }


        // Methode zur Überprüfung der Parameter an User
        public void Bestätigung_Der_Eingaben()
        {
            Kopf();
            int eingabe = 0;

            // Do While Schleife für Menue Wiederholung bei Falscher Eingabe   
            do
            {

                //Siehe Eingabe_ProfilGeometrie
                try
                {
                    // IF Block Wo die Berechnungen von Vollmaterial + Parameter bestätigt werden muss!
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


                    // IF Block Wo die Berechnungen von Hohlprofil + Parameter bestätigt werden muss! (Unterschied = Wandstärke wurde hinzugefügt!)
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

                    // Wertzuweisung eingabe über USer
                    eingabe = Convert.ToInt32(Console.ReadLine());

                    //Switchblock als Kontrollstruktur
                    switch (eingabe)
                    {   //bricht aus der Bedingung und führt zum nächsten Schritt
                        case 1:
                            Console.Clear();
                            break;

                        //Lässt neue Eingaben/Wertezuweisung des Profils zu
                        case 2:
                            Console.Clear();
                            Programm_Start_Eingabe();
                            Program_Ende_Ausgabe();
                            break;

                    }

                }
                catch
                { Console.Clear(); Kopf(); Catch_Text_Zahl(); }

                //Bedingung der Schleife
            } while (eingabe < 1 || eingabe > 2);

        }


        //Methode Ausgabe der Ergebnisse mit Option ein weiteres Profil berechnen zu lassen
        public void Ergebnise()
        {
            int eingabe = 0;

            do
            {
                // Ifbedingung für Ausgabe an User ohne Wandstäre als Vollmaterial
                if (Geometrie == "Vollmaterial")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(" __________________________________");
                    Console.WriteLine("|Ergebnis für Ihr gewähltes Profil: |");
                    Console.WriteLine("|__________________________________|\n");

                    //Wiederaufruf des Profils für Information an den User
                    Console.WriteLine(" -> " + Geometrie + " mit den Maßen " + breite + " mm x " + höhe + " mm" + " und einer Länge von " + länge + " mm");
                    Console.WriteLine("\n");
                    //Aufruf der Returnergebnisse von Mathematischen Methoden aus Class Profil_Parameter zur Ausgabe
                    Console.WriteLine(" -> Die Querschnittsfläche beträgt:     " + QFläche() + " mm²");
                    Console.WriteLine(" -> Das Volumen des Profils entspricht: " + Volumen() + " mm³");
                    Console.WriteLine(" -> Das Gewicht des Profils entsprcht : " + Gewicht() + " Kg \n\n");
                    Console.WriteLine(" -> Das Axiale Wiederstandsmoment Wx entspricht:                    " + WiederstandsMoment_Axial_Wx() + " cm³");
                    Console.WriteLine(" -> Das Axiale Wiederstandsmoment Wy entspricht:                    " + WiederstandsMoment_Axial_Wy() + " cm³\n\n");
                    Console.WriteLine(" -> Das Axiale Flächenträgheitsmoment Ix entspricht:                " + FlächenträgeitsMoment_Axial_Ix() + " cm^4");
                    Console.WriteLine(" -> Das Axiale Flächenträgheitsmoment Iy entspricht:                " + FlächenträgheitsMoment_Axial_Iy() + " cm^4");
                    Console.WriteLine(" -> Das Polare Flächenträgheitsmoment (Ix + Iy) entspricht:         " + FlächeTrägheitsMoment_Polar() + " cm^4");
                }

                //IF Bedinung für Ausgabe an User mit Wandstärke und Hohlprofil
                if (Geometrie == "Hohlprofil")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(" __________________________________");
                    Console.WriteLine("|Ergebnis für Ihr gewähltes Profil: |");
                    Console.WriteLine("|__________________________________|\n");

                    //Wiederaufruf des Profils für Information an den User
                    Console.WriteLine(" -> " + Geometrie + " mit den Maßen " + breite + " mm x " + höhe + " mm x mit einer Wandstärke von " + wandstärke + " mm" + " und einer länge von " + länge + " mm ");
                    Console.WriteLine("\n");

                    //Aufruf der Returnergebnisse von Mathematischen Methoden aus Class Profil_Parameter zur Ausgabe
                    Console.WriteLine(" -> Die Querschnittsfläche beträgt:                      " + QFläche() + " mm² ");
                    Console.WriteLine(" -> Das Volumen des Profils entspricht:                  " + Volumen() + " mm³");
                    Console.WriteLine(" -> Das Gewicht des Profils entspricht:                  " + Gewicht() + " Kg \n\n");
                    Console.WriteLine(" -> Das Axiale Wiederstandsmoment Wx entspricht:                    " + WiederstandsMoment_Axial_Wx() + " cm³");
                    Console.WriteLine(" -> Das Axiale Wiederstandsmoment Wy entspricht:                    " + WiederstandsMoment_Axial_Wy() + " cm³\n\n");
                    Console.WriteLine(" -> Das Axiale Flächenträgheitsmoment Ix entspricht:                " + FlächenträgeitsMoment_Axial_Ix() + " cm^4");
                    Console.WriteLine(" -> Das Axiale Flächenträgheitsmoment Iy entspricht:                " + FlächenträgheitsMoment_Axial_Iy() + " cm^4");
                    Console.WriteLine(" -> Das Polare Flächenträgheitsmoment (Ix + Iy) entspricht:         " + FlächeTrägheitsMoment_Polar() + " cm^4");


                }




                //try/catch Block Siehe Class Profilberechnung Eingabe_Profilparameter
                try
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

                    //Wertzuweisung von eingabe über User
                    eingabe = Convert.ToInt32(Console.ReadLine());

                    switch (eingabe)
                    {   // bei Auswahl 1 Neuestart des Programms
                        case 1:
                            Console.Clear();
                            Programm_Start_Eingabe();
                            Program_Ende_Ausgabe();
                            break;

                        // bei Auswahl 2 Beenden des Programms
                        case 2:
                            Programmschließen();
                            break;

                        //Falsche Eingabe
                        default:
                            Console.Clear();
                            Falsche_Eingabe();
                            break;
                    }

                }

                catch
                { Console.Clear(); Kopf(); Catch_Text_Zahl(); }

            } while (eingabe < 1 || eingabe > 2);

            //Schleifenbedinung


            Console.ReadKey();
        }

        //Neu
        // Methode die das Programmschließen einleitet
        public void Programmschließen()
        {
            Console.Clear();
            Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            Console.WriteLine("     ->      Das Programm wird nach Eingabetaste geschlossen        <-               ");
            Console.WriteLine("|-----------------------------------------------------------------------------------------|");

            Console.ReadKey();

        }

        //Methode mit Vorgeschriebenen Text für Falsche Eingabe
        public void Falsche_Eingabe()
        {

            Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            Console.WriteLine("|Bitte Wiederholen Sie Ihre Eingabe und wählen Sie eines der Ihnen angezeigten Positionen!| ");
            Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            Console.WriteLine("\n");


        }

        //Neu
        //Methode in der Text bei Falscher Eingabe von ganzen Zahlen erscheint
        public void Catch_Text_Zahl()
        {
            Console.Clear();
            Kopf();
            Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            Console.WriteLine("|        Bitte Wiederholen Sie Ihre Eingabe und wählen Sie eine ganze Zahl!!!!!           | ");
            Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            Console.WriteLine("\n");


        }

        //Neu
        //Methoder in der Userinfo bei Falscher Eingabe von Buchstaben erscheint
        public void Catch_Text_Buchstaben()
        {
            Console.Clear();
            Kopf();
            Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            Console.WriteLine("|    Bitte Wiederholen Sie Ihre Eingabe und wählen Sie nur aus Natürlichen Zahlen!        | ");
            Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            Console.WriteLine("\n");
        }

    }






    //Version 1.05  

}

