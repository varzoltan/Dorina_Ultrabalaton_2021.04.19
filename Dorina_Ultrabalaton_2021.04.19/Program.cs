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
            //Adattagok létrehozása
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
            int n = 0;
            while (!olvas.EndOfStream)
            {
                string sor = olvas.ReadLine();//Beolvassuk a teljes sort!
                string[] darabol = sor.Split(';');
                adatok[n].versenyzo = darabol[0];
                adatok[n].rajtszam = int.Parse(darabol[1]);
                adatok[n].kategoria = darabol[2];
                adatok[n].versenyido = darabol[3];
                adatok[n].tavszazalek = int.Parse(darabol[4]);
                n++;
                //n = n + 1;Ez egyenlő: n++
            }
            //Ciklikus adatfeldolgozás
            olvas.Close();
            Console.WriteLine("2.feladat\nBeolvasás kész!");

            //3.feladat
            //Határozza meg és írja ki a képernyőre a minta szerint, hogy hány egyéni sportoló indult el
            //a versenyen!
            Console.WriteLine("3. feladat: Egyéni indulók: "+ n + " fő");

            //4.feladat
            //for (//honnan indulunk;meddig megyünk;lépésköz)
            //Összegzés tétele
            int hany = 0;
            for(int i = 0;i<n;i++)
            {
                if (adatok[i].kategoria == "Noi" && adatok[i].tavszazalek == 100)
                {
                    hany++;
                }
            }
            Console.WriteLine("4. feladat: Célba érkező női sportolók: "+hany+" fő");

            //5.feladat
            //Név bekérése a felhasználótól
            Console.Write("5. feladat: Kérem a sportoló nevét: ");
            string nev = Console.ReadLine();
            bool volt_e = false;
            for (int i = 0; i < n; i++)
            {
                if (nev == adatok[i].versenyzo)
                {
                    Console.WriteLine("\tIndult egyéniben a sportoló? Igen");
                    volt_e = true;
                }
                /*if (adatok[i].tavszazalek == 100)
                {
                    Console.WriteLine("\tTeljesítette a teljes távot? Igen");
                }*/
                /*else
                {
                    Console.WriteLine("Indult egyéniben a sportoló? Nem");
                }*/
            }
            if (volt_e == false)
            {
                Console.WriteLine("\tIndult egyéniben a sportoló? Nem");
            }

            Console.ReadKey();//Vár egy billentyű leütésére!
        }
    }
}
