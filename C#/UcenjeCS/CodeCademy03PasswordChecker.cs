using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CodeCademy03PasswordChecker
    {
        public static object Tools { get; private set; }

        public static void Izvedi()
        {
                int MinLength = 8;
                string Uppercase = "ABCDEFGIJKLMNOPQRSTUVWXYZ";
                string Lowercase = "abcdefgijklmnopqrstuvwxyz";
                string Digits = "0123456789";
                string SpecialChars = "~!@#$%&€*+-";
                Console.WriteLine("Enter the password");
                string Passwords = Console.ReadLine();
                int Score = 0;
            
                if (Passwords.Length >= MinLength) {
                    Score++;
                }
                if (Tools.Contains(Passwords, Uppercase))
                {
                    Score++;
                }
                if (Tools.Contains(Passwords, Lowercase))
                {
                    Score++;

                }
                 if (Tools.Contains(Passwords, Digits))
                {
                    Score++;

                    }
                if (Tools.Contains(Passwords, SpecialChars))
                {
                    Score++;

                }
                switch (Score)
                {
                case 4:
                case 5:
                    Console.WriteLine("extremely strong password");
                    break;
                case 3:
                    Console.WriteLine("Pasword is strong");
                    break;
                case 2:
                    Console.WriteLine("password is medium");
                    break;
                case 1:
                    Console.WriteLine(" password is weak");
                default:
                    Console.WriteLine("the password doesn’t meet any of the standards");
                    break;


            }



        }
    }
}
