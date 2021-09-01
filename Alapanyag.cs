using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat___PRP
{
    class Alapanyag
    {
        public int Id;
        public string Nev;
        public int BeerkezettMennyiseg;
        public int MegrendeltMennyiseg;
        public string VarhatoBeerkezes;
        public Alapanyag(int Id, string Nev, int BeerkezettMennyiseg, int MegrendeltMennyiseg, string VarhatoBeerkezes)
        {
            this.Id = Id;
            this.Nev = Nev;
            this.BeerkezettMennyiseg = BeerkezettMennyiseg;
            this.MegrendeltMennyiseg = MegrendeltMennyiseg;
            this.VarhatoBeerkezes = VarhatoBeerkezes;
        }
    }    
}
