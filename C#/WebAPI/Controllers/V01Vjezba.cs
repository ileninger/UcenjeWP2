using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V01")]
    public class V01Vjezba : ControllerBase
    {

        [HttpGet]
        [Route("vjezba1")]
        public string vjezba1(int PrviBroj,int DrugiBroj, string Operator)
        {
            float Rezultat = 0;
            switch (Operator)
            {
                case "+":
                    Rezultat = PrviBroj+DrugiBroj; 
                    break;
                case "-":
                    Rezultat = PrviBroj-DrugiBroj;
                    break;
                case "*":
                    Rezultat = PrviBroj*DrugiBroj;
                    break;
                case "/":
                    if (DrugiBroj != 0)
                    {
                        Rezultat = PrviBroj / DrugiBroj;

                    } else
                    {
                        return "Nema djeljenja s nulom";
                    } 
                    break;
                default:
                    return "Niste unjeli dobar operator";
                }
            string RezultatString = Rezultat.ToString();
            return RezultatString;
        }

    }
}