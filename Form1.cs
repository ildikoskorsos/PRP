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

namespace Szakdolgozat___PRP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            partnerekFelvitelVagyListaz1.Hide();
            Raktar raktar = new Raktar();
            raktar.AlapanyagListaFeltoltes();
            raktar.RecepturaListaFeltoltes();
        }

        private void ParnerekGomb_Click(object sender, EventArgs e)
        {
            partnerekFelvitelVagyListaz1.Show();
            partnerekFelvitelVagyListaz1.BringToFront();
        }

        private void RaktarGomb_Click(object sender, EventArgs e)
        {
            Raktar RaktarFunkcio = new Raktar();
            RaktarFunkcio.Show();
            partnerekFelvitelVagyListaz1.Hide();
        }

        private void ProjektGomb_Click(object sender, EventArgs e)
        {
            Projektfelvétel Projektfunkcio = new Projektfelvétel();
            Projektfunkcio.Show();
            partnerekFelvitelVagyListaz1.Hide();
            
        }

        private void AblakBezar(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan ki szeretne lépni?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
