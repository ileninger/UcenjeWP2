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

        public IActionResult Zad5(int PrviBroj, int DrugiBroj)
        {
            if (DrugiBroj <= PrviBroj)
            {
                return BadRequest("Krivi unos, drugi broj mora biti veči od prvog");
            }
            List <int> NizParnihBrojeva = new List <int> ();
            for (int i = PrviBroj; i<=DrugiBroj; i++)
            {
                if (i % 2 == 0)
                {
                    NizParnihBrojeva.Add(i);
                }
            }
            return Ok(NizParnihBrojeva);
        }
        [HttpPost]
        [Route("Zad6")]

        public IActionResult Zad6(int PrviBroj, int DrugiBroj)
        {
            if (DrugiBroj <= PrviBroj)
            {
                return BadRequest("Krivi unos, drugi broj mora biti veči od prvog");
            }
            List<int> NizNeParnihBrojeva = new List<int>();
            for (int i = PrviBroj; i <= DrugiBroj; i++)
            {
                if (i % 2 != 0)
                {
                    NizNeParnihBrojeva.Add(i);
                }
            }
            return Ok(NizNeParnihBrojeva);

        }
    }
}