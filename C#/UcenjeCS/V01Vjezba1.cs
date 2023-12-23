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
            //int broj;
            //for (; ; )
            //{
            //    Console.Write("Unesi broj između 1 i 10: ");
            //    broj = int.Parse(Console.ReadLine());
            //    if (broj >= 1 && broj <= 10)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Dragi korisniče, krivi unos!");
            //}
            int PrviBroj;
            int DrugiBroj;  
            for (; ; )
            {
                Console.Write("Unesite prvi cijeli broj: ");
                string UnosPrvogBroja = Console.ReadLine();

                if (int.TryParse(UnosPrvogBroja, out PrviBroj))
                {
                    Console.WriteLine($"Unjeli ste broj {PrviBroj}");
                    break;

                }
                else
                {
                    Console.WriteLine("***Niste unjeli ste cijeli broj!!***");
                }
            }
            for (; ; )
            {
                Console.Write("Unesite drugi cijeli broj: ");
                string UnosDrugogBroja = Console.ReadLine();

                if (int.TryParse(UnosDrugogBroja, out DrugiBroj))
                {
                    Console.WriteLine($"Unjeli ste broj {DrugiBroj}");
                    break;
                }
                else
                {
                    Console.WriteLine("***Niste unjeli ste cijeli broj!!***");
                }
            }

            Console.Write("Unesite operator: ");
            string Operator = Console.ReadLine();

            int Rezultat = 0;

            switch (Operator)
            {
                case "+":
                    Rezultat = PrviBroj + DrugiBroj;
                    break;
                case "-":
                    Rezultat = PrviBroj - DrugiBroj;
                    break;
                case "*":
                    Rezultat = PrviBroj * DrugiBroj;
                    break;
                case "/":
                    if (DrugiBroj == 0)
                    {
                        Console.WriteLine("Nema djeljenja s nulom");
                    }
                    else
                    {
                        Rezultat = PrviBroj / DrugiBroj;
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
