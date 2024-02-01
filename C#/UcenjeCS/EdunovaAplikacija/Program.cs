using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UcenjeCS.EdunovaAplikacija.Model;

namespace UcenjeCS.EdunovaAplikacija
{
    internal class Program
    {
        private List<Smjer> Smjerovi;
        private List<Predavac> Predavaci;
        private List<Polaznik> Polaznici;
        private List<Grupe> Grupa;

        public Program()
        {
            //Definiranje listi koje koristimo unutar programa
            Smjerovi = new List<Smjer>();
            Predavaci = new List<Predavac>();
            Polaznici = new List<Polaznik>();
            Grupa = new List<Grupe>();

            PozdravnaPoruka();
            GlavniIzbornik();

        }

        //*****************GLAVNI IZBORNIK*****************//

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
            switch (Pomocno.UcitajRasponBrojeva("Odaberite stavku izbornika polaznika: ",
                "Odabir mora biti 1-5", 1, 5))
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
                    IzbornikRadSaPolaznicima();
                    break;
                case 4:
                    Console.WriteLine("Odabrali ste rad s grupama");
                    IzbornikRadSaGrupama();
                    break;
                case 5:
                    Console.WriteLine("Doviđenja");
                    break;
                default:
                    GlavniIzbornik();
                    break;
            }

        }
        //*****************GRUPE*****************//
        private void IzbornikRadSaGrupama()
        {
            Console.WriteLine("1. Prikaži sve grupe: ");
            Console.WriteLine("2. Dodaj grupu ");
            Console.WriteLine("3. Uredi grupu ");
            Console.WriteLine("4. Izbriši grupu ");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirStavkeIzbornikGrupe();
        }

        private void OdabirStavkeIzbornikGrupe()
        {
            switch (Pomocno.UcitajRasponBrojeva("Odaberite stavku izbornika grupe: ",
         "Odabir mora biti 1-5", 1, 5))
            {
                case 1:
                    Console.WriteLine("Odabrali ste prikaz svih unesenih grupa ");
                    PrikaziSveGrupe();
                    IzbornikRadSaPolaznicima();
                    break;
                case 2:
                    Console.WriteLine("Odabrali ste dodavanje grupe ");
                    UnosNoveGrupe();
                    break;
                case 3:
                    Console.WriteLine("Odabrali ste uređivanje grupe ");
                    UrediGrupu();
                    break;
                case 4:
                    Console.WriteLine("Odabrali ste brisanje grupe");
                    IzbrisiGrupu();
                    break;
                case 5:
                    Console.WriteLine("Povratak na prethodni izbornik");
                    GlavniIzbornik();
                    break;
                default:
                    Console.WriteLine("Krivi odabir");
                    IzbornikRadSaGrupama();
                    break;
            }; ;
        }

        private void PrikaziSveGrupe()
        {
            var i = 0;
            Grupa.ForEach(s =>
            {
                Console.WriteLine(++i + "." + s);
            });
            Console.WriteLine("**********************");
            IzbornikRadSaGrupama();
        }

        private void UnosNoveGrupe()
        {
            var g = new Grupe();
            g.Sifra = Pomocno.UcitajCijeliBroj("Unesite šifra grupe: ",
                "Unos mora biti pozitivni cijeli broj");
            g.Naziv = Pomocno.UcitajString("Unesite naziv grupe: ",
                "Unos obavezan");
            g.Smjer = PostaviSmjer();
            g.Predavac = PostaviPredavaca();
            g.Polaznici = PostaviPolaznike();
            g.DatumPocetka = Pomocno.UcitajDatum("Unesi datum grupe u formatu dd.MM.yyyy.", "Greška");
            Grupa.Add(g);
        }



        private List<Polaznik> PostaviPolaznike()
        {
            List<Polaznik> polaznici = new List<Polaznik>();
            while (Pomocno.UcitajBool("Želite li dodati polaznike? (da ili bilo što drugo za ne): "))
            {
                polaznici.Add(PostaviPolaznika());
            }

            return polaznici;
        }
        private Polaznik PostaviPolaznika()
        {
            PrikaziSvePolaznike();
            int index = Pomocno.UcitajRasponBrojeva("Odaberi redni broj polaznika: ", "Nije dobar odabir", 1, Polaznici.Count());
            return Polaznici[index - 1];
        }


        private Smjer PostaviSmjer()
        {
            PrikaziSveSmjerove();
            int index = Pomocno.UcitajRasponBrojeva("Odaberi redni broj smjera: ", "Nije dobar odabir", 1, Smjerovi.Count());
            return Smjerovi[index - 1];
        }

        private List<Predavac> PostaviPredavace()
        {
            List <Predavac> predavac = new List<Predavac> ();

            while (Pomocno.UcitajBool("Želite li dodati polaznike? (da ili bilo što drugo za ne): "))
            {
                predavac.Add(PostaviPredavaca());
            }
            return predavac;

        }
        private Predavac PostaviPredavaca()
        {
            PrikaziSvePredavace();
            int index = Pomocno.UcitajRasponBrojeva("Odaberi redni broj predavaca: ", "Nije dobar odabir", 1, Predavaci.Count());
            return Predavaci[index - 1];
        }

        private void UrediGrupu()
        {
            PrikaziSveGrupe();
            //int index = Pomocno.UcitajRasponBrojeva("Odaberi redni broj predavača: ", "Nije dobar odabir", 1, Predavaci.Count());
            //var s = Predavaci[index - 1];
            //s.Sifra = Pomocno.UcitajCijeliBroj("Unesite šifra smjera (" + s.Sifra + "): ", "Unos mora biti pozitivni cijeli broj");
            //s.Ime = Pomocno.UcitajString(s.Ime + "Unesi  promljeneno ime predavača", "Unos obavezan" + s.Ime);
            //s.Prezime = Pomocno.UcitajString(s.Prezime + "Unesi promljenjeno prezime predavača ", "Unos obavezan" + s.Prezime);
            //s.Email = Pomocno.UcitajString(s.Email + "Unesi promljenjen Email predavača", "Unos obavezan" + s.Email);
            //s.Oib = Pomocno.UcitajString(s.Oib + "Unesi promljenji oib predavača", "Unos obavezan" + s.Oib);
            //s.Iban = Pomocno.UcitajString(s.Iban + "Unesi promljenji Iban predavača", "Unos obavezan" + s.Iban);
            //IzbornikRadSaSmjerovima(); 

            int index = Pomocno.UcitajRasponBrojeva("Odaberi redni broj grupe: ", "Nije dobar odabir!", 1, Grupa.Count());
            var s = Grupa[index - 1];
            s.Sifra = Pomocno.UcitajCijeliBroj("Unesite šifra smjera (" + s.Sifra + "): ", "Unos mora biti pozitivni cijeli broj");
            s.Naziv  = Pomocno.UcitajString("Unesite naziv grupe: ",
                "Unos obavezan");
            s.Smjer = PostaviSmjer();
            s.Polaznici = PostaviPolaznike();
            s.DatumPocetka = Pomocno.UcitajDatum("Unesi datum grupe u formatu dd.MM.yyyy.", "Greška");
            Grupa.Add(s);

        }

        private void IzbrisiGrupu()
        {
            PrikaziSveGrupe();
            Grupa.RemoveAt(Pomocno.UcitajRasponBrojeva("Odaberi redni broj predavača: ", "Nije dobar odabir", 1, Grupa.Count()));
            IzbornikRadSaGrupama(); ;
        }







        //*****************POLAZNICI*****************//

        private void IzbornikRadSaPolaznicima()
        {
            Console.WriteLine("1. Prikaži sve polaznike: ");
            Console.WriteLine("2. Dodaj polaznika ");
            Console.WriteLine("3. Uredi polaznika ");
            Console.WriteLine("4. Izbriši polaznika ");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirStavkeIzbornikPolaznik();
        }

        private void OdabirStavkeIzbornikPolaznik()
        {
            switch (Pomocno.UcitajRasponBrojeva("Odaberite stavku izbornika polaznika: ",
                "Odabir mora biti 1-5", 1, 5))
            {
                case 1:
                    Console.WriteLine("Odabrali ste prikaz svih unesenih polazicima");
                    PrikaziSvePolaznike();
                    IzbornikRadSaPolaznicima();
                    break;
                case 2:
                    Console.WriteLine("Odabrali ste dodavanje predavača");
                    DodajNovogPolaznika();
                    break;
                case 3:
                    Console.WriteLine("Odabrali ste uređivanje predavača");
                    UrediPolaznika();
                    break;
                case 4:
                    Console.WriteLine("Odabrali ste brisanje predavača");
                    IzbrisiPolaznika();
                    break;
                case 5:
                    Console.WriteLine("Povratak na prethodni izbornik");
                    GlavniIzbornik();
                    break;
                default:
                    Console.WriteLine("Krivi odabir");
                    IzbornikRadSaPolaznicima();
                    break;
            };
        }

        private void PrikaziSvePolaznike()
        {
            var i = 0;
            Polaznici.ForEach(s =>
            {
                Console.WriteLine(++i + "." + s);
            });
            Console.WriteLine("**********************"); 
        }

        private void DodajNovogPolaznika()
        {
            Polaznici.Add(new Polaznik()
            {
                Sifra = Pomocno.UcitajCijeliBroj("Unesite šifra polaznika: ", "Unos mora biti pozitivni cijeli broj"),
                Ime = Pomocno.UcitajString("Unesi ime polaznika: ", "Unos obavezan"),
                Prezime = Pomocno.UcitajString("Unesite prezime polaznika: ", "Unos obavezan"),
                Email = Pomocno.UcitajString("Unesite polaznikov email:", "Unos obavezan"),
                Oib = Pomocno.UcitajString("Unesite polaznikov OiB: ", "Unos obavezan"),
                BrojUgovora = Pomocno.UcitajString("Unesite polaznikov broj ugovora: ", "Unos obavezan"),
            });
            IzbornikRadSaPolaznicima();
        }

        private void UrediPolaznika()
        {
            PrikaziSvePolaznike();
            int index = Pomocno.UcitajRasponBrojeva("Odaberi redni broj predavača: ", "Nije dobar odabir", 1, Polaznici.Count());
            var s = Polaznici[index - 1];
            s.Sifra = Pomocno.UcitajCijeliBroj("Unesite šifra smjera (" + s.Sifra + "): ", "Unos mora biti pozitivni cijeli broj");
            s.Ime = Pomocno.UcitajString(s.Ime + "Unesi  promljeneno ime predavača", "Unos obavezan" + s.Ime);
            s.Prezime = Pomocno.UcitajString(s.Prezime + "Unesi promljenjeno prezime predavača ", "Unos obavezan" + s.Prezime);
            s.Email = Pomocno.UcitajString(s.Email + "Unesi promljenjen Email predavača", "Unos obavezan" + s.Email);
            s.Oib = Pomocno.UcitajString(s.Oib + "Unesi promljenji oib predavača", "Unos obavezan" + s.Oib);
            s.BrojUgovora = Pomocno.UcitajString(s.BrojUgovora + "Unesi promljenji Iban predavača", "Unos obavezan" + s.BrojUgovora);
            IzbornikRadSaPolaznicima();
        }

        private void IzbrisiPolaznika()
        {
            PrikaziSvePolaznike();
            Polaznici.RemoveAt(Pomocno.UcitajRasponBrojeva("Odaberi redni broj predavača: ", "Nije dobar odabir", 1, Polaznici.Count()));
            IzbornikRadSaPolaznicima();
        }


        //*****************PREDAVAČI*****************//
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
            switch (Pomocno.UcitajRasponBrojeva("Odaberite stavku izbornika predavača: ",
                "Odabir mora biti 1-5", 1, 5))
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
                    UrediPredavaca();
                    break;
                case 4:
                    Console.WriteLine("Odabrali ste brisanje predavača");
                    UrediSmjer();
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
                Sifra = Pomocno.UcitajCijeliBroj("Unesite šifra predavaca: ", "Unos mora biti pozitivni cijeli broj"),
                Ime = Pomocno.UcitajString("Unesi ime predavaca: ", "Unos obavezan"),
                Prezime  = Pomocno.UcitajString ("Unesite prezime predavaca: ", "Unos obavezan"),
                Email = Pomocno.UcitajString ("Unesite predavačev email:", "Unos obavezan"),
                Oib = Pomocno.UcitajString("Unesite predavačev OiB:", "Unos obavezan"),
                Iban = Pomocno.UcitajString("Unesite predavačev Iban:", "Unos obavezan"),
            });
            IzbornikRadSaPredavacima(); 
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

        private void UrediPredavaca()
        {

            PrikaziSvePredavace();
            int index = Pomocno.UcitajRasponBrojeva("Odaberi redni broj predavača: ", "Nije dobar odabir", 1, Predavaci.Count());
            var s = Predavaci[index - 1];
            s.Sifra = Pomocno.UcitajCijeliBroj("Unesite šifra smjera (" + s.Sifra + "): ","Unos mora biti pozitivni cijeli broj");
            s.Ime = Pomocno.UcitajString(s.Ime + "Unesi  promljeneno ime predavača", "Unos obavezan" + s.Ime);
            s.Prezime = Pomocno.UcitajString(s.Prezime + "Unesi promljenjeno prezime predavača ", "Unos obavezan" + s.Prezime);
            s.Email = Pomocno.UcitajString(s.Email + "Unesi promljenjen Email predavača", "Unos obavezan" + s.Email);
            s.Oib = Pomocno.UcitajString(s.Oib + "Unesi promljenji oib predavača", "Unos obavezan" + s.Oib);
            s.Iban = Pomocno.UcitajString(s.Iban + "Unesi promljenji Iban predavača", "Unos obavezan" + s.Iban);
            IzbornikRadSaSmjerovima(); ;
        }


        private void IzbrisiPredavaca()
        {
            PrikaziSvePredavace();
            Predavaci.RemoveAt(Pomocno.UcitajRasponBrojeva("Odaberi redni broj predavača: ", "Nije dobar odabir", 1, Polaznici.Count()));
            IzbornikRadSaSmjerovima(); 
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

        //*****************SMJEROVI*****************//
        private void OdabriStavkeIzbornikSmjera()
        {
            switch (Pomocno.UcitajRasponBrojeva("Odaberite stavku izbornika polaznika: ",
                "Odabir mora biti 1-5", 1, 5))
            {
                case 1:
                    Console.WriteLine("Odabrali ste prikaz svih unesenih smjerova ");
                    PrikaziSveSmjerove();
                    IzbornikRadSaSmjerovima();
                    break;
                case 2:
                    Console.WriteLine("Odabrali ste dodavanje smjera ");
                    DodajNoviSmjer();
                    break;
                case 3:
                    Console.WriteLine("Odabrali ste uređivanje smjera ");
                    UrediSmjer();
                    break;
                case 4:
                    Console.WriteLine("Odabrali ste brisanje smjera ");
                    IzbrisiSmjer();
                    break;
                case 5:
                    Console.WriteLine("Povratak na prethodni izbornik ");
                    GlavniIzbornik();
                    break;
                default:
                    Console.WriteLine("Krivi odabir");
                    IzbornikRadSaSmjerovima();
                    break;
            }
        }

        private void DodajNoviSmjer()
        {

            Smjerovi.Add(new Smjer()
            {
                Sifra = Pomocno.UcitajCijeliBroj("Unesite šifra smjera: ", "Unos mora biti pozitivni cijeli broj"),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera: ", "Unos obavezan "),
                BrojSati = Pomocno.UcitajCijeliBroj("Unesi broj sati određenog smjera: ", "Unos mora biti cijeli broj"),
                Cijena = (float)Pomocno.UcitajDecimalniBroj("Unesite cijenu smjera: ", "Unos mora biti decimalni broj unesen s . "),
                Upisnina = (float)Pomocno.UcitajDecimalniBroj("Unesite iznos upisnine: ", "Unos mora biti decimalni broj unesen s . "),
                Verificiran = Pomocno.UcitajBool ("Smjer verificiran? Da ili bilo što drugo za ne: ")
                // ucitat ostale smjerove
            }); 
            IzbornikRadSaSmjerovima();
        }

        private void PrikaziSveSmjerove()
        {
            Console.WriteLine("**********************");
            var i = 0;
            Smjerovi.ForEach(s =>
            {
                Console.WriteLine(++i + "." + s);
            });
            Console.WriteLine("**********************");
        }

        private void UrediSmjer()
        {
            PrikaziSveSmjerove();
            int index = Pomocno.UcitajRasponBrojeva("Odaberi redni broj smjera: ", "Nije dobar odabir", 1, Smjerovi.Count());
            var s = Smjerovi[index- 1];
            s.Sifra = Pomocno.UcitajCijeliBroj("Unesite šifra smjera (" + s.Sifra + "): ",
                "Unos mora biti pozitivni cijeli broj");
            s.Naziv = Pomocno.UcitajString(s.Naziv + "Unesi promljenji naziv ", "Unos obavezan" + s.Naziv);
            s.BrojSati = Pomocno.UcitajCijeliBroj(s.BrojSati + "Unesite promljenjeni broj sati", "Unos mora biti pozitivni cijeli broj" + s.BrojSati);
            s.Cijena = (float)Pomocno.UcitajDecimalniBroj(s.Cijena + " Unesite promljenjenu cijenu", "Unos mora biti decimalni broj unesen s . ");
            s.Upisnina = (float)Pomocno.UcitajDecimalniBroj(s.Upisnina + "Unesite promljenu u iznosu upisnine", "Unos mora biti decimalni broj unesen s . ");
            s.Verificiran = Pomocno.UcitajBool(s.Verificiran + "Unesite promjenu u vertifikaciji smjera");

            IzbornikRadSaSmjerovima();
        }

        private void IzbrisiSmjer()
        {
            PrikaziSveSmjerove();
            Smjerovi.RemoveAt(Pomocno.UcitajRasponBrojeva("Odaberi redni broj smjera: ", "Nije dobar odabir", 1, Smjerovi.Count()));
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
