using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V01")]
    public class ChrisamsTree : ControllerBase
    {

        [HttpGet]
        [Route("ChrismasTree")]
        public string ChrismasTree(int BrojRedaka)
        {
            string Str = "";
            for (int i = 1;i < BrojRedaka;i++)
            {
                for (int j = 1;j < BrojRedaka-i; j++)
                {
                    Str += " ";
                } for (int k = 1; k < 2*i-1; k++)
                {
                    Str += "*";
                }
                Str += "\n";
            }
            return Str;
        }

    }
}