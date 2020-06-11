using Microsoft.Office.Interop.Excel;
using PARTITF;
using Profile_Muster;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using INFITF;
using System.Runtime.Remoting.Messaging;

namespace WpfHSPB1
{
    class ExcelApi
    {
        //Tooltipps erweitern
        Excel.Application excelApp = new Excel.Application();
        Excel._Worksheet mySheet;
        Excel.Range last;
        Excel.Range Xrange;
        Excel.Borders myBorders;
      

        int i = 1;
        int z = 2;
      
        
        internal void ExelControll()
        {

            

            excelApp.Visible = true;
            
            excelApp.Workbooks.Add();

            excelApp.WindowState = Excel.XlWindowState.xlMinimized;


            mySheet = (Excel.Worksheet)excelApp.ActiveSheet;



            mySheet.Cells[1, "A"] = "Lfd. Nr. ";
            mySheet.Cells[1, "B"] = "Profl Bezeichnung      ";
            mySheet.Cells[1, "C"] = "Höhe in mm ";
            mySheet.Cells[1, "D"] = "Breite in mm ";
            mySheet.Cells[1, "E"] = "Durchmesser in mm ";
            mySheet.Cells[1, "F"] = "Wandstärke t in mm ";
            mySheet.Cells[1, "G"] = "Wandstärke s in mm ";
            mySheet.Cells[1, "H"] = "Länge in mm ";
            mySheet.Cells[1, "I"] = "Fläche As in mm² ";
            mySheet.Cells[1, "J"] = "Volumen in mm³ ";
            mySheet.Cells[1, "K"] = "Wy in cm³ ";
            mySheet.Cells[1, "L"] = "Wz in cm³ ";
            mySheet.Cells[1, "M"] = "Iy in cm^4 ";
            mySheet.Cells[1, "N"] = "Iz in cm^4 ";
            mySheet.Cells[1, "O"] = "FTM Polar in cm^4 ";
          





        
            last = mySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);           
            Xrange = mySheet.get_Range("A1", last);


         
           

            myBorders = Xrange.Borders;
            myBorders.LineStyle = Excel.XlLineStyle.xlContinuous;
            myBorders.Weight = 4d;



            //Einstellung der Schriftgröße
            mySheet.Range["A1"].EntireRow.Font.Size = 14;
            mySheet.Range["B2"].EntireColumn.Font.Size = 12;
            mySheet.Range["C2"].EntireColumn.Font.Size = 12;
            mySheet.Range["D2"].EntireColumn.Font.Size = 12;
            mySheet.Range["E2"].EntireColumn.Font.Size = 12;
            mySheet.Range["F2"].EntireColumn.Font.Size = 12;
            mySheet.Range["G2"].EntireColumn.Font.Size = 12;
            mySheet.Range["H2"].EntireColumn.Font.Size = 12;
            mySheet.Range["I2"].EntireColumn.Font.Size = 12;
            mySheet.Range["J2"].EntireColumn.Font.Size = 12;
            mySheet.Range["K2"].EntireColumn.Font.Size = 12;
            mySheet.Range["L2"].EntireColumn.Font.Size = 12;
            mySheet.Range["M2"].EntireColumn.Font.Size = 12;
            mySheet.Range["N2"].EntireColumn.Font.Size = 12;
         

            //Geschriebe Daten in Kusiv
            mySheet.Range["B2", "Q2"].EntireColumn.Font.Italic =true;
       

            //Eingaben Zentrieren
            mySheet.Range["A1", "Q1"].EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;


            //Schriftzug Fettwerden lassen          
            mySheet.Range["A1"].EntireRow.Font.Bold = true;
            mySheet.Range["B2"].EntireColumn.Font.Bold = true;


            mySheet.Range["A1","Q2"].EntireColumn.AutoFit();

        }

