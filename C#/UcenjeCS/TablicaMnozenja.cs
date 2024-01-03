using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class TablicaMnozenja
    {
        public static void Izvedi()
        {
            Console.Write("Unesite prvi Broj: ");
            int PrviBroj = int.Parse(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            int DrugiBroj = int.Parse(Console.ReadLine());
            int[,] TablicaMnozenja = new int[PrviBroj, DrugiBroj];
            
            for (int i = 0; i < PrviBroj; i++ ) //Prolazi kroz stupce
            {
                for (int j = 0; j < DrugiBroj; j++ ) //Prolazi kroz retke
                {
                    TablicaMnozenja[i, j] = (i+1) * (j+1); // Popunjavanja niza (tablice)
                }
            }
            for (int i = 0; i < PrviBroj; i++) //Prolazi kroz stupce
            {
                for (int j = 0; j < DrugiBroj; j++) // Prolazi kroz retke
                {
                    Console.Write($"{TablicaMnozenja[i,j],4} "); // ispisuje matricu s 4 poravanjanja
                }
                Console.WriteLine(); //Prealazi u novi redak
            }
        }
    }
}
