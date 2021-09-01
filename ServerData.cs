using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Szakdolgozat___PRP
{
    class ServerData
    {
        public static string FileUtvonal = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\Adatok'.mdf";
        public static string SzerverInfo = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + FileUtvonal + ";Integrated Security = True";
        public static List<Partner> KiolvasottAdatokPartner = new List<Partner>();
        public static List<Projekt> ProjektAdatok = new List<Projekt>();
        public static List<Alapanyag> AANyilvantartas = new List<Alapanyag>();
        public static List<Termek> Receptura = new List<Termek>();
        public static List<Szukseges> Szukseg = new List<Szukseges>();
    }
    class Szukseges
    {
        public string Nev;
        public int Db;
        public int FelhasznalhatoDb;
        public Szukseges(string Nev, int Db)
        {
            this.Nev = Nev;
            this.Db = Db;
            this.FelhasznalhatoDb = 0;
        }
    }
}
