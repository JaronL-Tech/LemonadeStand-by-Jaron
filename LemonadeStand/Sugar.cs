using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Sugar
    {
    }

    private static void Main()
    {
        Console.WriteLine("Welcome to Lemonade Recipe Creator!Please add the amount of sugar that you desire.");

        

        Console.Write("Enter the amount of sugar (in cups): ");
        int sugar = GetIntegerInput();

  
        Console.WriteLine($"Sugar (cups): {sugar}");
     
    }

}