        //Rechteckige PRofile
        public void ExcelReVo(RechteckVoll rechteckVoll)
        {


            


            mySheet.Cells[z, "A"] = i;
            mySheet.Cells[z, "B"] = "Rechteck Voll";
            mySheet.Cells[z, "C"] = rechteckVoll.Höhe;
            mySheet.Cells[z, "D"] = rechteckVoll.Breite;
            mySheet.Cells[z, "E"] = "";
            mySheet.Cells[z, "F"] = "";
            mySheet.Cells[z, "G"] = "";
            mySheet.Cells[z, "H"] = rechteckVoll.Länge;
            mySheet.Cells[z, "I"] = rechteckVoll.QFläche();
            mySheet.Cells[z, "J"] = rechteckVoll.Volumen();
            mySheet.Cells[z, "K"] = rechteckVoll.WiederstandsMoment_Wy() / 1000;
            mySheet.Cells[z, "L"] = rechteckVoll.WiederstandsMoment_Wz() / 1000;
            mySheet.Cells[z, "M"] = rechteckVoll.FTM_Iy() / 10000;
            mySheet.Cells[z, "N"] = rechteckVoll.FTM_Iz() / 10000;
            mySheet.Cells[z, "O"] = rechteckVoll.FTM_Polar() / 10000;
           

            i++;
            z++;
        }


        public void ExcelReHo(RechteckHohl rechteckHohl)
        {
            mySheet = (Excel.Worksheet)excelApp.ActiveSheet;


            mySheet.Cells[z, "A"] = i;
            mySheet.Cells[z, "B"] = "Rechteck hohl";
            mySheet.Cells[z, "C"] = rechteckHohl.Höhe;
            mySheet.Cells[z, "D"] = rechteckHohl.Breite;
            mySheet.Cells[z, "E"] = "";
            mySheet.Cells[z, "F"] = rechteckHohl.Wandstärke;
            mySheet.Cells[z, "G"] = "";
            mySheet.Cells[z, "H"] = rechteckHohl.Länge;
            mySheet.Cells[z, "I"] = rechteckHohl.QFläche();
            mySheet.Cells[z, "J"] = rechteckHohl.Volumen();
            mySheet.Cells[z, "K"] = rechteckHohl.WiederstandsMoment_Wy() / 1000;
            mySheet.Cells[z, "L"] = rechteckHohl.WiederstandsMoment_Wz() / 1000;
            mySheet.Cells[z, "M"] = rechteckHohl.FTM_Iy() / 10000;
            mySheet.Cells[z, "N"] = rechteckHohl.FTM_Iz() / 10000;
            mySheet.Cells[z, "O"] = rechteckHohl.FTM_Polar() / 10000;

            i++;
            z++;

        }

        public void ExcelSeVo(SechseckVoll sechseckVoll)
        {
            mySheet = (Excel.Worksheet)excelApp.ActiveSheet;


            mySheet.Cells[z, "A"] = i;
            mySheet.Cells[z, "B"] = "Sechseckk voll";
            mySheet.Cells[z, "C"] = "";
            mySheet.Cells[z, "D"] = "";
            mySheet.Cells[z, "E"] = sechseckVoll.Radius * 2;
            mySheet.Cells[z, "F"] = "";
            mySheet.Cells[z, "G"] = "";
            mySheet.Cells[z, "H"] = sechseckVoll.Länge;
            mySheet.Cells[z, "I"] = sechseckVoll.QFläche();
            mySheet.Cells[z, "J"] = sechseckVoll.Volumen();
            mySheet.Cells[z, "K"] = sechseckVoll.WiederstandsMoment_Wy() / 1000;
            mySheet.Cells[z, "L"] = sechseckVoll.WiederstandsMoment_Wz() / 1000;
            mySheet.Cells[z, "M"] = sechseckVoll.FTM_Iy() / 10000;
            mySheet.Cells[z, "N"] = sechseckVoll.FTM_Iz() / 10000;
            mySheet.Cells[z, "O"] = sechseckVoll.FTM_Polar() / 10000;

            i++;
            z++;
        }


        //RundeProfile
        public void ExcelHaRu(HalbrundProfil halbrundProfil)
        {
            mySheet = (Excel.Worksheet)excelApp.ActiveSheet;


            mySheet.Cells[z, "A"] = i;
            mySheet.Cells[z, "B"] = "Halbrund voll";
            mySheet.Cells[z, "C"] = "";
            mySheet.Cells[z, "D"] = "";
            mySheet.Cells[z, "E"] = halbrundProfil.Radius * 2;
            mySheet.Cells[z, "F"] = "";
            mySheet.Cells[z, "G"] = "";
            mySheet.Cells[z, "H"] = halbrundProfil.Länge;
            mySheet.Cells[z, "I"] = halbrundProfil.QFläche();
            mySheet.Cells[z, "J"] = halbrundProfil.Volumen();
            mySheet.Cells[z, "K"] = halbrundProfil.WiederstandsMoment_Wy() / 1000;
            mySheet.Cells[z, "L"] = halbrundProfil.WiederstandsMoment_Wz() / 1000;
            mySheet.Cells[z, "M"] = halbrundProfil.FTM_Iy() / 10000;
            mySheet.Cells[z, "N"] = halbrundProfil.FTM_Iz() / 10000;
            mySheet.Cells[z, "O"] = halbrundProfil.FTM_Polar() / 10000;

            i++;
            z++;

        }

