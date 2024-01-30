using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.EdunovaAplikacija
{
    internal class Pomocno
    {
        public static int UcitajRasponBrojeva(string poruka, string greska,int poc, int kraj)
        {
            int i;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    i = int.Parse(Console.ReadLine());
                    if (i >= poc && i <= kraj)
                    {
                        return i;
                    }
                    Console.WriteLine(greska);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(greska);
                }
            }
        }

        public static int UcitajCijeliBroj(string poruka, string greska)
        {
            int i;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    i = int.Parse(Console.ReadLine());
                    if (i > 0)
                    {
                        return i;
                    }
                    Console.WriteLine(greska);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(greska);
                }

            }
        }
        public static string UcitajString(string poruka)
        {
            string s;
            while (true)
            {
                Console.Write(poruka);
                s = Console.ReadLine();
                if (s.Trim().Length == 0)
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }
                return s;
            }
        }
    }
}
