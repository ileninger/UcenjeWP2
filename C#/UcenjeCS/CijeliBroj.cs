using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CijeliBroj
    {
        public static void Izvedi ()
        {
            //Console.Write("Unesite cijeli broj: ");
            //var CijeliBroj = int.Parse(Console.ReadLine());

            //if (CijeliBroj %1 == 0 )
            //{
            //    Console.WriteLine("Unjeli ste cijeli broj");

            //} else
            //{
            //    Console.WriteLine("Niste unjeli cijeli broj");
            //}
            Console.Write("Unesite prvi broj: ");
            int PrviBroj = int.Parse(Console.ReadLine());
            Console.Write("Unesite drugi broj:");
            int DrugiBroj = int.Parse(Console.ReadLine());

            int Rezultat = 0;
            if (DrugiBroj > PrviBroj)
            {
                Rezultat = Math.Abs(DrugiBroj - PrviBroj);
            } else
            {
                Rezultat = Math.Abs(PrviBroj - DrugiBroj);
            }
            Console.WriteLine($"Rezultat je: {Rezultat}");

        }
    }
}
