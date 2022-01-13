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

        }
    }
}
