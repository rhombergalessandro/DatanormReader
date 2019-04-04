using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatanormReader
{
    public class DatanormV04
    {

        //Datanrom Versions 4 properties
        public string V4_Satzartenkennzeichen { get; set; }                    //FeldNR: 01 - Feld: 01 - Apha/Numerisch: A (string)

        //FeldNR: 02 - Feld: 02 - Leeres Feld
        public string V4_DatumDerErstellung { get; set; }                      //FeldNR: 03 - Feld: 03 - 08 - Apha/Numerisch: N (int)
        public string V4_InfoText1 { get; set; }                               //FeldNR: 04 - Feld: 09 - 48 - Apha/Numerisch: A (string)
        public string V4_InfoText2 { get; set; }                               //FeldNR: 05 - Feld: 49 - 88 - Apha/Numerisch: A (string)
        public string V4_InfoText3 { get; set; }                               //FeldNR: 06 - Feld: 89 - 123 - Apha/Numerisch: A (string)
        public string V4_Versionsnummer { get; set; }                          //FeldNR: 07 - Feld: 124 - 125 - Apha/Numerisch: N (int)
        public string V4_Waehrungskennzeichen { get; set; }                    //FeldNR: 08 - Feld: 126 - 128 - Apha/Numerisch: N (int)
 

        //Liest die Headerdaten Norm entsprechend der Datanormversion 4 aus der datei und Schreibt Sie in die properties
        public void readHeaderV4(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);

            List<string> headeritems = new List<string>();
            string header = sr.ReadLine(); //Read Header in String


            V4_Satzartenkennzeichen = header.Substring(0, 1);
            //FeldNR: 02 - Feld: 02 - Leeres Feld (1, 2);
            V4_DatumDerErstellung = header.Substring(2, 6);
            V4_InfoText1 = header.Substring(8, 40);
            V4_InfoText2 = header.Substring(48, 40);
            V4_InfoText3 = header.Substring(88, 35);
            V4_Versionsnummer = header.Substring(123, 2);
            V4_Waehrungskennzeichen = header.Substring(125, 3);
        }
        
    }
}
