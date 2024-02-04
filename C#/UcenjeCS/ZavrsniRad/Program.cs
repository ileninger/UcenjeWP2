using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.ZavrsniRad
{
    internal class Program
    {
        public ObradaRadnika ObradaRadnici { get; }
        public Program()
        {
            ObradaRadnici = new ObradaRadnika();
            PozdravnaPoruka();
            PrikaziGlavniIzbornik();
        
            
        }

        private void PrikaziGlavniIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Radnici");
            Console.WriteLine("2. Obračini");
            Console.WriteLine("3. Plače");
            Console.WriteLine("4. Izlaz iz programa");
            OdabirGralvniIzbornik();
        }

        private void OdabirGralvniIzbornik()
        {
            switch(Pomocno.UcitajRasponBrojeva("Odaberite stavku izbornika: ", "Odabir mora biti 1-4. ", 1, 4))
            {
                case 1:
                    ObradaRadnici.PrikaziIzbornikObradaRadnika();
                    OdabirGralvniIzbornik();
                    break;
                case 2:
                    //ObradaObracun;
                    OdabirGralvniIzbornik();
                    break;
                case 3:
                    //ObradaPlaca;
                    OdabirGralvniIzbornik();
                    break;  
                case 4:
                    Console.WriteLine("Hvala na korištenju, doviđenja");
                    break;

            }
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("********OBRACUN PLAČA BY LENY_V1*******");
            Console.WriteLine("***************************************");

        }
    }
}
