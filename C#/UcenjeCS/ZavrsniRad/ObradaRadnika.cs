using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.ZavrsniRad.Model;

namespace UcenjeCS.ZavrsniRad
{
    internal class ObradaRadnika

    {

        public List <Radnik> Radnici { get; }

        public void PrikaziIzbornikObradaRadnika()
        {
            Console.WriteLine("Izbornik rada s radnicima.");
            Console.WriteLine("1. Prikaži sve radnike");
            Console.WriteLine("2. Unos novog radnika");
            Console.WriteLine("3. Promjena postojećeg randika");
            Console.WriteLine("4. Brisanje radnika");
            Console.WriteLine("5. Povratak na glavni izbornik");

            OdabirIzbornikaObradaRadnika();
        }

        private void OdabirIzbornikaObradaRadnika()
        {
            switch (Pomocno.UcitajRasponBrojeva("Odaberite stavku izbornika: ", "Odabir mora biti 1-5. ", 1, 5))
            {
                case 1:
                    PrikaziSveRadnike();
                    PrikaziIzbornikObradaRadnika();
                    break;
                case 2:
                    DodajRadnika();
                    PrikaziIzbornikObradaRadnika();
                    break;
                case 3:
                    PromjenaPostojecegRadnika();
                    PrikaziIzbornikObradaRadnika();
                    break;
                case 4:
                    ObrisiRadnika();
                    PrikaziIzbornikObradaRadnika();
                    break;
                case 5:
                    Console.WriteLine("Rad s radnicama je gotov");
                    break;



            }
        }

        private void PrikaziSveRadnike()
        {
            throw new NotImplementedException();
        }

        private void DodajRadnika()
        {
            throw new NotImplementedException();
        }

        private void PromjenaPostojecegRadnika()
        {
            throw new NotImplementedException();
        }

        private void ObrisiRadnika()
        {
            throw new NotImplementedException();
        }





    }

    
}
