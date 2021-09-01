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

namespace Szakdolgozat___PRP
{
    public partial class Projektfelvétel : Form
    {
        public Projektfelvétel()
        {
            InitializeComponent();
            HataridoDateTimePicker.Format = DateTimePickerFormat.Custom;
            ProjektListaFeltoltes();
            ComboBoxFeltolto();
        }
        public void ComboBoxFeltolto()
        {
            PartnerekListazasa Fuggveny = new PartnerekListazasa();
            Fuggveny.ListabaOlvasas();
            for (int i = 0; i < ServerData.KiolvasottAdatokPartner.Count; i++)
            {
                if (ServerData.KiolvasottAdatokPartner[i].Tipus == "Megrendelo")
                {
                    PartnerNevComboBox.Items.Add(ServerData.KiolvasottAdatokPartner[i].Cegnev);
                }
            }
            for (int i = 0; i < ServerData.Receptura.Count; i++)
            {
                GyartandoTermekComboBox.Items.Add(ServerData.Receptura[i].TermekNev);
            }
            
            StatuszComboBox.Items.Add("ajánlatkészítés");
            StatuszComboBox.Items.Add("megrendelés alatt");
            StatuszComboBox.Items.Add("gyártáselőkészítés, beszerzés");
            StatuszComboBox.Items.Add("gyártási fázis1");
            StatuszComboBox.Items.Add("gyártási fázis2");
            StatuszComboBox.Items.Add("tesztelés");
            StatuszComboBox.Items.Add("csomagolás");
            StatuszComboBox.Items.Add("kiadva");

            for (int i = 0; i < ServerData.ProjektAdatok.Count; i++)
            {
                ProjektIdComboBox.Items.Add(ServerData.ProjektAdatok[i].Id);
            }

        }
        public void ProjektListaFeltoltes()
        {
            ServerData.ProjektAdatok.Clear();
            string Lekeredezes = "SELECT * FROM Projekt";
            using (SqlConnection Csatlakozas = new SqlConnection(ServerData.SzerverInfo))
            {
                using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                {
                    Csatlakozas.Open();
                    SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                    Parancs.Dispose();
                    while (LekerdezesParancs.Read())
                    {
                        ServerData.ProjektAdatok.Add(new Projekt(Convert.ToInt32(LekerdezesParancs["Id"]),Convert.ToString(LekerdezesParancs["Projektnev"]), Convert.ToString(LekerdezesParancs["Partner"]), Convert.ToString(LekerdezesParancs["Termek"]), Convert.ToInt32(LekerdezesParancs["Mennyiseg"]), Convert.ToString(LekerdezesParancs["Felelos"]), Convert.ToString(LekerdezesParancs["Hatarido"]), Convert.ToString(LekerdezesParancs["Statusz"]), Convert.ToString(LekerdezesParancs["Email"]), Convert.ToString(LekerdezesParancs["Szerzodes"]), Convert.ToString(LekerdezesParancs["Egyeb1"]), Convert.ToString(LekerdezesParancs["Egyeb2"])));
                    }
                    Csatlakozas.Close();
                }
            }
        }
        private void ProjektKeresoTextChangeEvent(object sender, EventArgs e)
        {
            for (int i = 0; i < ServerData.ProjektAdatok.Count; i++)
            {
                if (ProjektIdComboBox.Text == Convert.ToString(ServerData.ProjektAdatok[i].Id))
                {
                    PartnerNevComboBox.Text = ServerData.ProjektAdatok[i].Partner;
                    GyartandoTermekComboBox.Text = ServerData.ProjektAdatok[i].Termek;
                    GyartandoMennyisegInfo.Text = Convert.ToString(ServerData.ProjektAdatok[i].Mennyiseg);
                    FelelosInfo.Text = ServerData.ProjektAdatok[i].Felelos;
                    HataridoDateTimePicker.Text = ServerData.ProjektAdatok[i].Hatarido;
                    StatuszComboBox.Text = ServerData.ProjektAdatok[i].Statusz;
                    EmailInfo.Text = ServerData.ProjektAdatok[i].Email;
                    SzerzodesInfo.Text = ServerData.ProjektAdatok[i].Szerzodes;
                    Egyeb1Info.Text = ServerData.ProjektAdatok[i].Egyeb1;
                    Egyeb2Info.Text = ServerData.ProjektAdatok[i].Egyeb2;
                    ProjektNevInfo.Text = ServerData.ProjektAdatok[i].Projektnev;
                }
                if (ProjektIdComboBox.Text=="")
                {
                    ProjektNevInfo.Text = "";
                    PartnerNevComboBox.Text = "";
                    GyartandoTermekComboBox.Text = "";
                    GyartandoMennyisegInfo.Text = "";
                    FelelosInfo.Text = "";
                    HataridoDateTimePicker.Text = "";
                    StatuszComboBox.Text = "";
                    EmailInfo.Text = "";
                    SzerzodesInfo.Text = "";
                    Egyeb1Info.Text = "";
                    Egyeb2Info.Text = "";
                }
            }
        }

