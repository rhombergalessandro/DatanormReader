using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatanormReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       // public System.Windows.Forms.DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode { get; set; }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //{ Filter = "Datanorm .001 (*.001)|*.001", Title = "Datanorm Reader" };
            //ofd.Multiselect = true;
  
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                btnCheckDatanorm.Enabled = true;
                DatanormHeaderData dhd = new DatanormHeaderData();
                DatanormV05 dv5 = new DatanormV05();
                DatanormV04 dv4 = new DatanormV04();

                LogHandler.Log("--------------------------- " + ofd.FileName + " ---------------------------");

                //Mehode zum Lesen der Datanormversion: Gibt 4 oder 5 - Wenn nichts gefunden wird gibt die Methode 0 zurück!
                int dv = dhd.readDatanormVersion(ofd.FileName);

                if (dv == 5)
                {
                    List<DatanormV05> DatanormHeaderDataV5 = new List<DatanormV05>();

                    dv5.readHeaderV5(ofd.FileName);

                    DatanormHeaderDataV5.Add(new DatanormV05
                    {
                        //Schreibt die Propeties in die Liste und diese wird dann in der Form angezeigt
                        V5_Satzartenkennzeichen = dv5.V5_Satzartenkennzeichen,                       
                        V5_Versionskennung = dv5.V5_Versionskennung,
                        V5_Datenkennzeichen = dv5.V5_Datenkennzeichen,
                        V5_DatumDerErstellung = dv5.V5_DatumDerErstellung,
                        V5_Waehrungskennzeichen = dv5.V5_Waehrungskennzeichen,
                        V5_Dateninhaltsbeschreibung = dv5.V5_Dateninhaltsbeschreibung,
                        V5_CopyrightMitteilung = dv5.V5_CopyrightMitteilung,
                        V5_Datenersteller = dv5.V5_Datenersteller
                    });

                        //Die Datanorm Header sind in der Länge begrenzt! Hier wird die Maximale Länge von jedem Item abgefragt!
                        dhd.checkItemLength(dv5.V5_Satzartenkennzeichen, 1);
                        dhd.checkItemLength(dv5.V5_Versionskennung, 3);
                        dhd.checkItemLength(dv5.V5_Datenkennzeichen, 1);
                        dhd.checkItemLength(dv5.V5_DatumDerErstellung, 8);
                        dhd.checkItemLength(dv5.V5_Waehrungskennzeichen, 3);
                        dhd.checkItemLength(dv5.V5_Dateninhaltsbeschreibung, 40);
                        dhd.checkItemLength(dv5.V5_CopyrightMitteilung, 40);
                        dhd.checkItemLength(dv5.V5_Datenersteller, 13);

                        dataGridView1.DataSource = DatanormHeaderDataV5;
                        
                        //Autolänge der Spalten in der DataGridView1
                        dataGridView1.AutoResizeColumns();
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else if (dv == 4)
                {
                    List<DatanormV04> DatanormHeaderDataV4 = new List<DatanormV04>();

                    dv4.readHeaderV4(ofd.FileName);

                    DatanormHeaderDataV4.Add(new DatanormV04
                    {
                        //Schreibt die Propeties in die Liste und diese wird dann in der Form angezeigt
                        V4_Satzartenkennzeichen = dv4.V4_Satzartenkennzeichen,
                        V4_DatumDerErstellung = dv4.V4_DatumDerErstellung,
                        V4_InfoText1 = dv4.V4_InfoText1,
                        V4_InfoText2 = dv4.V4_InfoText2,
                        V4_InfoText3 = dv4.V4_InfoText3,
                        V4_Versionsnummer = dv4.V4_Versionsnummer,
                        V4_Waehrungskennzeichen = dv4.V4_Waehrungskennzeichen
                    });

                    dataGridView1.DataSource = DatanormHeaderDataV4;

                    //Autolänge der Spalten in der DataGridView1
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;              
                }
                else
                {
                    MessageBox.Show("Datanormversion konnte nicht ermittelt werden! Strukturfehler im Header der Datei.", "Datanormversion - Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LogHandler.Log("Fehler! Datanormversion konnte nicht ermittelt werden! Struckturfehler im Header der Datei.");
                    btnCheckDatanorm.Enabled = false;
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm Form2 = new SettingsForm();
            Form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCheckDatanorm.Enabled = false;
        }
    }
}