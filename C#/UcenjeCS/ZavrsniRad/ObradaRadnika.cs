using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.EdunovaAplikacija.Model;
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
            TesniPodaci();
            switch (Pomocno.UcitajRasponBrojeva("Odaberite stavku izbornika: ", "Odabir mora biti 1-5. ", 1, 5))
            {
                case 1:
                    PrikaziSveRadnike();
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
            Console.WriteLine("------------------");
            Console.WriteLine("---- Radnici ----");
            Console.WriteLine("------------------");
            int b = 1;
            foreach (Radnik radnik in Radnici)
            {
                Console.WriteLine("{0}. {1}", b++, radnik);
            }
            Console.WriteLine("------------------"); 
            PrikaziIzbornikObradaRadnika();
        }

        private void DodajRadnika()
        {
            var r = new Radnik();

            r.ID = Pomocno.UcitajCijeliBroj ("Unesite šifra polaznika: ",
                "Unos mora biti pozitivni cijeli broj");
            r.Ime = Pomocno.UcitajString("Unesite ime radnika: ", "Ime je obavezno");
            r.Prezime = Pomocno.UcitajString("Unesite prezime radnika: ", "Prezime radnika je obavezno");
            r.DatumZaposlenja = Pomocno.UcitajDatum("Unesi datum zaposlenja radnika u formatu dd.MM.yyyy. ", "Greška");
            r.IBAN = Pomocno.UcitajString("Unesite IBAN radnika: ", "IBAN radnika je obavezan");
            r.OiB = Pomocno.UcitajString("Unesite Oib radnika: ", "OiB radnika je obavezan");
            r.Email = Pomocno.UcitajString("Unesite email radnika: ", "Email radnika je obavezan");
            PrikaziIzbornikObradaRadnika();
        }

        private void PromjenaPostojecegRadnika()
        {
            throw new NotImplementedException();
        }

        private void ObrisiRadnika()
        {
            throw new NotImplementedException();
        }


        private void TesniPodaci()
        {
            Radnici.Add(new Radnik
            {
                ID = 1,
                Ime = "Ivan",
                Prezime = "Leninger",
                //DatumZaposlenja = 24.05.2013,
                IBAN = "HR2224020061176932157",
                OiB = "74203150129",
                Email = "ilenigner@live.com"
            });
            Radnici.Add(new Radnik
            {
                ID = 2,
                Ime = "Petrica",
                Prezime = "Videnović",
                IBAN = "HR8724020069952161214",
                OiB = "33843188162",
                Email = "pvidenović@gmail.com",
                //DatumZaposlenja = 31.10.2013
            });
            Radnici.Add(new Radnik
            {
                ID = 3,
                Ime = "Bratislava",
                Prezime = "Lugar",
                IBAN = "HR0624840081368664615",
                OiB = "67089812195",
                Email = "blugar@gmail.com",
            }); ;
        }




    }

    
}
