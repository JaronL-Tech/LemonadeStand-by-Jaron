using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        // member variables (HAS A)
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;

        // constructor (SPAWNER)
        public Store()
        {
            pricePerLemon = .5;
            pricePerSugarCube = .1;
            pricePerIceCube = .01;
            pricePerCup = .25;
        }

        public void OpenStore(Player player)
        {
            GoShopping(UserInterface.StoreConfirmation(), player);
        }

        // member methods (CAN DO)
        public void SellLemons(Player player)
        {
            int lemonsToPurchase = UserInterface.GetNumberOfItems("lemons");
            double transactionAmount = CalculateTransactionAmount(lemonsToPurchase, pricePerLemon);
            if (player.wallet.Money >= transactionAmount)
            {
                player.wallet.PayMoneyForItems(transactionAmount);
                player.inventory.AddLemonsToInventory(lemonsToPurchase);
            }
        }

        public void SellSugarCubes(Player player)
        {
            int sugarToPurchase = UserInterface.GetNumberOfItems("sugar");
            double transactionAmount = CalculateTransactionAmount(sugarToPurchase, pricePerSugarCube);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddSugarCubesToInventory(sugarToPurchase);
            }
        }

        public void SellIceCubes(Player player)
        {
            int iceCubesToPurchase = UserInterface.GetNumberOfItems("ice cubes");
            double transactionAmount = CalculateTransactionAmount(iceCubesToPurchase, pricePerIceCube);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddIceCubesToInventory(iceCubesToPurchase);
            }
        }

        public void SellCups(Player player)
        {
            int cupsToPurchase = UserInterface.GetNumberOfItems("cups");
            double transactionAmount = CalculateTransactionAmount(cupsToPurchase, pricePerCup);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddCupsToInventory(cupsToPurchase);
            }
        }

        private void GoShopping(bool goShopping, Player player)
        {
            if (goShopping)
            {

                bool userInputIsAnInteger = false;
                int typeofItem = -1;

                while (!userInputIsAnInteger)
                {
                    Console.WriteLine("What would you like to buy?");
                    Console.WriteLine("1: Cups");
                    Console.WriteLine("2: Ice Cubes");
                    Console.WriteLine("3: Lemons");
                    Console.WriteLine("4: Sugar Cubes");
                    Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                    userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out typeofItem);
                }

                switch (typeofItem)
                {
                    case 1:
                        Console.WriteLine("'Cups are on aisle 4'");
                        SellCups(player);
                        break;
                    case 2:
                        Console.WriteLine("'Ice Cubes are in the dispenser out front'");
                        SellIceCubes(player);
                        break;
                    case 3:
                        Console.WriteLine("'Take your lemons from the presentoir and come back to me.'");
                        SellLemons(player);
                        break;
                    case 4:
                        Console.WriteLine("'Don't put too much of 'em!'");
                        SellSugarCubes(player);
                        break;
                    default:
                        Console.WriteLine("'You walk out of the store, feeling guilty as if you've stolen something, even though you did nothing wrong!'");
                        break;
                }
            }
        }

        private double CalculateTransactionAmount(int itemCount, double itemPricePerUnit)
        {
            double transactionAmount = itemCount * itemPricePerUnit;
            return transactionAmount;
        }

        private void PerformTransaction(Wallet wallet, double transactionAmount)
        {
            wallet.PayMoneyForItems(transactionAmount);
        }
    }
}
