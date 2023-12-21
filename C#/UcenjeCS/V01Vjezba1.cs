using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class V01Vjezba1
    {
        public static void Izvedi ()
        {
            Console.Write("Unesite prvi cijeli broj: ");
            int PrviBroj = int.Parse(Console.ReadLine());
            Console.Write("Unesite drugi cijeli broj: ");
            int DrugiBroj = int.Parse(Console.ReadLine());
            if (PrviBroj %1 == 0)
            {
                if (DrugiBroj %2 == 0)
                {
                    Console.WriteLine("Unjeli ste prirodane brojeve");
                } else
                {
                    Console.WriteLine("Drugi broj nije prirodan");
                }
             } else
            {
                Console.WriteLine("Prvi broj nije prirodan");
            }
            
            Console.Write("Unesite operator: ");
            string Operator = Console.ReadLine();

            int Rezultat = 0;

            switch (Operator)
            {
                case "+":
                    Rezultat=PrviBroj+DrugiBroj; 
                    break;
                case "-":
                    Rezultat=PrviBroj-DrugiBroj;
                    break;
                case "*":
                    Rezultat=PrviBroj*DrugiBroj;
                    break;
                case "/":
                    if (DrugiBroj==0)
                    {
                        Console.WriteLine("Nema djeljenja s nulom");
                    }
                    else
                    {
                        Rezultat=PrviBroj/DrugiBroj;
                    }
                    break;
                default:
                    Console.WriteLine("Unjeliste ne važači operator");
                    break;
            }
            Console.WriteLine($"{PrviBroj} {Operator} {DrugiBroj} = {Rezultat}");

        }
    }
}
