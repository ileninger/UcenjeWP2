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

        public int[] Zad5 (int PrviBroj, int DrugiBroj)
        {
            int index = 0;
            int[] NizParnihBrojeva;
            if (DrugiBroj < PrviBroj)
            {
                NizParnihBrojeva = new int[((DrugiBroj - PrviBroj)/2)];
                for (int i = PrviBroj; i <= DrugiBroj; i += 2)
                {
                    NizParnihBrojeva[index] = i;
                    index++;

                }
            }
            else
            {

            }
            return NizParnihBrojeva;
        }
    }
}