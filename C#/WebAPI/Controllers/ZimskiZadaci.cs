using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("ZimskiZadaci")]
    public class ZimskiZadaci : ControllerBase
    {

        [HttpPost]
        [Route("Zad1")]
        public int Zad1()
        {
           int Rezultat = 0;

            for (int i = 0;i<=100;i++)
            {
                Rezultat += i;
            }

            return Rezultat;
        }

        [HttpPost]
        [Route("Zad2")]

        public int [] Zad2()
        {
            int [] NizParnihBrojeva = new int[(58/2)];
            int index = 0;
            for (int i = 0; i <=57; i +=2)
            {
                NizParnihBrojeva[index] = i;
                index++;
            }
            return NizParnihBrojeva;
        }

        [HttpPost]
        [Route("Zad3")]

        public int Zad3() {
            int Rezultat = 0;

            for (int i =0; i<=18;i +=2)
            {
                Rezultat += i;

            }
            return Rezultat;
        }

        [HttpPost]
        [Route("Zad4")]
        public int Zad4(int PrviBroj) {
            int Rezultat = 0;
            for (int i = 0; i <= PrviBroj; i ++)
            {
                Rezultat += i;

            }
            return Rezultat;
        }


        [HttpPost]
        [Route("Zad5")]

        public int [] Zadtak5 (int PrviBroj, int DrugiBroj)
        {
            int[] NizParnihBrojeva = new int[DrugiBroj];
            int VelicinaNiza = 0;
            int index = 0;

            if (DrugiBroj > PrviBroj)
            {
                VelicinaNiza = (((DrugiBroj-PrviBroj)/2)+1);
                NizParnihBrojeva = new int[VelicinaNiza];
                for ( int i=PrviBroj; i<=DrugiBroj; i++)
                {
                    if (i%2==0)
                    {
                        NizParnihBrojeva[index++] = i;
                    }
                }
            } else
            {
                VelicinaNiza = (((Math.Abs(PrviBroj-DrugiBroj))/2)+1);
                NizParnihBrojeva = new int[VelicinaNiza];
                for( int i = DrugiBroj; i <=PrviBroj; i++)
                {
                    if (i % 2 == 0)
                    {
                        NizParnihBrojeva[index++] = i;
                    }
                }
            }
            return NizParnihBrojeva;
        }

        [HttpPost]
        [Route("Zad6")]

        public int[] Zad6 (int PrviBroj, int DrugiBroj)
        {
            int[] NizNeparanihBrojeva = new int[DrugiBroj];
            int index = 0;
            int VelicinaNiza = 0;

            if (DrugiBroj > PrviBroj)
            {
                VelicinaNiza = (((DrugiBroj - PrviBroj) / 2) + 1);
                NizNeparanihBrojeva = new int[VelicinaNiza];
                
                for (int i = PrviBroj; i <= DrugiBroj; i++)
                {
                    if (i % 2 != 0)
                    {
                        NizNeparanihBrojeva[index++] = i;
                    }
                } 
            } else
            {
                VelicinaNiza = ((PrviBroj-DrugiBroj)+1);
                NizNeparanihBrojeva = new int[VelicinaNiza];
                for (int i = DrugiBroj; i <= PrviBroj; i++)
                {
                    NizNeparanihBrojeva[index++] = i;
                }
            }
            return NizNeparanihBrojeva;
        }

        [HttpPost]
        [Route ("Zad7")]

        public int Zad7 (int PrviBroj, int DrugiBroj)
        {
            int Rezultat = 0;
            if (DrugiBroj > PrviBroj)
            {
                for (int i = PrviBroj; i <= DrugiBroj; i++)
                {
                    Rezultat += i;
                }
            } else
            {
                for (int i = DrugiBroj; i <= PrviBroj; i++)
                {
                    Rezultat += i;
                }
            }
            return Rezultat;
        }

        [HttpPost]
        [Route ("Zad8")]

        public int Zad8 (int PrviBroj, int DrugiBroj)
        {
            int Rezultat = 0;
            if (DrugiBroj > PrviBroj)
            {
                for (int i = PrviBroj; i <= DrugiBroj; i++)
                {
                    if (i%3 == 0)
                    {
                        Rezultat += i;
                    }
                }
            } else
            {
                for (int i = DrugiBroj; i <=PrviBroj; i++)
                {
                    if (i%3 == 0)
                    {
                        Rezultat += i;
                    }
                }
            }
            return Rezultat;
        }

        [HttpPost]
        [Route ("Zad9")]

        public int Zad9 (int PrviBroj, int DrugiBroj)
        {
            int Rezultat = 0;
            if (DrugiBroj > PrviBroj)
            {
                for (int i = PrviBroj; i <= DrugiBroj; i++)
                {
                    if ((i % 3 == 0) && (i % 5 ==0))
                    {
                        Rezultat += i;
                    }
                }
            }
            else
            {
                for (int i = DrugiBroj; i <= PrviBroj; i++)
                {
                    if ((i % 3 == 0) && (i % 5 == 0))
                    {
                        Rezultat += i;
                    }
                }
            }
            return Rezultat;
        }
        //10. Ruta prima dva parametra koji su cijeli brojevi i vraća dvodimenzionalni niz(matricu) koja sadrži tablicu množenja za dva primljena broja
        [HttpPost]
        [Route("Zad10")]

        public string Zad10(int PrviBroj, int DrugiBroj)
        {
            string[,] TablicaMnozenja = new string[PrviBroj, DrugiBroj]; //Niz koji cemo popunjavati
            StringBuilder MantricaTabliceMnozenjaZaPrikaz = new StringBuilder(); //StringBuilder prikaz matrice - manipulacija stringovima
            for (int i = 0; i < PrviBroj; i++)
            {
                for (int j = 0; j < DrugiBroj; j++)
                {
                    TablicaMnozenja[i, j] = ((i + 1) * (j + 1)).ToString();
                }
            }
            for (int i = 0; i < PrviBroj; i++)
            {
                for (int j = 0; j < DrugiBroj; j++)
                {
                    MantricaTabliceMnozenjaZaPrikaz.Append(TablicaMnozenja[i,j] + "\t"); //Appended spajanje
                }

                MantricaTabliceMnozenjaZaPrikaz.AppendLine(); // Promjena retka u matrici koja se prikazuje
            }
            return MantricaTabliceMnozenjaZaPrikaz.ToString();
        }

        [HttpPost]
        [Route("Zad11")]

        public int [] Zad11 (int Broj)
        {
            int[] NizBrojeva = new int[(Broj)];
            int Index = 0;
            for (int i = Broj; i >=1; i--)
            {
                NizBrojeva[Index++] = i;
            }
            return NizBrojeva;
        }

        [HttpPost]
        [Route ("Zad12")]

        public bool Zad12 (int Broj)
        {
            for (int i = 2; i < Broj; i++)
            {
                if (Broj % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        [HttpGet]
        [Route("Zad13")]

        public string Zad13(int Redovi, int Stupci)
        {
            int Brojac = 1; //Rezultat koji spremamo u matricu
                            // RedPocetak, RedKrajm StupacPocetak i StupacKraj definiraju rubne uvjete

            int RedPoc = 0, RedKraj = Redovi - 1;
            int KolPoc = 0, KolKraj = Stupci - 1;

            int[,] CiklickaMatica = new int[Redovi, Stupci]; // Ciklicku matticu spremamo u niz
            StringBuilder PrikazCiklickeMatrice = new StringBuilder(); //Ciklicka matrica za prikaz

            //if dok se ne popune sva mjesta u matrici

            if (RedPoc <= RedKraj && KolPoc <= KolKraj)
            {
                //Popunjavamo najdonji redak
                for (int j = KolKraj;  j >= KolPoc; j--) {
                    CiklickaMatica[RedKraj, j] = Brojac++;
                }
                RedKraj--;

                // Popinjavamo Lijevi stupac

                for (int i = RedKraj; i >= RedPoc; i--)
                {
                    CiklickaMatica[i, KolPoc] = Brojac++;
                }
                KolPoc++;

                // Popunjavamo gornji redak - moramo se osigurat da se gleda najgornji redak preko if-a
                if (RedPoc <= RedKraj)
                {
                    for (int j = KolPoc; j <=KolKraj; j++)
                    {
                        CiklickaMatica[RedPoc,j] = Brojac++;
                    }
                    RedPoc++;
                }

                // Popunjavamo desni stupac, osiguramo se preko if-a da dode na najzadnje slobodno mjesto

                if (KolPoc <= KolKraj)
                {
                    for (int i = RedPoc; i <=RedKraj; i++)
                    {
                        CiklickaMatica[i, KolKraj] = Brojac++;
                    }
                    KolKraj--;
                }
            }
          

            //Ispis matrice
            for (int i = 0; i<Redovi; i++)
            {
                for(int j = 0; j < Stupci; j++)
                {
                    PrikazCiklickeMatrice.Append(CiklickaMatica[i, j]+ "\t"); // prikaz stupaca
                }
                PrikazCiklickeMatrice.AppendLine();//Prikaz stupaca
            }
            return PrikazCiklickeMatrice.ToString(); 

        }

    }
}