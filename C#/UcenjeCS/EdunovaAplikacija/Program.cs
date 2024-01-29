using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.EdunovaAplikacija.Model;

namespace UcenjeCS.EdunovaAplikacija
{
    internal class Program
    {
        private List<Smjer> Smjerovi;
        private List<Predavac> Predavaci;

        public Program()
        {
            Smjerovi = new List<Smjer>();
            Predavaci = new List<Predavac>();
            PozdravnaPoruka();
            GlavniIzbornik();

        }

        private void GlavniIzbornik()
        {
            Console.WriteLine("Izbornik");
            Console.WriteLine("1. Rad s smjerovima");
            Console.WriteLine("2. Rad s predavačim");
            Console.WriteLine("3. Rad s polaznicima");
            Console.WriteLine("4. Rad s grupama");
            Console.WriteLine("5. Izlaz iz programa");
            OdabirStavkeGlavnogIzbornika();

        }

        private void OdabirStavkeGlavnogIzbornika()
        {
            switch (Pomocno.UcitajInt("Unesi izbor: "))
            {
                case 1:
                    Console.WriteLine("Odabrali ste rad sa smjerovima");
                    IzbornikRadSaSmjerovima();
                    break;
                case 2:
                    Console.WriteLine("Odabrali ste rad s predavačima");
                    IzbornikRadSaPredavacima();
                    break;
                case 3:
                    Console.WriteLine("Odabrali ste rad s polaznicima");
                    break;
                case 4:
                    Console.WriteLine("Odabrali ste rad s grupama");
                    break;
                case 5:
                    Console.WriteLine("Doviđenja");
                    break;
                default:
                    GlavniIzbornik();
                    break;
            }

        }

        private void IzbornikRadSaPredavacima()
        {
            Console.WriteLine("1. Prikaži sve predavače: ");
            Console.WriteLine("2. Dodaj predavača ");
            Console.WriteLine("3. Uredi predavača ");
            Console.WriteLine("4. Izbriši predavača ");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirStavkeIzbornikPredavac();
        }

        private void OdabirStavkeIzbornikPredavac()
        {
            switch (Pomocno.UcitajInt("Unesi izbor: "))
            {
                case 1:
                    Console.WriteLine("Odabrali ste prikaz svih unesenih predavača");
                    PrikaziSvePredavace();
                    IzbornikRadSaPredavacima();
                    break;
                case 2:
                    Console.WriteLine("Odabrali ste dodavanje predavača");
                    DodajNovogPredavaca();
                    break;
                case 3:
                    Console.WriteLine("Odabrali ste uređivanje predavača");
                    UrediSmjer();
                    break;
                case 4:
                    Console.WriteLine("Odabrali ste brisanje predavača");
                    IzbrisiSmjer();
                    break;
                case 5:
                    Console.WriteLine("Povratak na prethodni izbornik");
                    GlavniIzbornik();
                    break;
                default:
                    Console.WriteLine("Krivi odabir");
                    IzbornikRadSaSmjerovima();
                    break;
            }

        }

        private void DodajNovogPredavaca()
        {
            Predavaci.Add(new Predavac()
            {
                Sifra = Pomocno.UcitajInt("Unesi šifru predavaca: "),
                Ime = Pomocno.UcitajString("Unesi ime predavaca: "),
                Prezime  = Pomocno.UcitajString ("Unesite prezime predavaca: "),
                Email = Pomocno.UcitajString ("Unesite predavačev email:"),
                Oib = Pomocno.UcitajString("Unesite predavačev OiB:"),
                Iban = Pomocno.UcitajString("Unesite predavačev Iban:"),
            });
            IzbornikRadSaSmjerovima(); 
        }

        private void PrikaziSvePredavace()
        {
            var i = 0;
            Predavaci.ForEach(s =>
            {
                Console.WriteLine(++i + "." + s);
            });
            Console.WriteLine("**********************"); ;
        }

