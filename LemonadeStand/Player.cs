﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
        }

        // member methods (CAN DO)
        public void DisplayInventory()
        {
            var items = inventory.Display();
            Console.WriteLine("Here's your stock!");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Here's your money!");
            Console.WriteLine("Money : $" + wallet.Money + "");
        }
    }
}
