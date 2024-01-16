using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LjubavniKalkulator
    {
        public static void Izvedi()
        {
            string PrvoIme = UnesiIme("Unesite prvo ime: ");
            //string DrugoIme = UnesiIme("Unesite drugo ime: ");
            Console.WriteLine($"Unjeli ste kao prvo ime {PrvoIme}");
            BrojPonavljanjaSlovaUnutarImena(PrvoIme);
        }

        private static void BrojPonavljanjaSlovaUnutarImena(string a)
        {
            int[] Slova = new int[a.Length]; // Pravimo niz u onoj dužini koliko elemenata ima uneseni tekst
            int Index = 0;
            int Rezultat;
            foreach (char c in a)
            {
                Rezultat = 0;
                foreach (char cc in a)
                {
                    if (c == cc)
                    {
                        Rezultat++;
                    }
                }
                Slova[Index++] = Rezultat;
            }
            char[] JedinstvenoSlovo = new char[a.Length]; // Pravimo novi niz samo od unesenih slova u duljini unosa
            bool Postoji;
            Index = 0;

            foreach (char c in a)
            {
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
            //Console.WriteLine(string.Join(",", JedinstvenoSlovo));
            Console.WriteLine(string.Join(",", Slova));
            //foreach (char c in JedinstvenoSlovo)
            //{
            //    Console.Write(c + " ");
            //    Index = 0;

            //    foreach (char cc in a)
            //    {
            //        if (c == cc)
            //        {
            //            Console.WriteLine(Slova[Index]);

            //            break;
            //        }
            //        Index++;
            //    }
            //}
        }

        private static string UnesiIme(string v)
        {
            for (; ; )
            {
                Console.Write(v);
                try
                {
                    return Console.ReadLine();
                }
                catch (Exception e)
                {

                    Console.WriteLine("Nisi unio Ime");
                }
            }
        }
    }
}
