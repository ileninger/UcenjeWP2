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
        // i vraća razliku prvi+drugi i treći+četvrti
        // Koristite kreiranu metodu za zbroj dvaju brojeva

        [HttpGet]
        [Route("Zad2")]

        public int Zad2 (int PrviBroj,int DrugiBroj, int TreciBroj, int CetvrtiBroj) {

            return ((Zbroji(PrviBroj, DrugiBroj) - (Zbroji(TreciBroj, CetvrtiBroj))));
        
        }

        // Krierati rutu zad3 koja prima ime grada i slovo.
        // Ruta vraća broj pojavljivanja slova u primljenom imenu grada
        // Koristiti metode

        [HttpGet]
        [Route("Zad3")]

        public int Zad3 (string ImeGrada, char Slovo)
        {
            
            return Brojanje(ImeGrada,Slovo);
        }
        private int Brojanje (string Grad,char TrazenoSlovo)
        {
            int Rezultat = 0;
            foreach (char c in Grad)
            {
                if (Char.ToLower(c) == Char.ToLower(TrazenoSlovo))
                {
                    Rezultat++;
                }
            }
            return Rezultat;

        }

    }
}