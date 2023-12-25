using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class V01ZimskoVjezbanje
    {
        public static void Izvedi()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("****************");

            Console.WriteLine("EVO DEKREMENTA");

            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("BROJEVI DJELJIVI S 7");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0) Console.WriteLine(i);
            }
            int BrojUnosa = 0;
            for (; ; )
            {
                Console.Write("Unesite broj veci od 100: ");
                int UneseniBroj = int.Parse(Console.ReadLine());
                if (UneseniBroj <= 100)
                {
                    BrojUnosa++;
                } else
                {
                    Console.WriteLine($"Pokušali ste unjeti broj manji od 100 {BrojUnosa} puta.");
                    break;
                }

            }
        }
    }
}
