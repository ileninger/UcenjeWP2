using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V01")]
    public class RockPaperScissors : ControllerBase
    {
        private static readonly Random random = new Random();
        [HttpGet]

        public string playgame (string userChoise)
        {
            string[] choices = { "rock", "paper", "scissors" };
            string computerChoice = choices[random.Next(choices.Length)];
            if (userChoise == computerChoice)
            {
                return "It's a tie!!";
            }
            else if (
            (userChoise == "rock" && computerChoice == "scissors") ||
            (userChoise == "paper" && computerChoice == "rock") ||
            (userChoise == "scissors" && computerChoice == "paper")
            )
            {
                return "You win!";
            }
            else
            {
                return "Computer wins!";
            }

        }
    }
}