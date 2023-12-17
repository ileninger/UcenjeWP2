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


            //int numberOne = 12932;
            //int numberTwo = -2828472;

            //// Use built-in methods and save to variable 
            //double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));
            //double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            //// Use built-in methods and save to variable 


            //// Print the lowest number
            //Console.WriteLine(Math.Min(numberOneSqrt,numberTwoSqrt));

            //double numberOne = 6.5;
            //double numberTwo = 4;

            //// Raise numberOne to the numberTwo power
            //Console.WriteLine(Math.Pow(numberOne,numberTwo));

            //// Round numberOne up
            //Console.WriteLine(Math.Round(numberOne));

            //// Find the larger number between numberOne and numberTwo
            //Console.WriteLine();

            //string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";


            // Second string variable
            //string firstSpeech = "My dear Mr. Bennet," \"said his lady to him one day, \" "\have you heard that Netherfield Park is let at last ?\";


            //// Print variable and newline

            //Console.WriteLine(firstSentence);
            //Console.WriteLine("\n");
            //Console.WriteLine(firstSpeech);

            //string beginning = "Ovo je početak";
            //string middle = "Ovo je sredina";
            //string end = "Ovo je kraj";


            //// Concatenate the string and the variables
            //string story = beginning + middle + end;

            //// Print the story to the console 

            //Console.WriteLine(story);

            //string beginning = "Once upon a time,";
            //string middle = "The kid climbed a tree";
            //string end = "Everyone lived happily ever after.";

            //string story = $"{beginning} it was a beautiful day. {middle} and the birds flew through the sky. {end}";
            //Console.WriteLine(story);

            // Create password
            string password = "a92301j2add";

            //// Get password length
            //int passwordLength = password.Length;

            //Console.WriteLine(passwordLength);


            //// Check if password uses symbol
            //int passwordCheck = password.IndexOf("!");


            // Print results
            //.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");

            string startStrand = "ATGCGATGAGCTTAC";

            // find location of "tga"
            int tga = startStrand.IndexOf("TGA");

            // start point and stop point variables
            int startPoint = 0;
            int length = tga + 3;

            // define final strand
            string dna = startStrand.Substring(startPoint, length);
            Console.WriteLine(dna);

            // DNA mutation search
            Console.WriteLine(dna[3]);



        }
    }
}
