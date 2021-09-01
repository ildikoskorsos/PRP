using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Szakdolgozat___PRP
{
    public partial class ProjektListazas : Form
    {
        public ProjektListazas()
        {
            InitializeComponent();
            ProjektListBoxFeltoltes();
        }
        private void ProjektListBoxFeltoltes()
        {
            ProjektekLB.Items.Clear();
            for (int i = 0; i < ServerData.ProjektAdatok.Count; i++)
            {
               if (PartnerSzuro.Text == "" && TermekSzuro.Text == "" && FelelosSzuro.Text == "")
               {
                  ProjektekLB.Items.Add(ServerData.ProjektAdatok[i].Id + "\t" + ServerData.ProjektAdatok[i].Projektnev + "\t" + ServerData.ProjektAdatok[i].Partner + "\t" + ServerData.ProjektAdatok[i].Termek + "\t" + ServerData.ProjektAdatok[i].Mennyiseg + "\t" + ServerData.ProjektAdatok[i].Felelos + "\t" + ServerData.ProjektAdatok[i].Hatarido + "\t" + ServerData.ProjektAdatok[i].Statusz);
               }
               else if (PartnerSzuro.Text == ServerData.ProjektAdatok[i].Partner && TermekSzuro.Text == "" && FelelosSzuro.Text == "")
               {
                   ProjektekLB.Items.Add(ServerData.ProjektAdatok[i].Id + "\t" + ServerData.ProjektAdatok[i].Projektnev + "\t" + ServerData.ProjektAdatok[i].Termek + "\t" + ServerData.ProjektAdatok[i].Mennyiseg + "\t" + ServerData.ProjektAdatok[i].Felelos + "\t" + ServerData.ProjektAdatok[i].Hatarido + "\t" + ServerData.ProjektAdatok[i].Statusz);
               }
               else if (PartnerSzuro.Text == ServerData.ProjektAdatok[i].Partner && TermekSzuro.Text == ServerData.ProjektAdatok[i].Termek && FelelosSzuro.Text == "")
               {
                        ProjektekLB.Items.Add(ServerData.ProjektAdatok[i].Id + "\t" + ServerData.ProjektAdatok[i].Projektnev + "\t" + ServerData.ProjektAdatok[i].Mennyiseg + "\t" + ServerData.ProjektAdatok[i].Felelos + "\t" + ServerData.ProjektAdatok[i].Hatarido + "\t" + ServerData.ProjektAdatok[i].Statusz);
               }
               else if (PartnerSzuro.Text == ServerData.ProjektAdatok[i].Partner && TermekSzuro.Text == ServerData.ProjektAdatok[i].Termek && FelelosSzuro.Text == ServerData.ProjektAdatok[i].Felelos)
               {
                        ProjektekLB.Items.Add(ServerData.ProjektAdatok[i].Id + "\t" + ServerData.ProjektAdatok[i].Projektnev + "\t" + ServerData.ProjektAdatok[i].Mennyiseg + "\t" + ServerData.ProjektAdatok[i].Hatarido + "\t" + ServerData.ProjektAdatok[i].Statusz);
               }
               else if (PartnerSzuro.Text == "" && TermekSzuro.Text == ServerData.ProjektAdatok[i].Termek && FelelosSzuro.Text == "")
               {
                        ProjektekLB.Items.Add(ServerData.ProjektAdatok[i].Id + "\t" + ServerData.ProjektAdatok[i].Projektnev + "\t" + ServerData.ProjektAdatok[i].Partner + "\t" + ServerData.ProjektAdatok[i].Mennyiseg + "\t" + ServerData.ProjektAdatok[i].Felelos + "\t" + ServerData.ProjektAdatok[i].Hatarido + "\t" + ServerData.ProjektAdatok[i].Statusz);
               }
               else if (PartnerSzuro.Text == "" && TermekSzuro.Text == ServerData.ProjektAdatok[i].Termek && FelelosSzuro.Text == ServerData.ProjektAdatok[i].Felelos)
               {
                        ProjektekLB.Items.Add(ServerData.ProjektAdatok[i].Id + "\t" + ServerData.ProjektAdatok[i].Projektnev + "\t" + ServerData.ProjektAdatok[i].Partner + "\t" + ServerData.ProjektAdatok[i].Mennyiseg + "\t" + ServerData.ProjektAdatok[i].Hatarido + "\t" + ServerData.ProjektAdatok[i].Statusz);
               }
               else if (PartnerSzuro.Text == "" && TermekSzuro.Text == "" && FelelosSzuro.Text == ServerData.ProjektAdatok[i].Felelos)
               {
                        ProjektekLB.Items.Add(ServerData.ProjektAdatok[i].Id + "\t" + ServerData.ProjektAdatok[i].Projektnev + "\t" + ServerData.ProjektAdatok[i].Partner + "\t" + ServerData.ProjektAdatok[i].Termek + "\t" + ServerData.ProjektAdatok[i].Mennyiseg + "\t" + ServerData.ProjektAdatok[i].Hatarido + "\t" + ServerData.ProjektAdatok[i].Statusz);
               }
               else if (PartnerSzuro.Text == ServerData.ProjektAdatok[i].Partner && TermekSzuro.Text == "" && FelelosSzuro.Text == ServerData.ProjektAdatok[i].Felelos)
               {
                        ProjektekLB.Items.Add(ServerData.ProjektAdatok[i].Id + "\t" + ServerData.ProjektAdatok[i].Projektnev + "\t" + ServerData.ProjektAdatok[i].Termek + "\t" + ServerData.ProjektAdatok[i].Mennyiseg + "\t" + ServerData.ProjektAdatok[i].Hatarido + "\t" + ServerData.ProjektAdatok[i].Statusz);
               }
            }
            PartnerSzuro.Text = "";
            TermekSzuro.Text = "";
            FelelosSzuro.Text = "";
        }
        private void ProjektListazasGomb_Click(object sender, EventArgs e)
        {
            ProjektListBoxFeltoltes();
        }

        private void ProjektKivalasztottExport_Click(object sender, EventArgs e)
        {
            if (ProjektekLB.SelectedItem != null) 
            {
                StreamWriter IroKIV = new StreamWriter("KivalasztottProjekt.csv", false, Encoding.Default);
                IroKIV.WriteLine(ProjektekLB.SelectedItem.ToString()); 
                IroKIV.Close(); 
                MessageBox.Show("A kiválasztott elem a \"KivalasztottProjekt.csv\" fájlban található.");
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!"); 
            }
        }
        StreamWriter Iro; 
        private void ProjektOsszesExport_Click(object sender, EventArgs e)
        {
            Iro = new StreamWriter("ProjektMentes.html", false, Encoding.Default);
            webTablaFejlec("Projekt neve", "Partner neve","Termék","Mennyiség","Felelős","Határidő","Státusz"); 
            for (int i = 0; i < ServerData.ProjektAdatok.Count; i++) 
            {
                webTablaSor(ServerData.ProjektAdatok[i].Projektnev, ServerData.ProjektAdatok[i].Partner, ServerData.ProjektAdatok[i].Termek, ServerData.ProjektAdatok[i].Mennyiseg.ToString(), ServerData.ProjektAdatok[i].Felelos, ServerData.ProjektAdatok[i].Hatarido, ServerData.ProjektAdatok[i].Statusz);
            }
            webTablaVege(); 
            Iro.Close(); 
            MessageBox.Show("A táblázatba mentés sikerült!"); 
        }
        private void webTablaFejlec(string fejlecSzoveg1, string fejlecSzoveg2, string fejlecSzoveg3, string fejlecSzoveg4, string fejlecSzoveg5, string fejlecSzoveg6, string fejlecSzoveg7) 
        {
                Iro.WriteLine("<html>"); 
                Iro.WriteLine("<head><title>Generált táblázat</title></head>"); 
                Iro.WriteLine("<body>"); 
                Iro.WriteLine($"<table border=\"1\"><tr><th>{fejlecSzoveg1}</th><th>{fejlecSzoveg2}</th><th>{fejlecSzoveg3}</th><th>{fejlecSzoveg4}</th><th>{fejlecSzoveg5}</th><th>{fejlecSzoveg6}</th><th>{fejlecSzoveg7}</th></tr>"); 
        }
        private void webTablaSor(string tablaAdat1, string tablaAdat2, string tablaAdat3, string tablaAdat4, string tablaAdat5, string tablaAdat6, string tablaAdat7) 
        {
                Iro.WriteLine($"<tr><td>{tablaAdat1}</td><td>{tablaAdat2}</td><td>{tablaAdat3}</td><td>{tablaAdat4}</td><td>{tablaAdat5}</td><td>{tablaAdat6}</td><td>{tablaAdat7}</td></tr>"); 
        }
        private void webTablaVege() 
        {
                Iro.WriteLine("</table>"); 
                Iro.WriteLine("</body>"); 
                Iro.WriteLine("</html>"); 
        }

        private void ProjektKivalasztottTorles_Click(object sender, EventArgs e)
        {
            if (ProjektekLB.SelectedItem != null)
            {
                if (MessageBox.Show("Figyelem! Az elem csak a megjelenítőből törlődött. Szeretné az ADATBÁZISBÓL is TÖRÖLNI? Ebben az esetben az adat véglegesen törlésre kerül.", "Figyelem", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string ListaElemID = ProjektekLB.SelectedItem.ToString().Split('\t')[0];
                        string Torles = "DELETE FROM Projekt WHERE Id="+ListaElemID+"";
                        SqlConnection CsatlakozasiFolyamat = new SqlConnection(ServerData.SzerverInfo); 
                        CsatlakozasiFolyamat.Open(); 
                        SqlCommand Parancsvegrehajtas = new SqlCommand(Torles, CsatlakozasiFolyamat);
                        Parancsvegrehajtas.ExecuteNonQuery();
                        Parancsvegrehajtas.Dispose();
                        MessageBox.Show("Az adatbázis elemének: (" + ProjektekLB.SelectedItem.ToString() + ") törlése megtörtént.");
                        CsatlakozasiFolyamat.Close();  
                    }
                    catch
                    {
                        MessageBox.Show("Hiba. Az elem törlése meghiúsult.");
                    }
                    ProjektekLB.Items.Remove(ProjektekLB.SelectedItem);
                }
                else 
                {
                    ProjektekLB.Items.Remove(ProjektekLB.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott elem.");
            }
        }
    }
}
