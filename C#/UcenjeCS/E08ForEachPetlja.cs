using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E08ForEachPetlja
    {
        public static void Izvedi()
        {
            // Korisnik unosi tekst a program ispisuje
            // koje slovo je unio koliko puta
            // Osijek je super grad

            Console.Write("Unesite tekst: ");
            string UneseniTest = Console.ReadLine();

            Console.WriteLine($"Korinsik je uneo:{UneseniTest} ");

            int[] Slova = new int[UneseniTest.Length]; // Pravimo niz u onoj dužini koliko elemenata ima uneseni tekst
            int Index = 0;
            int Rezultat;

            // Idemo ispisati koliko se puta pojavljuje pojedino slovo - broj ponavljanje ispod slova

            foreach (char c in UneseniTest)
            {
                Rezultat = 0;
                foreach (char cc in UneseniTest)
                {
                    if (c == cc)
                    {
                        Rezultat++;
                    }
                }
                Slova[Index++] = Rezultat;
            }
            //Console.WriteLine(string.Join(",",Slova));

            // Idemo ispisati koliko je unikatnih slova

            char[] JedinstvenoSlovo = new char[UneseniTest.Length]; // Pravimo novi niz samo od unesenih slova u duljini unosa
            bool Postoji;
            Index = 0;

            foreach (char c in UneseniTest) {
                Postoji = false;

                foreach (char cc in JedinstvenoSlovo)
                {
                    if (c == cc)
                    {
                        Postoji = true;
                        break;
                    }
                }
                if (!Postoji)
                {
                    JedinstvenoSlovo[Index++] = c;
                }
            }
            //Console.WriteLine(string.Join(",",JedinstvenoSlovo));
            foreach (char c in JedinstvenoSlovo)
            {
                Console.Write(c + " ");
                Index = 0;

                foreach (char cc in UneseniTest)
                {
                    if (c == cc)
                    {
                        Console.WriteLine(Slova[Index]);
                        break;
                    }
                    Index++;
                }
            }

        }
    }
}
