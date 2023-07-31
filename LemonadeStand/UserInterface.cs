using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        public static int GetNumberOfPitchers()
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("Each pitcher pours 8 cups. How many pitchers would you like to make?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        public static bool StoreConfirmation()
        {
            bool userInputIsCorrectFormat = false;
            bool goShopping = false;

            while (!userInputIsCorrectFormat)
            {
                Console.WriteLine("Would you like to go shopping?\r\n");
                Console.WriteLine("Please answer by Yes  or No \r");

                var response = Console.ReadLine();

                if ("YES") 
                {
                    userInputIsCorrectFormat = true;
                    goShopping = true;
                }
                else if ("NO") 
                {
                    userInputIsCorrectFormat = true;
                    goShopping = false;
                }
                else
                {
                    Console.WriteLine("Please answer by Yes or No");
                }
            }

            return goShopping;
        }

    }
}