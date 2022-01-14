using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fifa
{
    class FIFAvilagranglista
    {
        static void Main(string[] args)
        {
            List<csapat> csapatok = new List<csapat>();
            foreach (var sor in File.ReadAllLines("fifa.txt").Skip(1))
            {
                csapatok.Add(new csapat(sor));
            }


            //3.
            Console.WriteLine($"3. feladat: A világtanglistán {csapatok.Count} csapat szerepel");
            //4.
            Console.WriteLine($"4. feladat: A csapatok átlagos pontszáma: {csapatok.Average(x => x.Pontszam):0.00} pont");
            //5.
            csapat megJ = csapatok.OrderBy(x => x.Valtozas).Last();

            Console.WriteLine($"5. feladat: A legtöbbet javító csapat:");
            Console.WriteLine($"\tHelyezés: {megJ.Helyezes}");
            Console.WriteLine($"\tCsapat: {megJ.Csapat}");
            Console.WriteLine($"\tPontszám: {megJ.Pontszam}");

            //6.
            Console.WriteLine($"6. feladat: A capatok között {(csapatok.Any(v => v.Csapat == "Magyarország") ? "van" : "nincs")} Magyarország");
            //7.
            Dictionary<int, int> statisztika = new Dictionary<int, int>();
            Console.WriteLine("7. feladat: Satatisztika:");
            foreach (var c in csapatok)
            {
                if (statisztika.ContainsKey(c.Valtozas))
                {
                    statisztika[c.Valtozas]++;
                }
                else
                {
                    statisztika.Add(c.Valtozas, 1);
                }
            }
            foreach (var x in statisztika)
            {
                if (x.Value>1)
                {
                    Console.WriteLine($"\t{x.Key}helyezés változott: {x.Value}");
                }
            }





        }
    }
}
