using Microsoft.AspNetCore.Mvc;

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
    }
}