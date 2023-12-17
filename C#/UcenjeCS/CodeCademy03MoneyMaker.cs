using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CodeCademy03MoneyMaker
    {
        public static void Izvedi ()
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins:");
            string TotalAsString = Console.ReadLine();
            double TotalAsStringD = Convert.ToDouble(TotalAsString);
            Console.WriteLine($"{TotalAsString} cents is equal to...");
            int GoldValue = 10;
            int SilverValue = 5;
            double GoldCoints = Math.Floor( TotalAsStringD / GoldValue );
            double LeftFromGold = TotalAsStringD % GoldValue;


            double SilerCoints = Math.Floor(LeftFromGold / SilverValue);
            double BronzCoints = LeftFromGold % SilverValue;

            
            Console.WriteLine($"Gold coints {GoldCoints}" );
            Console.WriteLine($"Silver cooints {SilerCoints}");
            Console.WriteLine($"Bronze coints {BronzCoints}");

        }
    }
}
