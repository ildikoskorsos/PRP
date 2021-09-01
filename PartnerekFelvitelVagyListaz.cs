using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szakdolgozat___PRP
{
    public partial class PartnerekFelvitelVagyListaz : UserControl
    {
        public PartnerekFelvitelVagyListaz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UjPartnerRogzitese Felvitel = new UjPartnerRogzitese();
            Felvitel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PartnerekListazasa Feltuntet = new PartnerekListazasa();
            Feltuntet.Show();
            Feltuntet.ListabaOlvasas();
        }
    }
}
