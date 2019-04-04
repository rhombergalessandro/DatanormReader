using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatanormReader
{
    class DatanormHeaderData
    {
   
        //Checkt ob es sich um eine Datanorm 4 oder 5 handelt! Bei einer Datanorm 5 ist der Header mit ; getrennt! Bei einer Datanorm 4 habe Sie fixe längen.
        public int readDatanormVersion(string filePath)
        {
            char charToSearch = ';';
            int charCount = 0;
            int version = 0;

            StreamReader sr = new StreamReader(filePath);
            string header = sr.ReadLine(); //Read Header in String
 
            string[] resCheckV5 = header.Split(';');

            foreach (char item in header)
            {
                if (item == charToSearch )
                {
                    charCount++;
                }
            }
            //Handelt sich um eine Datanorm 5 wenr mehr oder gleich 15 ; enthalten sind. Und im 2 Feld "050" steht (050 beudetet Version 5)
            if (charCount >= 15 && resCheckV5[1] == "050")
            {
                version = 5;                
            }

            else
            {
                try
                {
                    string resCheckV4 = header.Substring(123, 2);

                    if (resCheckV4 == "04")
                    {
                        version = 4;
                    }
                }
                catch
                {
                    //ist überflüssig weil wenn die Version 0 zurückgegeben wird dann, wird dies schon in der Form1 abgefangen
                    //LogHandler.Log("Fehler! Datanormversion konnte nicht ermittelt werden! Struckturfehler im Header der Datei.");
                    version = 0;
                }
            }

            return version;        
        }

        public void checkItemLength(string item, int maxLenght)
        {
            if (item.Length > maxLenght)
            {
                LogHandler.Log("Warnung! Item Länge entspricht nicht der Norm! Maximal zugelassene Länge wurde überschritten! " + "Max. lenght: " + maxLenght + " ,Item lenght: " + item.Length + " ,Item Inhalt: " + item);
            }
        }
    }
}
