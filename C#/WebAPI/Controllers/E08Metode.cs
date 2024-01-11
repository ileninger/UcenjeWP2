using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E08")]
    public class E08Metode : ControllerBase
    {

        [HttpGet]
        [Route("Zad1")]
        public int Zad1(int PrviBroj, int DrugiBroj)
        {
            return (Zbroji(PrviBroj,DrugiBroj));
        } 
        private int Zbroji (int a, int b)
        {
            return (a + b);
        }

        // DZ
        // Krierati rutu zad2 koja prima 4 cijela broja
        // i vra?a razliku prvi+drugi i tre?i+?etvrti
        // Koristite kreiranu metodu za zbroj dvaju brojeva

        [HttpGet]
        [Route("Zad2")]

        public int Zad2 (int PrviBroj,int DrugiBroj, int TreciBroj, int CetvrtiBroj) {

            return ((Zbroji(PrviBroj, DrugiBroj) - (Zbroji(TreciBroj, CetvrtiBroj))));
        
        }
    }
}