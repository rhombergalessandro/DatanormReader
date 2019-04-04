using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatanormReader
{
    class DatanormV05
    {
        //Datanrom Versions 5 properties
        public string V5_Satzartenkennzeichen { get; set; }                    //FeldNR: 01 - max. Feldlänge: 01 - Apha/Numerisch: A (string)
        public string V5_Versionskennung { get; set; }                         //FeldNR: 02 - max. Feldlänge: 03 - Apha/Numerisch: N (int)
        public string V5_Datenkennzeichen { get; set; }                        //FeldNR: 03 - max. Feldlänge: 01 - Apha/Numerisch: A (string)
        public string V5_DatumDerErstellung { get; set; }                      //FeldNR: 04 - max. Feldlänge: 08 - Apha/Numerisch: N (int)
        public string V5_Waehrungskennzeichen { get; set; }                    //FeldNR: 05 - max. Feldlänge: 03 - Apha/Numerisch: A (string)
        public string V5_Dateninhaltsbeschreibung { get; set; }                //FeldNR: 06 - max. Feldlänge: 40 - Apha/Numerisch: A (string)
        public string V5_CopyrightMitteilung { get; set; }                     //FeldNR: 07 - max. Feldlänge: 40 - Apha/Numerisch: A (string)
        public string V5_Datenersteller { get; set; }                          //FeldNR: 08 - max. Feldlänge: 13 - Apha/Numerisch: A (string)
        public string V5_AnschriftDesDatenerstellers1 { get; set; }            //FeldNR: 09 - max. Feldlänge: 30 - Apha/Numerisch: A (string)
        public string V5_AnschriftDesDatenerstellers2 { get; set; }            //FeldNR: 10 - max. Feldlänge: 30 - Apha/Numerisch: A (string)
        public string V5_AnschriftDesDatenerstellers3 { get; set; }            //FeldNR: 11 - max. Feldlänge: 30 - Apha/Numerisch: A (string)
        public string V5_AnschriftDesDatenerstellersStraße { get; set; }       //FeldNR: 12 - max. Feldlänge: 30 - Apha/Numerisch: A (string)
        public string V5_AnschriftDesDatenerstellersLand { get; set; }         //FeldNR: 13 - max. Feldlänge: 03 - Apha/Numerisch: A (string)
        public string V5_AnschriftDesDatenerstellersPlz { get; set; }          //FeldNR: 14 - max. Feldlänge: 09 - Apha/Numerisch: A (string)
        string V5_AnschriftDesDatenerstellersOrt { get; set; }          //FeldNR: 15 - max. Feldlänge: 30 - Apha/Numerisch: A (string)

       
 

        //Liest die Headerdaten Norm entsprechend der Datanormversion 5 aus der datei und Schreibt Sie in die properties
        public void readHeaderV5(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);

            List<string> headeritems = new List<string>();
            string header = sr.ReadLine(); //Read Header in String

            string[] result = header.Split(';');

            foreach (var item in result)
            {
                headeritems.Add(item);
            }

            V5_Satzartenkennzeichen = headeritems[0];
            V5_Versionskennung = headeritems[1];
            V5_Datenkennzeichen = headeritems[2];
            V5_DatumDerErstellung = headeritems[3];
            V5_Waehrungskennzeichen = headeritems[4];
            V5_Dateninhaltsbeschreibung = headeritems[5];
            V5_CopyrightMitteilung = headeritems[6];
            V5_Datenersteller = headeritems[7];
        }
    }
}
