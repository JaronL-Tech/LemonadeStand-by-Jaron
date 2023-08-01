using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Icecube
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Lemonade Recipe Creator!Please enter the amount of Ice you will include.");

            Console.Write("Enter the number of ice cubes: ");
            int ice = GetIntegerInput();

           
            Console.WriteLine($"Ice cubes: {ice}");

            
        }

        private static int GetIntegerInput()
        {
            throw new NotImplementedException();
        }
    }
}