        private void IzbornikRadSaSmjerovima()
        {

            Console.WriteLine("1. Prikaži sve smjerove");
            Console.WriteLine("2. Dodaj smjer");
            Console.WriteLine("3. Uredi smjer");
            Console.WriteLine("4. Izbriši smjer");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabriStavkeIzbornikSmjera();


        }
        private void OdabriStavkeIzbornikSmjera()
        {
            switch (Pomocno.UcitajInt("Unesi izbor: "))
            {
                case 1:
                    Console.WriteLine("Odabrali ste prikaz svih unesenih smjerova");
                    PrikaziSveSmjerove();
                    IzbornikRadSaSmjerovima();
                    break;
                case 2:
                    Console.WriteLine("Odabrali ste dodavanje smjera");
                    DodajNoviSmjer();
                    break;
                case 3:
                    Console.WriteLine("Odabrali ste uređivanje smjera");
                    UrediPredavaca();
                    break;
                case 4:
                    Console.WriteLine("Odabrali ste brisanje smjera");
                    IzbrisiPredavaca();
                    break;
                case 5:
                    Console.WriteLine("Povratak na prethodni izbornik");
                    GlavniIzbornik();
                    break;
                default:
                    Console.WriteLine("Krivi odabir");
                    IzbornikRadSaSmjerovima();
                    break;
            }
        }

        private void IzbrisiPredavaca()
        {
            PrikaziSvePredavace();
            Predavaci.RemoveAt(Pomocno.UcitajInt("Odaberi smjer za brisanje: "));
            IzbornikRadSaSmjerovima(); ;
        }

        private void UrediPredavaca()
        {
            PrikaziSvePredavace();
            var s = Predavaci[Pomocno.UcitajInt("Odaberi predavača za promjenu: ") - 1];
            s.Sifra = Pomocno.UcitajInt(s.Sifra + "Unesi promljenjenu šifru: ");
            s.Ime = Pomocno.UcitajString(s.Ime + "Unesi promljenji naziv " + s.Ime);
            s.Prezime = Pomocno.UcitajString(s.Prezime + "Unesi promljenji naziv " + s.Prezime);
            s.Email = Pomocno.UcitajString(s.Email+ "Unesi promljenji naziv " + s.Email);
            s.Oib = Pomocno.UcitajString(s.Oib + "Unesi promljenji naziv " + s.Oib);
            s.Iban = Pomocno.UcitajString(s.Iban+ "Unesi promljenji naziv " + s.Iban);
            IzbornikRadSaSmjerovima(); ;
        }

        private void IzbrisiSmjer()
        {
            PrikaziSveSmjerove();
            Smjerovi.RemoveAt(Pomocno.UcitajInt("Odaberi smjer za brisanje: "));
            IzbornikRadSaSmjerovima();
        }

        private void UrediSmjer()
        {
            PrikaziSveSmjerove();
            var s = Smjerovi[Pomocno.UcitajInt("Odaberi smjer za promjenu: ") - 1];
            s.Sifra = Pomocno.UcitajInt(s.Sifra + "Unesi promljenjenu šifru: ");
            s.Naziv = Pomocno.UcitajString(s.Naziv + "Unesi promljenji naziv " + s.Naziv);
            IzbornikRadSaSmjerovima();
        }

        private void PrikaziSveSmjerove()
        {
            var i = 0;
            Smjerovi.ForEach(s =>
            {
                Console.WriteLine(++i + "." + s);
            });
            Console.WriteLine("**********************");
        }

        private void DodajNoviSmjer()
        {

            Smjerovi.Add(new Smjer()
            {
                Sifra = Pomocno.UcitajInt("Unesi šifru smjera: "),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera: ")
                // ucitat ostale smjerove
            });
            IzbornikRadSaSmjerovima();
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("* EDUNOVA KONZOLNA APLIKACIJA V1 *");
            Console.WriteLine("**********************************");
        }


    }
}
