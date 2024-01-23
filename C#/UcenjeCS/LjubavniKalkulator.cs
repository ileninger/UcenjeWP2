using System;
using System.Collections;
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
            string KonacniRezultat = string.Join(" ", VratiNiz(PocetniNiz(PrvoIme,DrugoIme))); // Dobivanje konacnog rezultata kao string

            //Ispis programa
            Console.WriteLine($"{PrvoIme} i {DrugoIme} vole se:  {KonacniRezultat} %");
        }
        //Metoda za unos imena
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
        
        // Spajanje imena i prebrojavanje koliko se puta pojavljuje određeno slovo u spojenom nizu
        private static int[] PocetniNiz(string PrvoIme, string DrugoIme)
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

            Console.WriteLine(SpojenaImena + "\n" + string.Join(" ", NizZaAnalizu));

            return NizZaAnalizu;
        }
        //Metoda koja proracunava, tj zbraja prvi i zadnji element
        private static int [] Kalkulator(int[] PrimjeniNiz)
        {

            int DuzinaPocetnogNiza = PrimjeniNiz.Length;
            int[] Rezultat = new int[DuzinaPocetnogNiza / 2 + (DuzinaPocetnogNiza % 2)];
            int[] RezultatNeparnogNiza = new int[PrimjeniNiz.Length * 2];
            for (int i = 0; i < DuzinaPocetnogNiza / 2; i++) // Zbrajaj prvu s zadnjom znamenkom sve dok ima elemenata
            {
                
                Rezultat[i] = PrimjeniNiz[i] + PrimjeniNiz[DuzinaPocetnogNiza - i - 1];
                PrimjeniNiz[i] = Rezultat[i];
            }

            if (DuzinaPocetnogNiza % 2 == 1) // Ako je niz neparan prepisi znamenku
            {
                Rezultat[DuzinaPocetnogNiza / 2] = PrimjeniNiz[DuzinaPocetnogNiza / 2];
                PrimjeniNiz = Rezultat;

            }

            return PrimjeniNiz;
        }
        // Rekurzija
        private static int[] VratiNiz (int[] PrimjeniNiz)
        {
            int NovaVelicinaNiza = PrimjeniNiz.Length / 2 + PrimjeniNiz.Length % 2;
            int[] NoviAnaliziraniNiz = new int[NovaVelicinaNiza];

            if (PrimjeniNiz.Length == 2) // Uvjet prekidanja rekurzija ako broj ima 2 znamenke
            {
                return PrimjeniNiz; 
            }

            Kalkulator(PrimjeniNiz);

            Array.Copy(PrimjeniNiz,NoviAnaliziraniNiz,Math.Min(PrimjeniNiz.Length,NovaVelicinaNiza));

            Console.WriteLine(string.Join(" ",NoviAnaliziraniNiz));
            return VratiNiz(RazdvajanjeBrojeva(NoviAnaliziraniNiz)); // Vracamo rekurziju gore
        }
        //Metoda koja provjerava ima li u nizu dvoznamekastih brojeva i ako ima rastavlja dvoznamenkasti broj na jednoznamekasti
        private static int[] RazdvajanjeBrojeva (int[] PrimjeniNiz)
        {
            int DvoznaMenkastiBroj = Array.FindIndex(PrimjeniNiz, n => n >= 10 && n <= 99);
            int [] NoviRazvijeniNiz = new int[PrimjeniNiz.Length + 1];

            if (DvoznaMenkastiBroj == Array.FindIndex(PrimjeniNiz, n => n >= 10 && n <= 99)) //Uvjet da je broj dvoznamenkasti
            {
                if (DvoznaMenkastiBroj == -1)
                {
                    return PrimjeniNiz;
                }
                int BrojOdDvijeZnameke = PrimjeniNiz[DvoznaMenkastiBroj];   //Razbijanje na 2 broja
                int DrugZnamenka = BrojOdDvijeZnameke / 10;
                int PrvaZnameka = BrojOdDvijeZnameke % 10;

                Array.Copy(PrimjeniNiz, NoviRazvijeniNiz, DvoznaMenkastiBroj);
                NoviRazvijeniNiz[DvoznaMenkastiBroj] = DrugZnamenka;
                NoviRazvijeniNiz[DvoznaMenkastiBroj + 1] = PrvaZnameka;

                Array.Copy(PrimjeniNiz, DvoznaMenkastiBroj + 1, NoviRazvijeniNiz, DvoznaMenkastiBroj+ 2, PrimjeniNiz.Length - DvoznaMenkastiBroj- 1);

            }
            return RazdvajanjeBrojeva(NoviRazvijeniNiz); // Vracanje novog niza 
        }
        
    }
}
