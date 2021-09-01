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
    public partial class Raktar : Form
    {
        public Raktar()
        {
            InitializeComponent();
            AlapanyagListaFeltoltes();
            RaktarListBoxFeltoltes();
        }
        public void MentesRaktarGomb_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(ServerData.SzerverInfo))
                {
                    string Feltoltes = "INSERT INTO Raktar VALUES (@Nev,@Beerkezettmennyiseg,@Megrendeltmennyiseg,@Varhatobeerkezes)"; //Adatok feltöltése
                    using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                    {
                        Parancs.Parameters.AddWithValue("@Nev", AANevInfo.Text);
                        Parancs.Parameters.AddWithValue("@Beerkezettmennyiseg", BeerkezettDbInfo.Text);
                        Parancs.Parameters.AddWithValue("@Megrendeltmennyiseg", MegrendeltDbInfo.Text);
                        Parancs.Parameters.AddWithValue("@Varhatobeerkezes", VarhatoHIdateTimePicker1.Text);
                        Csatlakozas.Open();
                        var result = Parancs.ExecuteNonQuery();
                        Parancs.Dispose();
                        if (result < 0)
                        { MessageBox.Show("Hiba az adatfeltöltés során!"); }
                        MessageBox.Show("A feltöltés megtörtént!");
                        Csatlakozas.Close();
                        AlapanyagListaFeltoltes();
                        RaktarListBoxFeltoltes();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nem sikerült a csatlakozás");
            }
            AANevInfo.Text = "";
            BeerkezettDbInfo.Text = "";
            MegrendeltDbInfo.Text = "";
            VarhatoHIdateTimePicker1.Text = "";
        }
        public void AlapanyagListaFeltoltes()
        {
            ServerData.AANyilvantartas.Clear();
            string Lekeredezes = "SELECT * FROM Raktar";
            using (SqlConnection Csatlakozas = new SqlConnection(ServerData.SzerverInfo))
            {
                using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                {
                    Csatlakozas.Open();
                    SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                    Parancs.Dispose();
                    while (LekerdezesParancs.Read())
                    {
                        ServerData.AANyilvantartas.Add(new Alapanyag(Convert.ToInt32(LekerdezesParancs["Id"]), Convert.ToString(LekerdezesParancs["Nev"]), Convert.ToInt32(LekerdezesParancs["Beerkezettmennyiseg"]), Convert.ToInt32(LekerdezesParancs["Megrendeltmennyiseg"]), Convert.ToString(LekerdezesParancs["Varhatobeerkezes"])));
                    }
                    Csatlakozas.Close();
                }
            }
            RaktarListBoxFeltoltes();
        }
        public void FrissitRaktarGomb_Click(object sender, EventArgs e)
        {
            AlapanyagFrissites();
            RaktarListBoxFeltoltes();
        }
        public void AlapanyagFrissites()
        {
            int SIId = 0;
            for (int i = 0; i < ServerData.AANyilvantartas.Count; i++)
            {
                if (AANevInfo.Text==ServerData.AANyilvantartas[i].Nev)
                {
                    SIId = ServerData.AANyilvantartas[i].Id;
                }
            }
            try
            {
                using (SqlConnection Connect = new SqlConnection(ServerData.SzerverInfo))
                {
                    string Feluliras = "UPDATE Raktar SET Nev='" + AANevInfo.Text + "' ,Beerkezettmennyiseg='" + BeerkezettDbInfo.Text + "' ,Megrendeltmennyiseg='" + MegrendeltDbInfo.Text + "' ,Varhatobeerkezes='" + VarhatoHIdateTimePicker1.Text + "' WHERE Id=" + SIId + "";
                    SqlCommand Parancsvegrehajtas = new SqlCommand(Feluliras, Connect);
                    Connect.Open();
                    var Result = Parancsvegrehajtas.ExecuteNonQuery();
                    Parancsvegrehajtas.Dispose();
                    if (Result < 0)
                    {
                        MessageBox.Show("Hiba az adat feltöltése során!", "Hiba", MessageBoxButtons.OK);
                    }
                    Connect.Close();
                    AlapanyagListaFeltoltes();
                }
            }
            catch
            {
                MessageBox.Show("Hiba a raktáradatok frissítése során.");
            }
        }
        public void AlapanyagKivetelezes()
        {
            int BM = 0;
            int KeresettId = 0;
            int MM = 0;
            for (int i = 0; i < ServerData.Szukseg.Count; i++)
            {
                for (int j = 0; j <ServerData.AANyilvantartas.Count; j++)
                {
                    if (ServerData.Szukseg[i].Nev == ServerData.AANyilvantartas[j].Nev)
                    {
                        KeresettId = ServerData.AANyilvantartas[j].Id;
                        if (ServerData.Szukseg[i].Db>ServerData.AANyilvantartas[j].BeerkezettMennyiseg)
                        {
                            MM = ServerData.AANyilvantartas[j].MegrendeltMennyiseg - (ServerData.Szukseg[i].Db - ServerData.AANyilvantartas[j].BeerkezettMennyiseg);
                            BM = 0;
                        }
                        else
                        {
                            BM = ServerData.AANyilvantartas[j].BeerkezettMennyiseg - ServerData.Szukseg[i].Db;
                            MM = ServerData.AANyilvantartas[j].MegrendeltMennyiseg;
                        }
                        try
                        {
                            using (SqlConnection Connect = new SqlConnection(ServerData.SzerverInfo))
                            {
                                string Feluliras = "UPDATE Raktar SET Beerkezettmennyiseg='" + BM + "' ,Megrendeltmennyiseg='" + MM +"' WHERE Id=" + KeresettId + "";
                                SqlCommand Parancsvegrehajtas = new SqlCommand(Feluliras, Connect);
                                Connect.Open();
                                var Result = Parancsvegrehajtas.ExecuteNonQuery();
                                Parancsvegrehajtas.Dispose();
                                Connect.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Hiba az alapanyagkivételezése során.");
                        }
                    }
                }
            }
            RaktarListBoxFeltoltes();
        }
        public void RaktarListBoxFeltoltes()
        {
            RaktárLB.Items.Clear();
            RaktárLB.Items.Add("Ssz.\tNév\tPolcon(db)\tMegrendelt(db)\tVárható beérkezés");
            for (int i = 0; i < ServerData.AANyilvantartas.Count; i++)
            {
                RaktárLB.Items.Add((i + 1) + "\t" + ServerData.AANyilvantartas[i].Nev + "\t" + ServerData.AANyilvantartas[i].BeerkezettMennyiseg + "\t\t" + ServerData.AANyilvantartas[i].MegrendeltMennyiseg + "\t\t" + ServerData.AANyilvantartas[i].VarhatoBeerkezes);
            }
        }
        public void ListaelemKivalasztas(object sender, EventArgs e)
        {
            if (RaktárLB.SelectedItems.ToString() != "")
            {
                string[] Egysegek = RaktárLB.SelectedItem.ToString().Split('\t');
                string nev = Egysegek[1];
                string beerkm = Egysegek[2];
                string megrendm = Egysegek[4];
                string varhatobeerk = Egysegek[6];
                AANevInfo.Text = nev;
                BeerkezettDbInfo.Text = beerkm;
                MegrendeltDbInfo.Text = megrendm;
                VarhatoHIdateTimePicker1.Text = varhatobeerk;
            }
            else { MessageBox.Show("Hiba!A frissítéshez jelölje ki a sort, amelyet frissíteni szeretne."); }
        }
        public void RecepturaListaFeltoltes()
        {
            ServerData.Receptura.Clear();
            StreamReader Olvas = new StreamReader("Receptura.txt", Encoding.Default);
            string Fejlec = Olvas.ReadLine();
            while (!Olvas.EndOfStream)
            {
                ServerData.Receptura.Add(new Termek(Olvas.ReadLine()));
            }
            Olvas.Close();
        }
    }
}
