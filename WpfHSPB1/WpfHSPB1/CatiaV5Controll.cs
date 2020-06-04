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











    }
}
