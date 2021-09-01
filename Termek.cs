using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat___PRP
{
    class Termek
    {
        public string TermekNev;
        public List<hozzavalo> Hozzavalok = new List<hozzavalo>();
        public Termek(string Adatok)
        {
            string[] AdatElemek = Adatok.Split(':');
            this.TermekNev = AdatElemek[0];
            string[] HozzavalokLista = AdatElemek[1].Split(';');
            for (int i = 0; i < HozzavalokLista.Length - 1; i++)
            {
                this.Hozzavalok.Add(new hozzavalo(HozzavalokLista[i]));
            }
        }
    }
    class hozzavalo
    {
        public string HozzavaloNev;
        public int HozzavaloMennyiseg;
        public hozzavalo(string hozzavaloAdatsor)
        {
            string[] HozzavaloAdatsorElemek = hozzavaloAdatsor.Split(',');
            this.HozzavaloNev = HozzavaloAdatsorElemek[0];
            this.HozzavaloMennyiseg = Convert.ToInt32(HozzavaloAdatsorElemek[1]);
        }
    }
}

