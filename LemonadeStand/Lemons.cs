using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    
     public void Lemons()
    {
        Console.WriteLine("Welcome to Lemonade Recipe Creator!Please enter the amount of lemons");

        Console.Write("Enter the number of lemons: ");
        int lemons = GetIntegerInput();
        Console.WriteLine($"Lemons: {lemons}");

    }
}