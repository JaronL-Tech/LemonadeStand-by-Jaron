using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Customer
{
    private double pricePerLemon;
    private double pricePerSugarCube;
    private double pricePerIceCube;
    private double pricePerCup;
    private double temperature; // Assume this variable holds the current temperature in Celsius.

    public Customer()
    {
        pricePerLemon = 0.5;
        pricePerSugarCube = 0.1;
        pricePerIceCube = 0.1;
        pricePerCup = 0.25;
        temperature = 37; // Default temperature, you can set this to the actual temperature in your application.
    }

    // Method to set the current temperature (you can call this method periodically to update the temperature).
    public void SetTemperature(double tempCelsius)
    {
        temperature = tempCelsius;
    }

    // Method to calculate the adjusted demand based on temperature and price.
    public double CalculateAdjustedDemand()
    {
        // Assuming the demand can range from 0.0 (no demand) to 1.0 (full demand).
        double demand = 1.0;

        // Temperature-based adjustment
        if (temperature > 30)
        {
            // If the temperature is above 30 degrees Celsius, increase demand by 10%.
            demand *= 1.1;
        }
        else if (temperature < 20)
        {
            // If the temperature is below 20 degrees Celsius, decrease demand by 10%.
            demand *= 0.9;
        }

        // Price-based adjustment
        // Add your price-based demand adjustments here if needed.

        return demand;
    }

    // Method to get the final price based on the adjusted demand and original prices.
    public double CalculateFinalPrice()
    {
        double adjustedDemand = CalculateAdjustedDemand();
        double finalPrice = (pricePerLemon + pricePerSugarCube + pricePerIceCube + pricePerCup) * adjustedDemand;
        return finalPrice;
    }
}

