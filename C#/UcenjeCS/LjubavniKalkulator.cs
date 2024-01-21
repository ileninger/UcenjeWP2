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
            string DrugoIme = UnesiIme("Unesite drugo ime: ");

            Console.WriteLine(Kalkulator(PocetniNiz (PrvoIme,DrugoIme)));


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


        private static int[] PocetniNiz (string PrvoIme, string DrugoIme ) 
        {
            string SpojenaImena = PrvoIme + DrugoIme;
            int[] NizZaAnalizu = new int[SpojenaImena.Length];
            int i = 0;
            

            // Sada cemo prebrojati koliko se puta koje slovo pojavljuje u nizu koji se sastoji od prvog i  drugog imena

            foreach (char c in SpojenaImena)
            {
                int Brojac = 0;

                foreach (char cc in SpojenaImena)
                {
                    if (c == cc) // Ako se isti znak vec pojavljuje
                    {
                        Brojac++;
                    }
                }
                NizZaAnalizu[i++] = Brojac;
            }

            Console.WriteLine(SpojenaImena + "\n" + string.Join(" ",NizZaAnalizu));

            return NizZaAnalizu;
        }

        private static string Kalkulator (int[] PrimjeniNiz)
        {
            ///Definiramo "pozicije s kojih nam ide brojac unutar niza Min i Max
            //int Min = 0;
            //int Max = PrimjeniNiz.Length;
            string Novi = null;
            int Brojac = 0;
            int Rez;
            int DuzinaPocetnogNiza = PrimjeniNiz.Length;
            int[] Rezultat = new int[DuzinaPocetnogNiza / 2 + (DuzinaPocetnogNiza % 2)]; ;

            //while (Min < Max)
            //{
                //int LijeviDio = PrimjeniNiz[Min];
                //int DesniDio = PrimjeniNiz[Max];

                //for (int i = Min; i < Max; i++)
                //{
                //    Rezultat[i] = LijeviDio + (DesniDio-i-1);
                //}
                //Min++;
                //Max--;


                for (int i = 0; i < DuzinaPocetnogNiza / 2; i++)
                {
                    Rezultat[i] = PrimjeniNiz[i] + PrimjeniNiz[DuzinaPocetnogNiza - i - 1];
                }

                if (DuzinaPocetnogNiza % 2 == 1)
                {
                    Rezultat[DuzinaPocetnogNiza / 2] = PrimjeniNiz[DuzinaPocetnogNiza / 2];
                }



            //}

            return string.Join(" ",Rezultat);
        }


    }
}
