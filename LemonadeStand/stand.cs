using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Stand
    {
        private double pricePerGlass;
        private List<Customer> customers;

        public Stand()
        {
            pricePerGlass = 0.5;
            customers = new List<Customer>
        {

            new Customer(willingnessToPay: 0.6, purchaseChance: 0.8),
            new Customer(willingnessToPay: 0.7, purchaseChance: 0.6),
            new Customer(willingnessToPay: 0.4, purchaseChance: 0.9),

        };
        }


        public void MakeSale()
        {

            Customer customer = customers[new Random().Next(customers.Count)];


            if (customer.DecideToBuy())
            {

                double finalPrice = Math.Min(pricePerGlass, customer.GetWillingnessToPay());

                Console.WriteLine($"Sale: Customer willing to pay {customer.GetWillingnessToPay():C}, Final Price: {finalPrice:C}");
            }
            else
            {

                Console.WriteLine("Maybe next time");
            }
        }
    }
}
