using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kemia
{
    class Program
    {
        static List<Felfedezes> felfedezesek = new List<Felfedezes>();
        static void Main(string[] args)
        {
            Beolvasas();
            Feladat03();
            Feladat04();
            Feladat05();
            Feladat07();
            Feladat08();


            Console.WriteLine("Program vége!");
            Console.ReadKey();
        }

        private static void Feladat08()
        {
            Console.WriteLine("8. feladat: Statisztika");
            felfedezesek.GroupBy(j => j.Ev).Where(g => g.Count() > 3 && g.Key != "Ókor").ToList().ForEach(a => Console.WriteLine($"\t{a.Key}: {a.Count()} db"));
        }

        private static void Feladat07()
        {
            int leghosszabbev = 0;
            for (int i = 0; i < felfedezesek.Count - 1; i++)
            {
                if (felfedezesek[i].Ev != "Ókor")
                {
                    if (Convert.ToInt32(felfedezesek[i + 1].Ev) - Convert.ToInt32(felfedezesek[i].Ev) > leghosszabbev)
                    {
                        leghosszabbev = Convert.ToInt32(felfedezesek[i + 1].Ev) - Convert.ToInt32(felfedezesek[i].Ev);
                    }
                }
            }
            Console.WriteLine($"7. feladat: {leghosszabbev} év volt a leghosszabb időszak két elem felfedezése között.");
        }

        private static void Feladat05()
        {
            string ujvegyjel;
            Console.WriteLine("5. feladat: ");
            
                do
                {
                Console.WriteLine("Kérek egy vegyjelet: ");
                ujvegyjel = Console.ReadLine();

                } while (!vegyjelCheck(ujvegyjel));
        }

        private static bool vegyjelCheck( string vegyjel)
        {
            bool jo = true;
            vegyjel = vegyjel.ToLower();
            for (int i = 0; i < vegyjel.Length; i++)
            {
                if (vegyjel[i] < 'a' || vegyjel[i] > 'z')
                {
                    jo = false;
                }
            }
            if (vegyjel.Length < 1 || vegyjel.Length > 2)
            {
                jo = false;
            }
            return jo;
        }

        private static void Feladat04()
        {
            int okori = 0;
            foreach (Felfedezes felfedezes in felfedezesek)
            {
                if (felfedezes.Ev.Equals("Ókor"))
                {
                    okori++;
                }
            }
            Console.WriteLine($"4. feladat: Felfedezések száma az ókorban: {okori}");
        }

        private static void Feladat03()
        {
            Console.WriteLine($"3. Feladat:Elemek száma: {felfedezesek.Count}");
        }

        private static void Beolvasas()
        {
            foreach (string felfedezes in File.ReadAllLines("felfedezesek.csv").Skip(1))
            {
                felfedezesek.Add(new Felfedezes(felfedezes));
            }
        }
    }
}
