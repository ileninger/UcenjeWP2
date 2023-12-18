using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CodeCademy03ChooseYouOwnAdventure
    {
        public static void Izvedi()
        {
            Console.Write("What is your name?: ");
            string Name = Console.ReadLine();
            Console.WriteLine($"Hello, {Name}! Welcome to our story.");

            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.WriteLine("Type YES or NO:");
            string NoiseChoice= Console.ReadLine();
            string NoiseChoiseUP = NoiseChoice.ToUpper();

            if (NoiseChoiseUP == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!\r\nTHE END.");
            }
            else if (NoiseChoiseUP =="YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\r\nYou walk towards it. Do you open it or knock?\r\n");
                Console.WriteLine("Type OPEN or KNOCK:");
                string DoorChoice = Console.ReadLine();
                String DoorChoiceUP = DoorChoice.ToUpper();

                if (DoorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"\r\n\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                    Console.WriteLine("Type your answer:");
                    string RiddleAnswer = Console.ReadLine();
                    string RiddleAnswerUP = RiddleAnswer.ToUpper();

                    if (RiddleAnswerUP == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there.\r\nYou turn off the light and run back to your room and lock the door.\r\nTHE END.\r\n");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.\r\nTHE END.\r\n");
                    }

                }
                else if (DoorChoice =="OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.WriteLine("Enter a number (1-3):");

                    string KeyChoice = Console.ReadLine();

                    switch (KeyChoice)
                    {
                        case ("1"):
                            Console.WriteLine("You choose the first key. Lucky choice!\r\nThe door opens and NOTHING is there. Strange...\r\nTHE END.");
                            break;
                        case ("2"):
                            Console.WriteLine("You choose the second key. The door doesn't open.\r\nTHE END.");
                            break;
                        case("3"):
                            Console.WriteLine("You choose the third key. The door doesn't open.\r\nTHE END.");
                            break;


                    }

                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            else
            {
                Console.WriteLine("Wrong input");

            }


            


        }
    }
}
