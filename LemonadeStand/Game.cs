using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand
{
    internal class Game
    {
        Store store;
        Player player;
        Weather weather;

        public Game()
        {
            store = new();
            player = new();
            weather = new();
        }

        public void OneShot()
        {
            Console.WriteLine("Game Started!");


            bool playing = true;

            while (playing)
            {
                player.DisplayInventory();

                store.OpenStore(player);

                playing = Continue();
            }
        }

        public static bool Continue()
        {
            bool userInputIsCorrectFormat = false;
            bool playing = false;

            while (!userInputIsCorrectFormat)
            {
                Console.WriteLine("Would you like to continue?");
                Console.WriteLine("Please answer by Yes or No");

                var response = Console.ReadLine();

                if (response == "YES")
                {
                    userInputIsCorrectFormat = true;
                    playing = true;
                }
                else if (response == "NO")
                {
                    userInputIsCorrectFormat = true;
                    playing = false;
                }
                else
                {
                    Console.WriteLine("Please answer by Yes  or No");
                }
            }

            return playing;
        }
    }
}
