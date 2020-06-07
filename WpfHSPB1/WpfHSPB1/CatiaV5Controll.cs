using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MECMOD;
using INFITF;
using PARTITF;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using Profile_Muster;
using WpfHSPB1;
using System.Runtime.CompilerServices;
//Zum Starten über Anwendung
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace WpfHSPB1
{


   

    class CatiaAPIConection
    {
            
            
            INFITF.Application hspB1_catiaApp;
            MECMOD.PartDocument hspB1_catiaPart;
            MECMOD.Sketch hspB1_catia_Profil;


   

        //Methode für Feststellung ob Catia läuft
        public bool CatiaLaeuft()
          {
            

           try
           {
             object catiaObject = System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application");

             hspB1_catiaApp = (INFITF.Application)catiaObject;
             return true;
           }
                  
            catch (Exception)
           {
                    return false;
           }

           }

        //Methode zur erstellung eines neuen Parts
        internal void ErzeugePart()
        {   
            INFITF.Documents catDocuments1 = hspB1_catiaApp.Documents;
            hspB1_catiaPart = (PartDocument)catDocuments1.Add("Part");
                                
        }

        //Erstellen einer neuen Skizze
        internal void ErzeugeSkizze()
        {
            

            HybridBodies catHybridBodies1 = hspB1_catiaPart.Part.HybridBodies;
            HybridBody catHybridBody1;

            try
            {
                catHybridBody1 = catHybridBodies1.Item("Geometrisches Set.1");
            }
            catch(Exception)
            { 
                MessageBox.Show("Kein geometrisches Set gefunden! " + Environment.NewLine + "Ein PART manuell erzeugen und ein darauf achten, dass 'Geometisches Set' aktiviert ist.","Fehler", MessageBoxButton.OK, MessageBoxImage.Information);

                return;                       
            }

            catHybridBody1.set_Name("Profil");
            Sketches catSketch =   catHybridBody1.HybridSketches;
            OriginElements catOriginElements = hspB1_catiaPart.Part.OriginElements;
            Reference catReferenz = (Reference)catOriginElements.PlaneYZ;

            hspB1_catia_Profil = catSketch.Add(catReferenz);

            ErzeugeAchsensystem();

            hspB1_catiaPart.Part.Update();

        }

         private void ErzeugeAchsensystem()
        {
            object[] arr = new object[] {0.0, 0.0, 0.0,
                                         0.0, 1.0, 0.0,
                                         0.0, 0.0, 1.0 };
            hspB1_catia_Profil.SetAbsoluteAxisData(arr);
        }
        


        //Hier beginnen RechteckProfile 


        //RechteckVoll!
        //Erzeugen der Geometrie RechteckVoll
        internal void ErzeugeProfilRechteckVoll(RechteckVoll rechteckVoll)
        {
           

            hspB1_catia_Profil.set_Name("Rechteck_Voll");
            Factory2D factory2D = hspB1_catia_Profil.OpenEdition();

            //Setzen der Punkte
            Point2D catPoint2D1 = factory2D.CreatePoint(-rechteckVoll.Breite /2 ,rechteckVoll.Höhe/2);
            Point2D catPoint2D2 = factory2D.CreatePoint(rechteckVoll.Breite/2, rechteckVoll.Höhe/2);
            Point2D catPoint2D3 = factory2D.CreatePoint(rechteckVoll.Breite/2, -rechteckVoll.Höhe/2);
            Point2D catPoint2D4 = factory2D.CreatePoint(-rechteckVoll.Breite/2, -rechteckVoll.Höhe/2);

           //Linie Horrizontal Oben
            Line2D catLine2D1 = factory2D.CreateLine(-rechteckVoll.Breite/2, rechteckVoll.Höhe/2, rechteckVoll.Breite/2, rechteckVoll.Höhe/2);
            catLine2D1.StartPoint = catPoint2D1;
            catLine2D1.EndPoint = catPoint2D2;

            //Linie Vertikal Rechts
            Line2D catLine2D2 = factory2D.CreateLine(rechteckVoll.Breite /2, rechteckVoll.Höhe/2, rechteckVoll.Breite/2, -rechteckVoll.Höhe/2);
            catLine2D2.StartPoint = catPoint2D2;
            catLine2D2.EndPoint = catPoint2D3;


            //Linie Horizontal Unten
            Line2D catLine2D3 = factory2D.CreateLine(rechteckVoll.Breite/2, -rechteckVoll.Höhe/2, -rechteckVoll.Breite/2, -rechteckVoll.Höhe/2);
            catLine2D3.StartPoint = catPoint2D3;
            catLine2D3.EndPoint = catPoint2D4;

            //Linie Vertikal Links
            Line2D catLine2D4 = factory2D.CreateLine(-rechteckVoll.Breite/2, rechteckVoll.Höhe/2, -rechteckVoll.Breite/2, -rechteckVoll.Höhe/2);
            catLine2D4.StartPoint = catPoint2D4;
            catLine2D4.EndPoint = catPoint2D1;

            // Skizzierer verlassen
            hspB1_catia_Profil.CloseEdition();
          
            
            // Part aktualisieren
            hspB1_catiaPart.Part.Update();


        }

        //Erzeugen der Extrusionfür RechteckVoll
        internal void ErzeugeExtrusionVoll(RechteckVoll rechteckVoll)
        {
            hspB1_catiaPart.Part.InWorkObject = hspB1_catiaPart.Part.MainBody;


            // Extrusion erzeugen
            ShapeFactory catShapeFactory1 = (ShapeFactory)hspB1_catiaPart.Part.ShapeFactory;
            Pad catPad1 = catShapeFactory1.AddNewPad(hspB1_catia_Profil, rechteckVoll.Länge);

            // Block umbenennen
            catPad1.set_Name("Profil Rechteck voll");

            // Part aktualisieren
            hspB1_catiaPart.Part.Update();

        }
        //Ende RechteckVoll



        //RechteckHohl!
        //Erzeugen der Geometrie RechteckHohl
        internal void ErzeugeProfilRechteckHohl(RechteckHohl rechteckHohl)
        {


            hspB1_catia_Profil.set_Name("Rechteck_Hohl");
            Factory2D factory2D = hspB1_catia_Profil.OpenEdition();

            //Setzen der Punkte Aussen
            Point2D catPoint2D1 = factory2D.CreatePoint(-rechteckHohl.Breite / 2, rechteckHohl.Höhe / 2);
            Point2D catPoint2D2 = factory2D.CreatePoint(rechteckHohl.Breite / 2, rechteckHohl.Höhe / 2);
            Point2D catPoint2D3 = factory2D.CreatePoint(rechteckHohl.Breite / 2, -rechteckHohl.Höhe / 2);
            Point2D catPoint2D4 = factory2D.CreatePoint(-rechteckHohl.Breite / 2, -rechteckHohl.Höhe / 2);
            //Setzen der Punkte Innen
            Point2D catPoint12D1 = factory2D.CreatePoint(-rechteckHohl.Breite / 2 + rechteckHohl.Wandstärke, rechteckHohl.Höhe / 2 - rechteckHohl.Wandstärke);
            Point2D catPoint12D2 = factory2D.CreatePoint(rechteckHohl.Breite / 2 - rechteckHohl.Wandstärke, rechteckHohl.Höhe / 2 - rechteckHohl.Wandstärke);
            Point2D catPoint12D3 = factory2D.CreatePoint(rechteckHohl.Breite / 2 - rechteckHohl.Wandstärke, -rechteckHohl.Höhe / 2 + rechteckHohl.Wandstärke);
            Point2D catPoint12D4 = factory2D.CreatePoint(-rechteckHohl.Breite / 2 + rechteckHohl.Wandstärke, -rechteckHohl.Höhe / 2 + rechteckHohl.Wandstärke);





            //Linie Horrizontal Oben
            Line2D catLine2D1 = factory2D.CreateLine(-rechteckHohl.Breite / 2, rechteckHohl.Höhe / 2, rechteckHohl.Breite / 2, rechteckHohl.Höhe / 2);
            catLine2D1.StartPoint = catPoint2D1;
            catLine2D1.EndPoint = catPoint2D2;

            //Linie Horrizontal Innen
            Line2D catLine12D1 = factory2D.CreateLine(-rechteckHohl.Breite / 2 + rechteckHohl.Wandstärke, rechteckHohl.Höhe / 2 - rechteckHohl.Wandstärke, rechteckHohl.Breite / 2 - rechteckHohl.Wandstärke, rechteckHohl.Höhe / 2 - rechteckHohl.Wandstärke);
            catLine12D1.StartPoint = catPoint12D1;
            catLine12D1.EndPoint = catPoint12D2;



            //Linie Vertikal Rechts
            Line2D catLine2D2 = factory2D.CreateLine(rechteckHohl.Breite / 2, rechteckHohl.Höhe / 2, rechteckHohl.Breite / 2, -rechteckHohl.Höhe / 2);
            catLine2D2.StartPoint = catPoint2D2;
            catLine2D2.EndPoint = catPoint2D3;

            //Linie Vertikal Rechts Innen
            Line2D catLine12D2 = factory2D.CreateLine(rechteckHohl.Breite / 2 - rechteckHohl.Wandstärke, rechteckHohl.Höhe / 2 - rechteckHohl.Wandstärke, rechteckHohl.Breite / 2 - rechteckHohl.Wandstärke, -rechteckHohl.Höhe / 2 + rechteckHohl.Wandstärke);
            catLine12D2.StartPoint = catPoint12D2;
            catLine12D2.EndPoint = catPoint12D3;


            //Linie Horizontal Unten
            Line2D catLine2D3 = factory2D.CreateLine(rechteckHohl.Breite / 2, -rechteckHohl.Höhe / 2, -rechteckHohl.Breite / 2, -rechteckHohl.Höhe / 2);
            catLine2D3.StartPoint = catPoint2D3;
            catLine2D3.EndPoint = catPoint2D4;

            //Linie Horizontal Unten Innen
            Line2D catLine12D3 = factory2D.CreateLine(rechteckHohl.Breite / 2 - rechteckHohl.Wandstärke, -rechteckHohl.Höhe / 2 + rechteckHohl.Wandstärke, -rechteckHohl.Breite / 2 + rechteckHohl.Wandstärke, -rechteckHohl.Höhe / 2 + rechteckHohl.Wandstärke);
            catLine12D3.StartPoint = catPoint12D3;
            catLine12D3.EndPoint = catPoint12D4;



            //Linie Vertikal Links
            Line2D catLine2D4 = factory2D.CreateLine(-rechteckHohl.Breite / 2, rechteckHohl.Höhe / 2, -rechteckHohl.Breite / 2, -rechteckHohl.Höhe / 2);
            catLine2D4.StartPoint = catPoint2D4;
            catLine2D4.EndPoint = catPoint2D1;

            //Linie Vertikal Links Innen
            Line2D catLine12D4 = factory2D.CreateLine(-rechteckHohl.Breite / 2 + rechteckHohl.Wandstärke, rechteckHohl.Höhe / 2 - rechteckHohl.Wandstärke, -rechteckHohl.Breite / 2 + rechteckHohl.Wandstärke, -rechteckHohl.Höhe / 2 + rechteckHohl.Wandstärke);
            catLine12D4.StartPoint = catPoint12D4;
            catLine12D4.EndPoint = catPoint12D1;

            // Skizzierer verlassen
            hspB1_catia_Profil.CloseEdition();


            // Part aktualisieren
            hspB1_catiaPart.Part.Update();


        }

        //Erzeugen der Extrusion für RechteckHohl
        internal void ErzeugeExtrusionRechteckHohl(RechteckHohl rechteckHohl)
        {
            hspB1_catiaPart.Part.InWorkObject = hspB1_catiaPart.Part.MainBody;


            // Extrusion erzeugen

            ShapeFactory catShapeFactory1 = (ShapeFactory)hspB1_catiaPart.Part.ShapeFactory;
            Pad catPad1 = catShapeFactory1.AddNewPad(hspB1_catia_Profil, rechteckHohl.Länge);

            // Block umbenennen
            catPad1.set_Name("Profil Rechteck hohl");

            // Part aktualisieren
            hspB1_catiaPart.Part.Update();

        }
        //Ende RechteckVoll


        //Sechseck 
        //Erzeugen der Geometrie Sechseck
        internal void ErzeugeSechseckVoll(SechseckVoll neuSechseckVoll)
        {


            hspB1_catia_Profil.set_Name("Sechseck");
            Factory2D factory2D = hspB1_catia_Profil.OpenEdition();

            //Setzen der Punkte
            Point2D catPoint2D1 = factory2D.CreatePoint(-neuSechseckVoll.Radius/2,Math.Sqrt(neuSechseckVoll.Radius* neuSechseckVoll.Radius-((neuSechseckVoll.Radius/2)* (neuSechseckVoll.Radius / 2))));
            Point2D catPoint2D2 = factory2D.CreatePoint(neuSechseckVoll.Radius / 2, Math.Sqrt(neuSechseckVoll.Radius * neuSechseckVoll.Radius - ((neuSechseckVoll.Radius / 2) * (neuSechseckVoll.Radius / 2))));
            Point2D catPoint2D3 = factory2D.CreatePoint(neuSechseckVoll.Radius,0);
            Point2D catPoint2D4 = factory2D.CreatePoint(neuSechseckVoll.Radius / 2,- Math.Sqrt(neuSechseckVoll.Radius * neuSechseckVoll.Radius - ((neuSechseckVoll.Radius / 2) * (neuSechseckVoll.Radius / 2))));

            Point2D catPoint2D5 = factory2D.CreatePoint(-neuSechseckVoll.Radius /2,- Math.Sqrt(neuSechseckVoll.Radius * neuSechseckVoll.Radius - ((neuSechseckVoll.Radius / 2) * (neuSechseckVoll.Radius / 2))));
            Point2D catPoint2D6 = factory2D.CreatePoint(-neuSechseckVoll.Radius,0);


            // Linien
            Line2D catLine2D1 = factory2D.CreateLine(-neuSechseckVoll.Radius / 2, Math.Sqrt(neuSechseckVoll.Radius * neuSechseckVoll.Radius - ((neuSechseckVoll.Radius / 2) * (neuSechseckVoll.Radius / 2))), neuSechseckVoll.Radius / 2, Math.Sqrt(neuSechseckVoll.Radius * neuSechseckVoll.Radius - ((neuSechseckVoll.Radius / 2) * (neuSechseckVoll.Radius / 2))));
            catLine2D1.StartPoint = catPoint2D1;
            catLine2D1.EndPoint = catPoint2D2;

            Line2D catLine2D2 = factory2D.CreateLine(neuSechseckVoll.Radius / 2, Math.Sqrt(neuSechseckVoll.Radius * neuSechseckVoll.Radius - ((neuSechseckVoll.Radius / 2) * (neuSechseckVoll.Radius / 2))),neuSechseckVoll.Radius, 0);
            catLine2D2.StartPoint = catPoint2D2;
            catLine2D2.EndPoint = catPoint2D3;

            Line2D catLine2D3 = factory2D.CreateLine(neuSechseckVoll.Radius, 0, neuSechseckVoll.Radius / 2, -Math.Sqrt(neuSechseckVoll.Radius * neuSechseckVoll.Radius - ((neuSechseckVoll.Radius / 2) * (neuSechseckVoll.Radius / 2))));
            catLine2D3.StartPoint = catPoint2D3;
            catLine2D3.EndPoint = catPoint2D4;
            
            Line2D catLine2D4 = factory2D.CreateLine(neuSechseckVoll.Radius / 2, -Math.Sqrt(neuSechseckVoll.Radius * neuSechseckVoll.Radius - ((neuSechseckVoll.Radius / 2) * (neuSechseckVoll.Radius / 2))), -neuSechseckVoll.Radius / 2, -Math.Sqrt(neuSechseckVoll.Radius * neuSechseckVoll.Radius - ((neuSechseckVoll.Radius / 2) * (neuSechseckVoll.Radius / 2))));
            catLine2D4.StartPoint = catPoint2D4;
            catLine2D4.EndPoint = catPoint2D5;

            Line2D catLine2D5 = factory2D.CreateLine(-neuSechseckVoll.Radius /2, - Math.Sqrt(neuSechseckVoll.Radius * neuSechseckVoll.Radius - ((neuSechseckVoll.Radius / 2) * (neuSechseckVoll.Radius / 2))), -neuSechseckVoll.Radius, 0);
            catLine2D5.StartPoint = catPoint2D5;
            catLine2D5.EndPoint = catPoint2D6;

            Line2D catLine2D6 = factory2D.CreateLine(-neuSechseckVoll.Radius, 0, -neuSechseckVoll.Radius / 2, Math.Sqrt(neuSechseckVoll.Radius * neuSechseckVoll.Radius - ((neuSechseckVoll.Radius / 2) * (neuSechseckVoll.Radius / 2))));
            catLine2D6.StartPoint = catPoint2D6;
            catLine2D6.EndPoint = catPoint2D1;



            // Skizzierer verlassen
            hspB1_catia_Profil.CloseEdition();


            // Part aktualisieren
            hspB1_catiaPart.Part.Update();


        }

        //Erzeugen der Extrusionfür Sechseck
        internal void ErzeugeExtrusionSechseck(SechseckVoll neuSechseckVoll)
        {
            hspB1_catiaPart.Part.InWorkObject = hspB1_catiaPart.Part.MainBody;


            // Extrusion erzeugen
            ShapeFactory catShapeFactory1 = (ShapeFactory)hspB1_catiaPart.Part.ShapeFactory;
            Pad catPad1 = catShapeFactory1.AddNewPad(hspB1_catia_Profil, neuSechseckVoll.Länge);

            // Block umbenennen
            catPad1.set_Name("Sechseck");

            // Part aktualisieren
            hspB1_catiaPart.Part.Update();

        }
        //Ende Sechseck


        //Hier Enden die Rechteckprofile!!












        //Hier beginnen FormProfile


        //TProfiiiiiiiiiiiiiiiiiiiiiiil!
        //Erzeugen der Geometrie T Profil
        internal void ErzeugeTProfil(TProfil neuTProfil)
        {


            hspB1_catia_Profil.set_Name("T_Profil");
            Factory2D factory2D = hspB1_catia_Profil.OpenEdition();

            //Setzen der Punkte
            Point2D catPoint2D1 = factory2D.CreatePoint(-neuTProfil.B1 / 2, neuTProfil.H2 / 2);
            Point2D catPoint2D2 = factory2D.CreatePoint(neuTProfil.B1 / 2, neuTProfil.H2 / 2);
            Point2D catPoint2D3 = factory2D.CreatePoint(neuTProfil.B1 / 2, -neuTProfil.H2 / 2);
            Point2D catPoint2D4 = factory2D.CreatePoint(neuTProfil.B2 / 2, -neuTProfil.H2 / 2);

            Point2D catPoint2D5 = factory2D.CreatePoint(neuTProfil.B2 / 2, -(neuTProfil.H1 - neuTProfil.H2 / 2));
            Point2D catPoint2D6 = factory2D.CreatePoint(-neuTProfil.B2 / 2, -(neuTProfil.H1 - neuTProfil.H2 / 2));
            Point2D catPoint2D7 = factory2D.CreatePoint(-neuTProfil.B2 / 2, -neuTProfil.H2 / 2);
            Point2D catPoint2D8 = factory2D.CreatePoint(-neuTProfil.B1 / 2, -neuTProfil.H2 / 2);

            //       _____
            //      |_   _| Linie fehlt= skizierte Linie
            //        |_|
            //       
            //      |_   _|
            //        |_|

            Line2D catLine2D1 = factory2D.CreateLine(-neuTProfil.B1 / 2, neuTProfil.H2 / 2, neuTProfil.B1 / 2, neuTProfil.H2 / 2);
            catLine2D1.StartPoint = catPoint2D1;
            catLine2D1.EndPoint = catPoint2D2;


            //       _____
            //      |_   _
            //        |_|
            Line2D catLine2D2 = factory2D.CreateLine(neuTProfil.B1 / 2, neuTProfil.H2 / 2, neuTProfil.B1 / 2, -neuTProfil.H2 / 2);
            catLine2D2.StartPoint = catPoint2D2;
            catLine2D2.EndPoint = catPoint2D3;


            //       _____
            //      |_    |
            //        |_|
            Line2D catLine2D3 = factory2D.CreateLine(neuTProfil.B1 / 2, -neuTProfil.H2 / 2, neuTProfil.B2 / 2, -neuTProfil.H2 / 2);
            catLine2D3.StartPoint = catPoint2D3;
            catLine2D3.EndPoint = catPoint2D4;

            //       _____
            //      |_   _|
            //        |_
            Line2D catLine2D4 = factory2D.CreateLine(neuTProfil.B2 / 2, -neuTProfil.H2 / 2, neuTProfil.B2 / 2, -(neuTProfil.H1 - neuTProfil.H2 / 2));
            catLine2D4.StartPoint = catPoint2D4;
            catLine2D4.EndPoint = catPoint2D5;

            //       _____
            //      |_   _|
            //        | |

            Line2D catLine2D5 = factory2D.CreateLine(neuTProfil.B2 / 2, -(neuTProfil.H1 - neuTProfil.H2 / 2), -neuTProfil.B2 / 2, -(neuTProfil.H1 - neuTProfil.H2 / 2));
            catLine2D5.StartPoint = catPoint2D5;
            catLine2D5.EndPoint = catPoint2D6;

            //       _____
            //      |_   _|
            //         _|
            Line2D catLine2D6 = factory2D.CreateLine(-neuTProfil.B2 / 2, -(neuTProfil.H1 - neuTProfil.H2 / 2), -neuTProfil.B2 / 2, -neuTProfil.H2 / 2);
            catLine2D6.StartPoint = catPoint2D6;
            catLine2D6.EndPoint = catPoint2D7;
            //       _____
            //      |    _|
            //        |_|
            Line2D catLine2D7 = factory2D.CreateLine(-neuTProfil.B2 / 2, -neuTProfil.H2 / 2, -neuTProfil.B1 / 2, -neuTProfil.H2 / 2);
            catLine2D7.StartPoint = catPoint2D7;
            catLine2D7.EndPoint = catPoint2D8;
            //       _____
            //       _   _|
            //        |_|
            Line2D catLine2D8 = factory2D.CreateLine(-neuTProfil.B1 / 2, -neuTProfil.H2 / 2, -neuTProfil.B1 / 2, neuTProfil.H2 / 2);
            catLine2D8.StartPoint = catPoint2D8;
            catLine2D8.EndPoint = catPoint2D1;

            // Skizzierer verlassen
            hspB1_catia_Profil.CloseEdition();


            // Part aktualisieren
            hspB1_catiaPart.Part.Update();


        }

        //Erzeugen der Extrusionfür T Profil
        internal void ErzeugeExtrusionT(TProfil neuTProfil)
        {
            hspB1_catiaPart.Part.InWorkObject = hspB1_catiaPart.Part.MainBody;


            // Extrusion erzeugen
            ShapeFactory catShapeFactory1 = (ShapeFactory)hspB1_catiaPart.Part.ShapeFactory;
            Pad catPad1 = catShapeFactory1.AddNewPad(hspB1_catia_Profil, neuTProfil.Länge);

            // Block umbenennen
            catPad1.set_Name("Profil T");

            // Part aktualisieren
            hspB1_catiaPart.Part.Update();

        }
        //Ende TProfiiiiiiiiiiiiiiiiiiiiiiil

        //L Profiiil
        //Erzeugen der Geometrie L Profil
        internal void ErzeugeLProfil(LProfil neuLProfil)
        {


            hspB1_catia_Profil.set_Name("L_Profil");
            Factory2D factory2D = hspB1_catia_Profil.OpenEdition();

            //Setzen der Punkte
            Point2D catPoint2D1 = factory2D.CreatePoint(-neuLProfil.B2 / 2, neuLProfil.H1- neuLProfil.H2 / 2);
            Point2D catPoint2D2 = factory2D.CreatePoint(neuLProfil.B2 /2, neuLProfil.H1 - neuLProfil.H2 / 2);
            Point2D catPoint2D3 = factory2D.CreatePoint(neuLProfil.B2/2, neuLProfil.H2 / 2);
            Point2D catPoint2D4 = factory2D.CreatePoint(neuLProfil.B1 - neuLProfil.B2/2, neuLProfil.H2 / 2);

            Point2D catPoint2D5 = factory2D.CreatePoint(neuLProfil.B1 - neuLProfil.B2 / 2, -neuLProfil.H2 / 2);
            Point2D catPoint2D6 = factory2D.CreatePoint(-neuLProfil.B2 / 2, -neuLProfil.H2 / 2);
           

            //       _
            //      | |_     Linie fehlt= skizierte Linie
            //      |___|
            //       
            //      | |_     
            //      |___|

            Line2D catLine2D1 = factory2D.CreateLine(-neuLProfil.B2 / 2, neuLProfil.H1 - neuLProfil.H2 / 2,neuLProfil.B2 / 2, neuLProfil.H1 - neuLProfil.H2 / 2);
            catLine2D1.StartPoint = catPoint2D1;
            catLine2D1.EndPoint = catPoint2D2;


            //       _
            //      |  _     
            //      |___|
            Line2D catLine2D2 = factory2D.CreateLine(neuLProfil.B2 / 2, neuLProfil.H1 - neuLProfil.H2 / 2, neuLProfil.B2 / 2, neuLProfil.H2 / 2);
            catLine2D2.StartPoint = catPoint2D2;
            catLine2D2.EndPoint = catPoint2D3;

            //       _
            //      | |    
            //      |___|

            Line2D catLine2D3 = factory2D.CreateLine(neuLProfil.B2 / 2, neuLProfil.H2 / 2, neuLProfil.B1 - neuLProfil.B2 / 2, neuLProfil.H2 / 2);
            catLine2D3.StartPoint = catPoint2D3;
            catLine2D3.EndPoint = catPoint2D4;
            //       _
            //      | |_     
            //      |___

            Line2D catLine2D4 = factory2D.CreateLine(neuLProfil.B1 - neuLProfil.B2 / 2, neuLProfil.H2 / 2, neuLProfil.B1 - neuLProfil.B2 / 2, -neuLProfil.H2 / 2);
            catLine2D4.StartPoint = catPoint2D4;
            catLine2D4.EndPoint = catPoint2D5;


            //       _
            //      | |_     
            //      |   |
            Line2D catLine2D5 = factory2D.CreateLine(neuLProfil.B1 + neuLProfil.B2, -neuLProfil.H2 / 2, -neuLProfil.B2 / 2, -neuLProfil.H2 / 2);
            catLine2D5.StartPoint = catPoint2D5;
            catLine2D5.EndPoint = catPoint2D6;

            //       _
            //        |_     
            //       ___|
            Line2D catLine2D6 = factory2D.CreateLine(-neuLProfil.B2 / 2, -neuLProfil.H2 / 2, -neuLProfil.B2 / 2, neuLProfil.H1 - neuLProfil.H2 / 2);
            catLine2D6.StartPoint = catPoint2D6;
            catLine2D6.EndPoint = catPoint2D1;
           
           

            // Skizzierer verlassen
            hspB1_catia_Profil.CloseEdition();


            // Part aktualisieren
            hspB1_catiaPart.Part.Update();


        }

        //Erzeugen der Extrusionfür L Profil
        internal void ErzeugeExtrusionL(LProfil neuLProfil)
        {
            hspB1_catiaPart.Part.InWorkObject = hspB1_catiaPart.Part.MainBody;


            // Extrusion erzeugen
            ShapeFactory catShapeFactory1 = (ShapeFactory)hspB1_catiaPart.Part.ShapeFactory;
            Pad catPad1 = catShapeFactory1.AddNewPad(hspB1_catia_Profil, neuLProfil.Länge);

            // Block umbenennen
            catPad1.set_Name("Profil L");

            // Part aktualisieren
            hspB1_catiaPart.Part.Update();

        }
        //Ende L Profil

        //UProfil!
        //Erzeugen der Geometrie U Profil
        internal void ErzeugeUProfil(UProfil neuUProfil)
        {


            hspB1_catia_Profil.set_Name("U_Profil");
            Factory2D factory2D = hspB1_catia_Profil.OpenEdition();

            //Setzen der Punkte
            Point2D catPoint2D1 = factory2D.CreatePoint(-neuUProfil.B2 / 2, neuUProfil.H1 / 2);
            Point2D catPoint2D2 = factory2D.CreatePoint(neuUProfil.B1-neuUProfil.B2/2, neuUProfil.H1 / 2);
            Point2D catPoint2D3 = factory2D.CreatePoint(neuUProfil.B1 - neuUProfil.B2 / 2, neuUProfil.H1 /2 -neuUProfil.H2);
            Point2D catPoint2D4 = factory2D.CreatePoint(neuUProfil.B2 / 2, neuUProfil.H1 / 2 - neuUProfil.H2);

            Point2D catPoint2D5 = factory2D.CreatePoint(neuUProfil.B2 / 2,- (neuUProfil.H1 / 2 - neuUProfil.H2));
            Point2D catPoint2D6 = factory2D.CreatePoint(neuUProfil.B1 - neuUProfil.B2 / 2,- (neuUProfil.H1 / 2 - neuUProfil.H2));
            Point2D catPoint2D7 = factory2D.CreatePoint(neuUProfil.B1 - neuUProfil.B2 / 2,- neuUProfil.H1 / 2);
            Point2D catPoint2D8 = factory2D.CreatePoint(-neuUProfil.B2 / 2, -neuUProfil.H1 / 2);

            //        ____
            //       |   _|
            //       |  |_      Linie fehlt = skizierte Linie
            //       |____|


            //        
            //       |   _|
            //       |  |_
            //       |____|
            Line2D catLine2D1 = factory2D.CreateLine(-neuUProfil.B2 / 2, neuUProfil.H1 / 2, neuUProfil.B1 - neuUProfil.B2 / 2, neuUProfil.H1 / 2);
            catLine2D1.StartPoint = catPoint2D1;
            catLine2D1.EndPoint = catPoint2D2;
            //        ____
            //       |   _
            //       |  |_
            //       |____|
            Line2D catLine2D2 = factory2D.CreateLine(neuUProfil.B1 - neuUProfil.B2 / 2, neuUProfil.H1 / 2, neuUProfil.B1 - neuUProfil.B2 / 2, neuUProfil.H1 / 2 - neuUProfil.H2);
            catLine2D2.StartPoint = catPoint2D2;
            catLine2D2.EndPoint = catPoint2D3;
            //        ____
            //       |    |
            //       |  |_
            //       |____|
            Line2D catLine2D3 = factory2D.CreateLine(neuUProfil.B1 - neuUProfil.B2 / 2, neuUProfil.H1 / 2 - neuUProfil.H2, neuUProfil.B2 / 2, neuUProfil.H1 / 2 - neuUProfil.H2);
            catLine2D3.StartPoint = catPoint2D3;
            catLine2D3.EndPoint = catPoint2D4;
            //        ____
            //       |   _|
            //       |   _
            //       |____|
            Line2D catLine2D4 = factory2D.CreateLine(neuUProfil.B2 / 2, neuUProfil.H1 / 2 - neuUProfil.H2, -neuUProfil.B2 / 2, (neuUProfil.H1 / 2 - neuUProfil.H2));
            catLine2D4.StartPoint = catPoint2D4;
            catLine2D4.EndPoint = catPoint2D5;
            //        ____
            //       |   _|
            //       |  |
            //       |____|
            Line2D catLine2D5 = factory2D.CreateLine(neuUProfil.B2 / 2, -(neuUProfil.H1 / 2 - neuUProfil.H2), neuUProfil.B1 - neuUProfil.B2 / 2, -(neuUProfil.H1 / 2 - neuUProfil.H2));
            catLine2D5.StartPoint = catPoint2D5;
            catLine2D5.EndPoint = catPoint2D6;
            //        ____
            //       |   _|
            //       |  |_
            //       |____
            Line2D catLine2D6 = factory2D.CreateLine(neuUProfil.B1 - neuUProfil.B2 / 2, -(neuUProfil.H1 / 2 - neuUProfil.H2), neuUProfil.B1 - neuUProfil.B2 / 2, -neuUProfil.H1 / 2);
            catLine2D6.StartPoint = catPoint2D6;
            catLine2D6.EndPoint = catPoint2D7;
            //        ____
            //       |   _|
            //       |  |_
            //       |    |
            Line2D catLine2D7 = factory2D.CreateLine(neuUProfil.B1 - neuUProfil.B2 / 2, -neuUProfil.H1 / 2, -neuUProfil.B2 / 2, -neuUProfil.H1 / 2);
            catLine2D7.StartPoint = catPoint2D7;
            catLine2D7.EndPoint = catPoint2D8;
            //       ____
            //          _|
            //         |_
            //       ____|
            Line2D catLine2D8 = factory2D.CreateLine(-neuUProfil.B2 / 2, -neuUProfil.H1 / 2, -neuUProfil.B2 / 2, neuUProfil.H1 / 2);
            catLine2D8.StartPoint = catPoint2D8;
            catLine2D8.EndPoint = catPoint2D1;

            // Skizzierer verlassen
            hspB1_catia_Profil.CloseEdition();


            // Part aktualisieren
            hspB1_catiaPart.Part.Update();


        }

        //Erzeugen der Extrusionfür U Profil
        internal void ErzeugeExtrusionU(UProfil neuUProfil)
        {
            hspB1_catiaPart.Part.InWorkObject = hspB1_catiaPart.Part.MainBody;


            // Extrusion erzeugen
            ShapeFactory catShapeFactory1 = (ShapeFactory)hspB1_catiaPart.Part.ShapeFactory;
            Pad catPad1 = catShapeFactory1.AddNewPad(hspB1_catia_Profil, neuUProfil.Länge);

            // Block umbenennen
            catPad1.set_Name("Profil U");

            // Part aktualisieren
            hspB1_catiaPart.Part.Update();

        }
        //Ende UProfil

        //IProfil!
        //Erzeugen der Geometrie I Profil
        internal void ErzeugeIProfil(IProfil neuIProfil)
        {


            hspB1_catia_Profil.set_Name("I_Profil");
            Factory2D factory2D = hspB1_catia_Profil.OpenEdition();

            //Setzen der Punkte
            Point2D catPoint2D1 = factory2D.CreatePoint(-neuIProfil.B1 / 2, neuIProfil.H1 / 2);
            Point2D catPoint2D2 = factory2D.CreatePoint(neuIProfil.B1 / 2, neuIProfil.H1 / 2);
            Point2D catPoint2D3 = factory2D.CreatePoint(neuIProfil.B1 / 2, neuIProfil.H1 / 2-neuIProfil.H2);
            Point2D catPoint2D4 = factory2D.CreatePoint(neuIProfil.B2 / 2, neuIProfil.H1 / 2 - neuIProfil.H2);

            Point2D catPoint2D5 = factory2D.CreatePoint(neuIProfil.B2 / 2, -(neuIProfil.H1 / 2 - neuIProfil.H2));
            Point2D catPoint2D6 = factory2D.CreatePoint(neuIProfil.B1 / 2, -(neuIProfil.H1 / 2 - neuIProfil.H2));
            Point2D catPoint2D7 = factory2D.CreatePoint(neuIProfil.B1 / 2, -neuIProfil.H1 / 2);
            Point2D catPoint2D8 = factory2D.CreatePoint(- neuIProfil.B1 / 2, -neuIProfil.H1 / 2);

            Point2D catPoint2D9 = factory2D.CreatePoint(-neuIProfil.B1 / 2, -(neuIProfil.H1 / 2 - neuIProfil.H2));
            Point2D catPoint2D10 = factory2D.CreatePoint(-neuIProfil.B2 / 2, -(neuIProfil.H1 / 2 - neuIProfil.H2));
            Point2D catPoint2D11 = factory2D.CreatePoint(-neuIProfil.B2 / 2, neuIProfil.H1 / 2 - neuIProfil.H2);
            Point2D catPoint2D12 = factory2D.CreatePoint(-neuIProfil.B1 / 2, neuIProfil.H1 / 2 - neuIProfil.H2);

            //       _____
            //      |_   _| Linie fehlt= skizierte Linie
            //       _| |_
            //      |_____|

            //       
            //      |_   _| 
            //       _| |_
            //      |_____|
            Line2D catLine2D1 = factory2D.CreateLine(-neuIProfil.B1 / 2, neuIProfil.H1 / 2, neuIProfil.B1 / 2, neuIProfil.H1 / 2);
            catLine2D1.StartPoint = catPoint2D1;
            catLine2D1.EndPoint = catPoint2D2;

            //       _____
            //      |_   _
            //       _| |_
            //      |_____|
            Line2D catLine2D2 = factory2D.CreateLine(neuIProfil.B1 / 2, neuIProfil.H1 / 2, neuIProfil.B1 / 2, neuIProfil.H1 / 2 - neuIProfil.H2);
            catLine2D2.StartPoint = catPoint2D2;
            catLine2D2.EndPoint = catPoint2D3;


            //       _____
            //      |_    | 
            //       _| |_
            //      |_____|
            Line2D catLine2D3 = factory2D.CreateLine(neuIProfil.B1 / 2, neuIProfil.H1 / 2 - neuIProfil.H2, neuIProfil.B2 / 2, neuIProfil.H1 / 2 - neuIProfil.H2);
            catLine2D3.StartPoint = catPoint2D3;
            catLine2D3.EndPoint = catPoint2D4;

            //       _____
            //      |_   _| 
            //       _|  _
            //      |_____|
            Line2D catLine2D4 = factory2D.CreateLine(neuIProfil.B2 / 2, neuIProfil.H1 / 2 - neuIProfil.H2, neuIProfil.B2 / 2, -(neuIProfil.H1 / 2 - neuIProfil.H2));
            catLine2D4.StartPoint = catPoint2D4;
            catLine2D4.EndPoint = catPoint2D5;

            //       _____
            //      |_   _| 
            //       _| |
            //      |_____|
            Line2D catLine2D5 = factory2D.CreateLine(neuIProfil.B2 / 2, -(neuIProfil.H1 / 2 - neuIProfil.H2), neuIProfil.B1 / 2, -(neuIProfil.H1 / 2 - neuIProfil.H2));
            catLine2D5.StartPoint = catPoint2D5;
            catLine2D5.EndPoint = catPoint2D6;
            //       _____
            //      |_   _| 
            //       _| |_
            //      |_____
            Line2D catLine2D6 = factory2D.CreateLine(neuIProfil.B1 / 2, -(neuIProfil.H1 / 2 - neuIProfil.H2), neuIProfil.B1 / 2, -neuIProfil.H1 / 2);
            catLine2D6.StartPoint = catPoint2D6;
            catLine2D6.EndPoint = catPoint2D7;
            //       _____
            //      |_   _| 
            //       _| |_
            //      |     |
            Line2D catLine2D7 = factory2D.CreateLine(neuIProfil.B1 / 2, -neuIProfil.H1 / 2, -neuIProfil.B1 / 2, -neuIProfil.H1 / 2);
            catLine2D7.StartPoint = catPoint2D7;
            catLine2D7.EndPoint = catPoint2D8;
            //       _____
            //      |_   _| 
            //       _| |_
            //       _____|
            Line2D catLine2D8 = factory2D.CreateLine(-neuIProfil.B1 / 2, -neuIProfil.H1 / 2, -neuIProfil.B1 / 2, -(neuIProfil.H1 / 2 - neuIProfil.H2));
            catLine2D8.StartPoint = catPoint2D8;
            catLine2D8.EndPoint = catPoint2D9;

            //       _____
            //      |_   _| 
            //        | |_
            //      |_____|
            Line2D catLine2D9 = factory2D.CreateLine(-neuIProfil.B1 / 2, -(neuIProfil.H1 / 2 - neuIProfil.H2), -neuIProfil.B2 / 2, -(neuIProfil.H1 / 2 - neuIProfil.H2));
            catLine2D9.StartPoint = catPoint2D9;
            catLine2D9.EndPoint = catPoint2D10;
            //       _____
            //      |_   _| 
            //       _  |_
            //      |_____|
            Line2D catLine2D10 = factory2D.CreateLine(-neuIProfil.B2 / 2, -(neuIProfil.H1 / 2 -neuIProfil.H2), -neuIProfil.B2 / 2, neuIProfil.H1 / 2 - neuIProfil.H2);
            catLine2D10.StartPoint = catPoint2D10;
            catLine2D10.EndPoint = catPoint2D11;
            //       _____
            //      |    _| 
            //       _| |_
            //      |_____|
            Line2D catLine2D11 = factory2D.CreateLine(-neuIProfil.B2 / 2, neuIProfil.H1 / 2 - neuIProfil.H2, -neuIProfil.B1 / 2, neuIProfil.H1 / 2 - neuIProfil.H2);
            catLine2D11.StartPoint = catPoint2D11;
            catLine2D11.EndPoint = catPoint2D12;
            //       _____
            //       _   _| 
            //       _| |_
            //      |_____|
            Line2D catLine2D12 = factory2D.CreateLine(-neuIProfil.B1 / 2, neuIProfil.H1 / 2 - neuIProfil.H2, -neuIProfil.B1 / 2, neuIProfil.H1 / 2);
            catLine2D12.StartPoint = catPoint2D12;
            catLine2D12.EndPoint = catPoint2D1;

            // Skizzierer verlassen
            hspB1_catia_Profil.CloseEdition();


            // Part aktualisieren
            hspB1_catiaPart.Part.Update();


        }

        //Erzeugen der Extrusionfür I Profil
        internal void ErzeugeExtrusionI(IProfil neuIProfil)
        {
            hspB1_catiaPart.Part.InWorkObject = hspB1_catiaPart.Part.MainBody;


            // Extrusion erzeugen
            ShapeFactory catShapeFactory1 = (ShapeFactory)hspB1_catiaPart.Part.ShapeFactory;
            Pad catPad1 = catShapeFactory1.AddNewPad(hspB1_catia_Profil, neuIProfil.Länge);

            // Block umbenennen
            catPad1.set_Name("Profil I");

            // Part aktualisieren
            hspB1_catiaPart.Part.Update();

        }
        //Ende I Profil


        //Hier Enden die Formprofile!!!




        // Hier beginnen die runden Profile!!!

        //Anfang RundHohlProfil!!

        internal void ErzeugeProfilRundHohlProfil(RundHohlProfil rundHohlProfil)
        {
            hspB1_catia_Profil.set_Name("RundHohlProfil");
            Factory2D factory2D = hspB1_catia_Profil.OpenEdition();


            //Setzen der Punkte/Kreise

            Point2D catpoint2D1 = factory2D.CreatePoint(0, 0);
            
            Circle2D catCircle2D1 = factory2D.CreateCircle(0, 0, rundHohlProfil.Durchmesser / 2, 0, 0);
            catCircle2D1.CenterPoint = catpoint2D1;
            
            Circle2D catCircle2D2 = factory2D.CreateCircle(0, 0, (rundHohlProfil.Durchmesser - rundHohlProfil.Wandstärke) / 2, 0, 0);
            catCircle2D2.CenterPoint = catpoint2D1;


            // Skizzierer verlassen
            hspB1_catia_Profil.CloseEdition();

            // Part aktualisieren
            hspB1_catiaPart.Part.Update();


        }

        //Erzeugen der Extrusion für RechteckHohl
        internal void ErzeugeExtrusionRundHohlProfil(RundHohlProfil rundHohlProfil)
        {
            hspB1_catiaPart.Part.InWorkObject = hspB1_catiaPart.Part.MainBody;


            // Extrusion erzeugen
            ShapeFactory catShapeFactory1 = (ShapeFactory)hspB1_catiaPart.Part.ShapeFactory;
            Pad catPad1 = catShapeFactory1.AddNewPad(hspB1_catia_Profil, rundHohlProfil.Länge);

            // Block umbenennen
            catPad1.set_Name("RundHohlProfil");

            // Part aktualisieren
            hspB1_catiaPart.Part.Update();

        }

        //Ende RundHohlProfil



    }
}
