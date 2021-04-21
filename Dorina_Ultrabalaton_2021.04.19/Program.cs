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

            StreamReader olvas = new StreamReader(@"C:\Users\Rendszergazda\Downloads\ub2017egyeni.txt");
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

            //2.feladat
            //Határozza meg és írja ki a képernyőre a minta szerint, hogy hány egyéni sportoló indult el
            //a versenyen!
            Console.WriteLine("3. feladat: Egyéni indulól: "+ n + " fő");
            
            Console.ReadKey();//Vár egy billentyű leütésére!
        }
    }
}
