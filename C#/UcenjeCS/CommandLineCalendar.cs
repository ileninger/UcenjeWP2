﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CommandLineCalendar
    {
        static void Wellcome()
        {
            string UserName = "Ivan";

            Console.WriteLine($"Wellcome back {UserName}");
            Console.WriteLine("Calendar is starting");
            Thread.Sleep(1500);
            DateTime DanasnjiDatum = DateTime.Now;
            Console.WriteLine($"Today is: {DanasnjiDatum:dd.MM.yyyy}");
            Console.WriteLine($"The current time is: {DanasnjiDatum:HH:mm}");
            Console.WriteLine("Calendar is starting");
            Thread.Sleep(1000);
            Console.WriteLine("What would you like to do?");
        }
        public static void Izvedi()
        {
            //In this project, we’ll build a basic calendar that the user will be able to interact with from the command line. 

            Wellcome();
            bool Start = true;
            string UserChoise;

            //string [] Calendar  

            while ( Start)
            {
                Console.WriteLine("Choise A to Add, U to Update, V to View, D to Delete, X to Exit: ");
                UserChoise = Console.ReadLine();
                UserChoise = UserChoise.ToUpper();

                // Sada odabiremo radnju ovisno o korisnikovom odabiru

                switch (UserChoise )
                {
                    case "X":
                    
                        Start = false;
                        break;

                    
                }
                
            }


        }
    }
}
