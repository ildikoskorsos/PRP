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
    public partial class UjPartnerRogzitese : Form
    {
        public UjPartnerRogzitese()
        {
            InitializeComponent();
        }

        private void FelvitelGomb_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(ServerData.SzerverInfo))
                {
                    string Feltoltes = "INSERT INTO Partner VALUES (@Cegnev, @Telephely, @Kontakt1Nev, @Kontakt1Titulus, @Kontakt1Telefon, @Kontakt1Email, @Kontakt2Nev, @Kontakt2Titulus, @Kontakt2Telefon, @Kontakt2Email, @Tipus)"; 
                    using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                    {
                        Parancs.Parameters.AddWithValue("@Cegnev", CegnevInfo.Text); 
                        Parancs.Parameters.AddWithValue("@Telephely", TelephelyInfo.Text); 
                        Parancs.Parameters.AddWithValue("@Kontakt1Nev", Kontakt1NevInfo.Text); 
                        Parancs.Parameters.AddWithValue("@Kontakt1Titulus", Kontakt1TitulusInfo.Text); 
                        Parancs.Parameters.AddWithValue("@Kontakt1Telefon", Kontakt1TelefonInfo.Text); 
                        Parancs.Parameters.AddWithValue("@Kontakt1Email", Kontakt1EmailInfo.Text);
                        Parancs.Parameters.AddWithValue("@Kontakt2Nev", Kontakt2NevInfo.Text);
                        Parancs.Parameters.AddWithValue("@Kontakt2Titulus", Kontakt2TitulusInfo.Text);
                        Parancs.Parameters.AddWithValue("@Kontakt2Telefon", Kontakt2TelefonInfo.Text);
                        Parancs.Parameters.AddWithValue("@Kontakt2Email", Kontakt2EmailInfo.Text);
                        if (TipusBeszallitoRadioGomb.Checked) { Parancs.Parameters.AddWithValue("@Tipus", "Beszállító"); }
                        else { Parancs.Parameters.AddWithValue("@Tipus", "Megrendelő"); }
                        Csatlakozas.Open(); 
                        var result = Parancs.ExecuteNonQuery();
                        Parancs.Dispose();
                        if (result < 0)
                        { MessageBox.Show("Hiba az adatfeltöltés során!"); }
                        else { MessageBox.Show("A feltöltés megtörtént!"); }
                        Csatlakozas.Close(); 
                    }
                }
            }
            catch (Exception) 
            { MessageBox.Show("Nem sikerült a csalakozás"); }
            CegnevInfo.Text = ""; 
            TelephelyInfo.Text = "";
            Kontakt1NevInfo.Text = "";
            Kontakt1TitulusInfo.Text = "";
            Kontakt1TelefonInfo.Text = "";
            Kontakt1EmailInfo.Text = "";
            Kontakt2NevInfo.Text = "";
            Kontakt2TitulusInfo.Text = "";
            Kontakt2TelefonInfo.Text = "";
            Kontakt2EmailInfo.Text = "";
            TipusMegrendeloRadioGomb.Checked = false;
            TipusBeszallitoRadioGomb.Checked = false;
        }
        
    }
}
