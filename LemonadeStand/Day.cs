namespace LemonadeStand
{
    
    public class Day
    {
        public double Revenue 
        public double Expenses 
        public double DailyProfit => Revenue + Expenses;
    }

    class Day
    {
        static void Main(string[] args)
        {
            List<Day> days = new List<Day>();
            double totalProfit = 0.0;

            while (true)
            {
                Console.WriteLine("Enter the revenue for the day (positive value)");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double revenue))
                {
                    Console.WriteLine("Enter the expenses for the day (negative value):");
                    input = Console.ReadLine();

                    if (double.TryParse(input, out double expenses))
                    {
                        Day day = new Day { Revenue = revenue, Expenses = expenses };
                        days.Add(day);
                        totalProfit += day.DailyProfit;

                        Console.WriteLine($"Daily Profit/Loss: {day.DailyProfit:C}");
                        Console.WriteLine($"Total Profit/Loss: {totalProfit:C}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for expenses. Please enter a valid number.");
                    }
                }
                else if
                {
                    Console.WriteLine("Invalid input for revenue. Please enter a valid number.");
                }
            }
        }
    }
}