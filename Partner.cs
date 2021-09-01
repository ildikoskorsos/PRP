using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Szakdolgozat___PRP
{
    class Partner
    {
        public int Id;
        public string Cegnev;
        public string Telephely;
        public string Kontakt1Nev;
        public string Kontakt1Titulus;
        public string Kontakt1Telefon;
        public string Kontakt1Email;
        public string Kontakt2Nev;
        public string Kontakt2Titulus;
        public string Kontakt2Telefon;
        public string Kontakt2Email;
        public string Tipus;
       
        public Partner (int Id, string Cegnev, string Telephely, string Kontakt1Nev, string Kontakt1Titulus, string Kontakt1Telefon, string Kontakt1Email, string Kontakt2Nev, string Kontakt2Titulus, string Kontakt2Telefon, string Kontakt2Email, string Tipus)
        {
            this.Id = Id;
            this.Cegnev = Cegnev;
            this.Telephely = Telephely;
            this.Kontakt1Nev = Kontakt1Nev;
            this.Kontakt1Titulus = Kontakt1Titulus;
            this.Kontakt1Telefon = Kontakt1Telefon;
            this.Kontakt1Email = Kontakt1Email;
            this.Kontakt2Nev = Kontakt2Nev;
            this.Kontakt2Titulus = Kontakt2Titulus;
            this.Kontakt2Telefon = Kontakt2Telefon;
            this.Kontakt2Email = Kontakt2Email;
            this.Tipus = Tipus;
            
        }
    }
}
