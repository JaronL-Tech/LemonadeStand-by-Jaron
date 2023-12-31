﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;
        private double temperature; // Assume this variable holds the current temperature in Celsius.
        private double willingnessToPay;
        private double purchaseChance;

        public Customer(double willingnessToPay, double purchaseChance)
        {
            pricePerLemon = 0.5;
            pricePerSugarCube = 0.1;
            pricePerIceCube = 0.1;
            pricePerCup = 0.25;
            temperature = 37;
            this.willingnessToPay = willingnessToPay;
            this.purchaseChance = purchaseChance;
        }



        public void SetTemperature(double tempCelsius)
        {
            temperature = tempCelsius;
        }

        // Method to calculate the adjusted demand based on temperature and price.
        public double CalculateAdjustedDemand()
        {

            double demand = 1.0;


            if (temperature > 30)
            {

                demand *= 1.1;
            }
            else if (temperature < 20)
            {

                demand *= 0.9;
            }



            return demand;
        }


        public double CalculateFinalPrice()
        {
            double adjustedDemand = CalculateAdjustedDemand();
            double finalPrice = (pricePerLemon + pricePerSugarCube + pricePerIceCube + pricePerCup) * adjustedDemand;
            return finalPrice;
        }

        public bool DecideToBuy()
        {

            double randomValue = new Random().NextDouble();


            return randomValue <= purchaseChance;
        }


        public double GetWillingnessToPay()
        {
            return willingnessToPay;
        }

    }
}


