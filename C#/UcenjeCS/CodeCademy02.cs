using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CodeCademy02
    {
        public static void Izvedi()
        {
            //string name = "Shadow";
            //string breed = "Golden Retriever";
            //int age = 5;
            //double weight = 65.22;
            //bool spayed = true;

            //Console.WriteLine(name);
            //Console.WriteLine(breed);
            //Console.WriteLine(age);
            //Console.WriteLine(weight);
            //Console.WriteLine(spayed);

            //Console.Write("Enter your favorite number!: ");
            //int faveNumber = Convert.ToInt32(Console.ReadLine());

            //int pizzaShops = 4332;
            //int totalEmployees = 86928;
            //decimal revenue = 390819.28m;

            //Console.WriteLine(pizzaShops);
            //Console.WriteLine(totalEmployees);
            //Console.WriteLine(revenue);

            //int userAge=int.Parse(Console.ReadLine());
            //double jupiterYears = 11.86;

            //double jupiterAge = userAge / jupiterYears;

            //double journeyToJupiter = 6.142466;

            //double newEarthAge = userAge + journeyToJupiter;

            //double newJupiterAge = newEarthAge / jupiterYears;

            //Console.WriteLine(jupiterAge);
            //Console.WriteLine(newEarthAge);
            //Console.WriteLine(newJupiterAge);


            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Use built-in methods and save to variable 


            // Print the lowest number
            Console.WriteLine(Math.Min(numberOneSqrt,numberTwoSqrt));


        }
    }
}
