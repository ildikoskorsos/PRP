using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat___PRP
{
    class Projekt
    {
        public int Id;
        public string Projektnev;
        public string Partner;
        public string Termek;
        public int Mennyiseg;
        public string Felelos;
        public string Hatarido;
        public string Statusz;
        public string Email;
        public string Szerzodes;
        public string Egyeb1;
        public string Egyeb2;
        public Projekt(int Id, string Projketnev, string Partner, string Termek, int Mennyiseg, string Felelos, string Hatarido, string Statusz,string Email, string Szerzodes, string Egyeb1, string Egyeb2)
        {
            this.Id = Id;
            this.Projektnev = Projketnev;
            this.Partner = Partner;
            this.Termek = Termek;
            this.Mennyiseg = Convert.ToInt32(Mennyiseg);
            this.Felelos = Felelos;
            this.Hatarido = Hatarido;
            this.Statusz = Statusz;
            this.Email = Email;
            this.Szerzodes =Szerzodes;
            this.Egyeb1 = Egyeb1;
            this.Egyeb2 = Egyeb2;
        }
    }
}