        public void ExcelRundHo(RundHohlProfil neuRundHohl)
        {
            mySheet = (Excel.Worksheet)excelApp.ActiveSheet;


            mySheet.Cells[z, "A"] = i;
            mySheet.Cells[z, "B"] = "Rundhohl";
            mySheet.Cells[z, "C"] = "";
            mySheet.Cells[z, "D"] = "";
            mySheet.Cells[z, "E"] = neuRundHohl.Durchmesser;
            mySheet.Cells[z, "F"] = neuRundHohl.Wandstärke;
            mySheet.Cells[1, "G"] = "";
            mySheet.Cells[z, "H"] = neuRundHohl.Länge;
            mySheet.Cells[z, "I"] = neuRundHohl.QFläche();
            mySheet.Cells[z, "J"] = neuRundHohl.Volumen();
            mySheet.Cells[z, "K"] = neuRundHohl.WiederstandsMoment_Wy() / 1000;
            mySheet.Cells[z, "L"] = neuRundHohl.WiederstandsMoment_Wz() / 1000;
            mySheet.Cells[z, "M"] = neuRundHohl.FTM_Iy() / 10000;
            mySheet.Cells[z, "N"] = neuRundHohl.FTM_Iz() / 10000;
            mySheet.Cells[z, "O"] = neuRundHohl.FTM_Polar() / 10000;

            i++;
            z++;


        }

        public void ExcelRuVo(RundVollProfil rundVoll)
        {
            mySheet = (Excel.Worksheet)excelApp.ActiveSheet;


            mySheet.Cells[z, "A"] = i;
            mySheet.Cells[z, "B"] = "Rundvoll";
            mySheet.Cells[z, "C"] = "";
            mySheet.Cells[z, "D"] = "";
            mySheet.Cells[z, "E"] = rundVoll.Durchmesser;
            mySheet.Cells[z, "F"] = "";
            mySheet.Cells[z, "G"] = "";
            mySheet.Cells[z, "H"] = rundVoll.Länge;
            mySheet.Cells[z, "I"] = rundVoll.QFläche();
            mySheet.Cells[z, "J"] = rundVoll.Volumen();
            mySheet.Cells[z, "K"] = rundVoll.WiederstandsMoment_Wy() / 1000;
            mySheet.Cells[z, "L"] = rundVoll.WiederstandsMoment_Wz() / 1000;
            mySheet.Cells[z, "M"] = rundVoll.FTM_Iy() / 10000;
            mySheet.Cells[z, "N"] = rundVoll.FTM_Iz() / 10000;
            mySheet.Cells[z, "O"] = rundVoll.FTM_Polar() / 10000;

            i++;
            z++;

        }

        //Formprofile
        public void ExcelTProfil(TProfil neuTProfil)
        {
            mySheet = (Excel.Worksheet)excelApp.ActiveSheet;


            mySheet.Cells[z, "A"] = i;
            mySheet.Cells[z, "B"] = "T-Profil";
            mySheet.Cells[z, "C"] = neuTProfil.H2;
            mySheet.Cells[z, "D"] = neuTProfil.B2;
            mySheet.Cells[z, "E"] = "";
            mySheet.Cells[z, "F"] = neuTProfil.H1;
            mySheet.Cells[z, "G"] = neuTProfil.B1;
            mySheet.Cells[z, "H"] = neuTProfil.Länge;
            mySheet.Cells[z, "I"] = neuTProfil.QFläche();
            mySheet.Cells[z, "J"] = neuTProfil.Volumen();
            mySheet.Cells[z, "K"] = neuTProfil.WiederstandsMoment_Wy() / 1000;
            mySheet.Cells[z, "L"] = neuTProfil.WiederstandsMoment_Wz() / 1000;
            mySheet.Cells[z, "M"] = neuTProfil.FTM_Iy() / 10000;
            mySheet.Cells[z, "N"] = neuTProfil.FTM_Iz() / 10000;
            mySheet.Cells[z, "O"] = neuTProfil.FTM_Polar() / 10000;

            i++;
            z++;

        }

