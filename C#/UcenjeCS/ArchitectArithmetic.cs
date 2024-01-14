using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class ArchitectArithmetic
    {
        static double Rect(double length, double width)
        {
            return length * width;
        }

        static double Circle(double radius)
        {
            return (Math.PI * (radius * radius));
        }

        static double Triangle(double bottom, double height)
        {
            return (0.5*bottom*height);
        }
        public static void Izvedi() {
            
            double TotalArea = (Rect(1500,2500)) + (Triangle(750,500))+ ((Circle(375)/2));
            int PricePerArea = 180;
            double TotalPrice = TotalArea*PricePerArea;
            Console.WriteLine($"My plan costs:{Math.Round(TotalPrice,2)} pasos");

        }
    }
}