        private void ProjektListazas_Click(object sender, EventArgs e)
        {
            ProjektListazas Megmutat = new ProjektListazas();
            Megmutat.Show();
            Megmutat.BringToFront();
        }

        private void Mentes_Click(object sender, EventArgs e)
        {
            if (Mennyisegvizsgalo() == true)
            {
                if (ProjektIdComboBox.Text == "")
                {
                    try
                    {
                        using (SqlConnection Csatlakozas = new SqlConnection(ServerData.SzerverInfo))
                        {
                            string Feltoltes = "INSERT INTO Projekt VALUES (@Projektnev, @Partner,@Termek,@Mennyiseg,@Felelos,@Hatarido,@Statusz,@Email,@Szerzodes, @Egyeb1,@Egyeb2)";
                            using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                            {
                                Parancs.Parameters.AddWithValue("@Projektnev", ProjektNevInfo.Text);
                                Parancs.Parameters.AddWithValue("@Partner", PartnerNevComboBox.Text);
                                Parancs.Parameters.AddWithValue("@Termek", GyartandoTermekComboBox.Text);
                                Parancs.Parameters.AddWithValue("@Mennyiseg", GyartandoMennyisegInfo.Text);
                                Parancs.Parameters.AddWithValue("@Felelos", FelelosInfo.Text);
                                Parancs.Parameters.AddWithValue("@Hatarido", HataridoDateTimePicker.Text);
                                Parancs.Parameters.AddWithValue("@Statusz", StatuszComboBox.Text);
                                Parancs.Parameters.AddWithValue("@Email", EmailInfo.Text);
                                Parancs.Parameters.AddWithValue("@Szerzodes", SzerzodesInfo.Text);
                                Parancs.Parameters.AddWithValue("@Egyeb1", Egyeb1Info.Text);
                                Parancs.Parameters.AddWithValue("@Egyeb2", Egyeb2Info.Text);

                                Csatlakozas.Open(); 
                                var result = Parancs.ExecuteNonQuery();
                                Parancs.Dispose();
                                if (result < 0)
                                { MessageBox.Show("Hiba az adatfeltöltés során!"); } 
                                MessageBox.Show("A feltöltés megtörtént!"); 
                                Csatlakozas.Close();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nem sikerült a csatlakozás");
                    }
                    ProjektListaFeltoltes();
                    ProjektNevInfo.Text = "";
                    PartnerNevComboBox.Text = "";
                    GyartandoTermekComboBox.Text = "";
                    GyartandoMennyisegInfo.Text = "";
                    FelelosInfo.Text = "";
                    HataridoDateTimePicker.Text = "";
                    StatuszComboBox.Text = "";
                    EmailInfo.Text = "";
                    SzerzodesInfo.Text = "";
                    Egyeb1Info.Text = "";
                    Egyeb2Info.Text = "";
                }
                else
                {
                    ProjektFrissites();
                }
                Raktar AAK = new Raktar();
                AAK.AlapanyagKivetelezes();
            }
            else
            {
                ProjektNevInfo.Text = "";
                PartnerNevComboBox.Text = "";
                GyartandoTermekComboBox.Text = "";
                GyartandoMennyisegInfo.Text = "";
                FelelosInfo.Text = "";
                HataridoDateTimePicker.Text = "";
                StatuszComboBox.Text = "";
                EmailInfo.Text = "";
                SzerzodesInfo.Text = "";
                Egyeb1Info.Text = "";
                Egyeb2Info.Text = "";
            }
        }
        public void ProjektFrissites()
        {
            try
            {
                using (SqlConnection Connect = new SqlConnection(ServerData.SzerverInfo))
                {
                    string Feluliras = "UPDATE Projekt SET Mennyiseg='"+GyartandoMennyisegInfo.Text+"' ,Felelos='"+FelelosInfo.Text+"' ,Hatarido='"+HataridoDateTimePicker.Text+"' ,Statusz='"+StatuszComboBox.Text+"' ,Email='"+EmailInfo.Text+"' ,Szerzodes='"+SzerzodesInfo.Text+"' ,Egyeb1='"+Egyeb1Info.Text+"' ,Egyeb2='"+Egyeb2Info.Text+"' WHERE Id="+ ProjektIdComboBox.Text+"";
                    SqlCommand Parancsvegrehajtas = new SqlCommand(Feluliras, Connect);
                    Connect.Open();
                    var Result =Parancsvegrehajtas.ExecuteNonQuery();
                    Parancsvegrehajtas.Dispose();
                    if (Result < 0)
                    {
                        MessageBox.Show("Hiba az adat feltöltése során!", "Hiba", MessageBoxButtons.OK);
                    }
                    MessageBox.Show("Az adat feltöltése sikerült! Az adatbázis az ablak bezárása után frissül.", "Siker!", MessageBoxButtons.OK);
                        Connect.Close();
                }
            }
           catch (Exception)
            {
                MessageBox.Show("Hiba a projektadatok frissítésekor.");
            }
        }
        public bool Mennyisegvizsgalo() 
        {
            ServerData.Szukseg.Clear();
            int keresetttermekindex = 0;
            for (int i = 0; i < ServerData.Receptura.Count; i++)
            {
                if(GyartandoTermekComboBox.Text==ServerData.Receptura[i].TermekNev)
                {
                    keresetttermekindex = i;
                }
            }
            for (int i = 0; i < ServerData.Receptura[keresetttermekindex].Hozzavalok.Count; i++)
            {
                ServerData.Szukseg.Add(new Szukseges(ServerData.Receptura[keresetttermekindex].Hozzavalok[i].HozzavaloNev, (ServerData.Receptura[keresetttermekindex].Hozzavalok[i].HozzavaloMennyiseg * GyartandoMennyiseg)));
            }
            for (int j = 0; j < ServerData.Szukseg.Count; j++)
            {
                for (int i = 0; i < ServerData.AANyilvantartas.Count; i++)
                {
                    if (ServerData.AANyilvantartas[i].Nev == ServerData.Szukseg[j].Nev) 
                    {
                        ServerData.Szukseg[j].FelhasznalhatoDb += ServerData.AANyilvantartas[i].BeerkezettMennyiseg;
                        ServerData.Szukseg[j].FelhasznalhatoDb += ServerData.AANyilvantartas[i].MegrendeltMennyiseg;
                    }
                }
                if (ServerData.Szukseg[j].Db>ServerData.Szukseg[j].FelhasznalhatoDb)
                {
                    if (MessageBox.Show("A megrendelt termékmennyiseg legyártásához " + (ServerData.Szukseg[j].FelhasznalhatoDb-ServerData.Szukseg[j].Db)*-1 + "db " + ServerData.Szukseg[j].Nev + " hiányzik. BESZERZÉS JAVASOLT!", "Figyelem!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static int GyartandoMennyiseg;
        private void Mennyiségváltoztató(object sender, EventArgs e)
        {
            if (GyartandoMennyisegInfo.Text != "")
            { GyartandoMennyiseg = Convert.ToInt32(GyartandoMennyisegInfo.Text); }
        }
    }
}

                                

