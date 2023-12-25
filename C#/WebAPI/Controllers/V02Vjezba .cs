using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V02")]
    public class V02Vjezba : ControllerBase
    {

        [HttpPost]
        [Route("Vjezba2")]
        public float Vjezba2(float[] Niz)
        {
            float PrviBroj = Niz[0];
            float CijeliDioPrvogBroja =(int) (PrviBroj / 1);
            // Varijabla ZadnjiBroj Prima vrijednost zadnjeg elementa niza uz pomoc funkcije .Last()
            float ZadnjiBroj = Niz.Last();
            float DecimalniDioZadnjegBroja = (float)(ZadnjiBroj % 1);

            float Rezultat = CijeliDioPrvogBroja + DecimalniDioZadnjegBroja;

            return Rezultat;
        }

    }
}