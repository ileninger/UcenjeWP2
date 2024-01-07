using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class RockPaperScissors
    {
        public static void Izvedi()
        {
            Random random = new Random();


            Console.WriteLine("KAMEN, ŠKARE PAPIR!!!");
            Console.WriteLine("**********************");
            Console.Write("Odaberite Kamen, Škare ili Papir:");
            int ComputerChoisee = random.Next(1,4);
            int UserChoiseI = 0;
            for (; ;)
            {
                Console.Write("Odaberite Kamen, Škare ili Papir:");
                string UserChoiseS = Console.ReadLine();
                if (UserChoiseS == "Kamen")
                {
                    UserChoiseI = 1;
                    break;
                }
                else if (UserChoiseS == "Skare")
                {
                    UserChoiseI = 2;
                    break;
                }
                else if (UserChoiseS == "Papir")
                {
                    UserChoiseI = 3;
                    break;
                }
                else
                {
                    Console.WriteLine("Niste odabrali ni Kamen ni Škare ni Papir,probajte ponovo");
                }
            }
            

            switch (UserChoiseI)
            {
                case 1:
                    Console.WriteLine($"Korisnik je odrabrao Kamen!");
                    break;
                case 2:
                    Console.WriteLine($"Korisnik je odrabrao Škare!");
                    break;
                case 3:
                    Console.WriteLine($"Korisnik je odrabrao Papir!");
                    break;
            }

            switch (ComputerChoisee)
            {
                case 1:
                    Console.WriteLine($"Računalo je odrabrao Kamen!");
                    break;
                case 2:
                    Console.WriteLine($"Računalo je odrabrao Škare!");
                    break;
                case 3:
                    Console.WriteLine($"Računalo je odrabrao Papir!");
                    break;
            }
            if (UserChoiseI == ComputerChoisee)
            {
                Console.WriteLine("Izjednačeno");
            }
            else if ((UserChoiseI==1 && ComputerChoisee  ==  2) || (UserChoiseI==3 && ComputerChoisee==1) ||(UserChoiseI==2 && ComputerChoisee == 3))
            {
                Console.WriteLine("Korisnik pobjeđuje");
            }
            else
            {
                Console.WriteLine("Računalo Pobjeđuje");
            }


        }
    }
}
