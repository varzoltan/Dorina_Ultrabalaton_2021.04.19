using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dorina_Ultrabalaton_2021._04._19
{
    class Program
    {
        //Létrehoztuk a struktúrát
        struct Adat
        {
            //Adatszerkezet létrehozása
            public string versenyzo;
            public int rajtszam;
            public string kategoria;
            public string versenyido;
            public int tavszazalek;
        }

        static void Main(string[] args)
        {
            //Példányosítjuk a struktúránkat!
            Adat[] adatok = new Adat[500];

            StreamReader olvas = new StreamReader(@"E:\OneDrive - Kisvárdai SZC Móricz Zsigmond Szakgimnáziuma és Szakközépiskolája\Oktatas\Programozas\Jakab_Acs_Eszter\Erettsegi_feladatok\2019_maj_Ultrabalaton\ub2017egyeni.txt");
            //Első sor beolvasása
            string Elso_sor = olvas.ReadLine();

            //Ciklikus adatfeldolgozás
            olvas.Close();
        }
    }
}