        public void ExcelUProfil(UProfil neuUProfil)
        {
            mySheet = (Excel.Worksheet)excelApp.ActiveSheet;


            mySheet.Cells[z, "A"] = i;
            mySheet.Cells[z, "B"] = "U-Profil";
            mySheet.Cells[z, "C"] = neuUProfil.H2;
            mySheet.Cells[z, "D"] = neuUProfil.B2;
            mySheet.Cells[z, "E"] = "";
            mySheet.Cells[z, "F"] = neuUProfil.H1;
            mySheet.Cells[z, "G"] = neuUProfil.B1;
            mySheet.Cells[z, "H"] = neuUProfil.Länge;
            mySheet.Cells[z, "I"] = neuUProfil.QFläche();
            mySheet.Cells[z, "J"] = neuUProfil.Volumen();
            mySheet.Cells[z, "K"] = neuUProfil.WiederstandsMoment_Wy() / 1000;
            mySheet.Cells[z, "L"] = neuUProfil.WiederstandsMoment_Wz() / 1000;
            mySheet.Cells[z, "M"] = neuUProfil.FTM_Iy() / 10000;
            mySheet.Cells[z, "N"] = neuUProfil.FTM_Iz() / 10000;
            mySheet.Cells[z, "O"] = neuUProfil.FTM_Polar() / 10000;

            i++;
            z++;

        }

        public void ExcelIProfil(IProfil neuIProfil)
        {
            mySheet = (Excel.Worksheet)excelApp.ActiveSheet;


            mySheet.Cells[z, "A"] = i;
            mySheet.Cells[z, "B"] = "I-Profil";
            mySheet.Cells[z, "C"] = neuIProfil.H2;
            mySheet.Cells[z, "D"] = neuIProfil.B2;
            mySheet.Cells[z, "E"] = "";
            mySheet.Cells[z, "F"] = neuIProfil.H1;
            mySheet.Cells[z, "G"] = neuIProfil.B1;
            mySheet.Cells[z, "H"] = neuIProfil.Länge;
            mySheet.Cells[z, "I"] = neuIProfil.QFläche();
            mySheet.Cells[z, "J"] = neuIProfil.Volumen();
            mySheet.Cells[z, "K"] = neuIProfil.WiederstandsMoment_Wy() / 1000;
            mySheet.Cells[z, "L"] = neuIProfil.WiederstandsMoment_Wz() / 1000;
            mySheet.Cells[z, "M"] = neuIProfil.FTM_Iy() / 10000;
            mySheet.Cells[z, "N"] = neuIProfil.FTM_Iz() / 10000;
            mySheet.Cells[z, "O"] = neuIProfil.FTM_Polar() / 10000;

            i++;
            z++;

        }

        public void ExcelLProfil(LProfil neuLProfil)
        {
            mySheet = (Excel.Worksheet)excelApp.ActiveSheet;


            mySheet.Cells[z, "A"] = i;
            mySheet.Cells[z, "B"] = "L-Profil";
            mySheet.Cells[z, "C"] = neuLProfil.H1;
            mySheet.Cells[z, "D"] = neuLProfil.B1;
            mySheet.Cells[z, "E"] = "";
            mySheet.Cells[z, "F"] = neuLProfil.H2;
            mySheet.Cells[z, "G"] = neuLProfil.B2;
            mySheet.Cells[z, "H"] = neuLProfil.Länge;
            mySheet.Cells[z, "I"] = neuLProfil.QFläche();
            mySheet.Cells[z, "J"] = neuLProfil.Volumen();
            mySheet.Cells[z, "K"] = neuLProfil.WiederstandsMoment_Wy() / 1000;
            mySheet.Cells[z, "L"] = neuLProfil.WiederstandsMoment_Wz() / 1000;
            mySheet.Cells[z, "M"] = neuLProfil.FTM_Iy() / 10000;
            mySheet.Cells[z, "N"] = neuLProfil.FTM_Iz() / 10000;
            mySheet.Cells[z, "O"] = neuLProfil.FTM_Polar() / 10000;

            i++;
            z++;

        }

   

        public void CloseExel()
        {

         
            excelApp.Quit();
        }
      
    }
}
