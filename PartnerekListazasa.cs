using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Szakdolgozat___PRP
{
    public partial class PartnerekListazasa : Form
    {
        public PartnerekListazasa()
        {
            InitializeComponent();
            
        }
        public void ListabaOlvasas()
        {
            ServerData.KiolvasottAdatokPartner.Clear();
            string Lekeredezes = "SELECT * FROM Partner";
            using (SqlConnection Csatlakozas = new SqlConnection(ServerData.SzerverInfo))
            {
                using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                {
                    Csatlakozas.Open();
                    SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                    Parancs.Dispose();
                    while (LekerdezesParancs.Read())
                    {
                        ServerData.KiolvasottAdatokPartner.Add(new Partner(Convert.ToInt32(LekerdezesParancs["Id"]), Convert.ToString(LekerdezesParancs["Cegnev"]), Convert.ToString(LekerdezesParancs["Telephely"]), Convert.ToString(LekerdezesParancs["Kontakt1Nev"]), Convert.ToString(LekerdezesParancs["Kontakt1Titulus"]), Convert.ToString(LekerdezesParancs["Kontakt1Telefon"]), Convert.ToString(LekerdezesParancs["Kontakt1Email"]), Convert.ToString(LekerdezesParancs["Kontakt2Nev"]), Convert.ToString(LekerdezesParancs["Kontakt2Titulus"]), Convert.ToString(LekerdezesParancs["Kontakt2Telefon"]), Convert.ToString(LekerdezesParancs["Kontakt2Email"]), Convert.ToString(LekerdezesParancs["Tipus"])));
                    }
                    Csatlakozas.Close();
                }
            }
        }

        private void ListazPartnerGomb_Click(object sender, EventArgs e)
        {
            Partnereink.Items.Clear();
            if (CsakMegrendeloCheckBox.Checked)
            {
                int Sorszam = 0;
                Partnereink.Items.Add("Sorszám\tCégnév");
                for (int i = 0; i < ServerData.KiolvasottAdatokPartner.Count; i++)
                {
                    if (ServerData.KiolvasottAdatokPartner[i].Tipus == "Megrendelo")
                    {
                        Sorszam++;
                        Partnereink.Items.Add(Sorszam.ToString() + ".\t" + ServerData.KiolvasottAdatokPartner[i].Cegnev);
                    }
                }
            }
            else if (CsakBeszallitoCheckBox.Checked)
            {
                int Sorszam = 0;
                Partnereink.Items.Add("Sorszám\tCégnév");

                for (int i = 0; i < ServerData.KiolvasottAdatokPartner.Count; i++)
                {
                    if (ServerData.KiolvasottAdatokPartner[i].Tipus == "Beszállító")
                    {
                        Sorszam++;
                        Partnereink.Items.Add(Sorszam.ToString() + ".\t" + ServerData.KiolvasottAdatokPartner[i].Cegnev);
                    }
                }
            }
            else
            {
                Partnereink.Items.Add("Sorszám\tCégnév");
                int Sorszam = 0;
                for (int i = 0; i < ServerData.KiolvasottAdatokPartner.Count; i++)
                {
                    Sorszam++;
                    Partnereink.Items.Add(Sorszam.ToString() + ".\t" + ServerData.KiolvasottAdatokPartner[i].Cegnev);
                }
            }
            CsakBeszallitoCheckBox.Checked = false;
            CsakMegrendeloCheckBox.Checked = false;
        }
        

        private void PartnerKivalaszto(object sender, EventArgs e)
        {
            int KivalasztottCegIndex = 0;
            for (int i = 0; i < ServerData.KiolvasottAdatokPartner.Count; i++)
            {
                if (Partnereink.SelectedItem.ToString().Contains(ServerData.KiolvasottAdatokPartner[i].Cegnev))
                {
                    KivalasztottCegIndex = i;
                }
            }
            if (Partnereink.SelectedItem.ToString() != null)
            {
                    MessageBox.Show("Cégnév: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Cegnev + "\n" + "Típus: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Tipus + "\n" + "Telephely: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Telephely + "\n" + "Kontakt1: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt1Nev + "\n" + "Kontakt1 beosztása: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt1Titulus + "\n" + "Kontakt1 telefonszáma: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt1Telefon + "\n" + "Kontakt1 email " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt1Email + "\n" + "Kontakt2: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt2Nev + "\n" +  "Kontakt2 titulus: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt2Titulus + "\n" + "Kontakt2 telefonszáma: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt2Telefon + "\n" + "Kontakt2 email: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt2Email);

                    if (MessageBox.Show("Szeretnéd kimenteni az adatokat?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ExportCSVbe();
                        MessageBox.Show("Az adatok kimentésre kerültek. A fájl neve: kivalasztottpartner.csv");
                    }
             }   
                else
                {
                    MessageBox.Show("Nincs kijelölt elem.");
                }
            
        }
        private void ExportCSVbe()
        {
            StreamWriter Iro = new StreamWriter("kivalasztottpartner.csv", false, Encoding.Default);
            int KivalasztottCegIndex = 0;
            for (int i = 0; i < ServerData.KiolvasottAdatokPartner.Count; i++)
            {
                if (Partnereink.SelectedItem.ToString().Contains(ServerData.KiolvasottAdatokPartner[i].Cegnev))
                {
                    KivalasztottCegIndex = i;
                }
            }
            Iro.WriteLine("Cégnév: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Cegnev + "\n" + "Típus: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Tipus + "\n" + "Telephely: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Telephely + "\n" + "Kontakt1: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt1Nev + "\n" + "Kontakt1 beosztása: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt1Titulus + "\n" + "Kontakt1 telefonszáma: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt1Telefon + "\n" + "Kontakt1 email " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt1Email + "\n" + "Kontakt2: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt2Nev + "\n" + "Kontakt2 titulus: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt2Titulus + "\n" + "Kontakt2 telefonszáma: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt2Telefon + "\n" + "Kontakt2 email: " + ServerData.KiolvasottAdatokPartner[KivalasztottCegIndex].Kontakt2Email);
            Iro.Close();
        }

        private void OsszesElemExportja_Click(object sender, EventArgs e)
        {

                StreamWriter Iro = new StreamWriter("Partneradatok.csv", false, Encoding.Default);
            Iro.WriteLine("Cégnév;Típus;Telephely;Kapcsolattartó1 neve;Titulusa;Telefonszáma;Email címe;Kapcsolattartó2 neve;Titulusa;Telefonszáma;Email címe");
                for (int i = 0; i < ServerData.KiolvasottAdatokPartner.Count; i++)
                {
                Iro.WriteLine(ServerData.KiolvasottAdatokPartner[i].Cegnev + ";" + ServerData.KiolvasottAdatokPartner[i].Tipus + ";" + ServerData.KiolvasottAdatokPartner[i].Telephely + ";" + ServerData.KiolvasottAdatokPartner[i].Kontakt1Nev + ";" + ServerData.KiolvasottAdatokPartner[i].Kontakt1Titulus + ";" + ServerData.KiolvasottAdatokPartner[i].Kontakt1Telefon + ";" + ServerData.KiolvasottAdatokPartner[i].Kontakt1Email + ";" + ServerData.KiolvasottAdatokPartner[i].Kontakt2Nev + ";" + ServerData.KiolvasottAdatokPartner[i].Kontakt2Titulus + ";" +  ServerData.KiolvasottAdatokPartner[i].Kontakt2Telefon + ";" + ServerData.KiolvasottAdatokPartner[i].Kontakt2Email);
                }
                Iro.Close();
                MessageBox.Show("Az adatok kimentésre kerültek. A fájl neve: Partneradatok.csv");
        }
    }
}

