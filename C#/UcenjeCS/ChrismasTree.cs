using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class ChrismasTree
    {
        public static void Izvedi()
        {
            Console.Write("Unesite broj redaka:");
            int BrojRedaka=int.Parse(Console.ReadLine());

            string Str = "";

            for(int i = 0; i < BrojRedaka; i++)
            {
                for (int j = 1; j< BrojRedaka - i; j++)
                {
                    Str += " ";
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Str += "*";
                }
                Str += "\n";
            }
            Console.WriteLine(Str);
        }
    }
}
