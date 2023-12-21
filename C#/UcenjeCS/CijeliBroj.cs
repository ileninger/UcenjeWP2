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
            Console.Write("Unesite cijeli broj: ");
            var CijeliBroj = int.Parse(Console.ReadLine());

            if (CijeliBroj %1 == 0 )
            {
                Console.WriteLine("Unjeli ste cijeli broj");

            } else
            {
                Console.WriteLine("Niste unjeli cijeli broj");
            }


        }
    }
}
