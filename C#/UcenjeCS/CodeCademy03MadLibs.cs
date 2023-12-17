using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CodeCademy03MadLibs
    {
        public static void Izvedi ()
        {
            //Mad Libs game from CodeCademy
            //02
            Console.WriteLine("Mad Libs is starting");
            //03
            string Title = "This is a storry";
            Console.WriteLine(Title);
            //04
            string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";
            Console.WriteLine("Enter a name:");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter frist adjectives:");
            string Adj1= Console.ReadLine();
            Console.WriteLine("Enter secund adjectives:");
            string Adj2 = Console.ReadLine();
            Console.WriteLine("Enter three adjectives:");
            string Adj3 = Console.ReadLine();

            Console.WriteLine("Enter the verb:");
            string Verb1= Console.ReadLine();

            Console.WriteLine("Enter frist noun:");
            string Nou1 = Console.ReadLine();

            Console.WriteLine("Enter secund noun:");
            string Nou2 = Console.ReadLine();

            Console.WriteLine("Enter the animal:");
            string Animal= Console.ReadLine();

            Console.WriteLine("Enter the food:");
            string Food = Console.ReadLine();

            Console.WriteLine("Enter the fruit");
            string Fruit= Console.ReadLine();

            Console.WriteLine("Enter the superhiro");
            string SuperHero = Console.ReadLine();

            Console.WriteLine("Enter the country");
            string Country = Console.ReadLine();

            Console.WriteLine("Enter the dessert");
            string Dessert = Console.ReadLine();

            Console.WriteLine("Enter the year");
            string Year = Console.ReadLine();

            story = $"This morning {Name} woke up feeling {Adj1}. 'It is going to be a {Adj2} day!' Outside, a bunch of {Animal}s were protesting to keep {Food} in stores. They began to {Verb1} to the rhythm of the {Nou1}, which made all the {Fruit}s very {Adj3}. Concerned, {Name} texted {SuperHero}, who flew {Name} to {Country} and dropped {Name} in a puddle of frozen {Dessert}. {Name} woke up in the year {Year}, in a world where {Nou2}s ruled the world.";
            Console.WriteLine(story);


        }
    }
}
