using System;
using System.Security.Cryptography;

namespace LemonadeStand
{
	public class Day
	{
        public int DayNumber;
        public Weather Weather;
        public Wallet PlayerWallet;
        public List<Customer> customers;

        
        public Day(int DayNumber, Weather weather, Wallet playerWallet)
        {
            this.DayNumber = DayNumber;
            this.Weather = weather;
            Weather Weather = weather;
            this.PlayerWallet = playerWallet;
            
            
        }

        public int GetDayNumber()
        {
            return DayNumber;
        }

        public void ShowCupsPerPitcher()
        {
            Console.WriteLine($"Each pitcher pours {Weather.CupsPerPitcher} cups");
        }

        public int AskNumPitchersToMake()
        {
            Console.Write("How many pitchers of lemonade would you like to make? (Enter 0 to cancel): ");
            int numPitchers = int.Parse(Console.ReadLine());
            return numPitchers;
        }

        public double AskPricePerCup()
        {
            Console.Write("What price would you like to charge per cup for the day? ");
            double pricePerCup = double.Parse(Console.ReadLine());
            return pricePerCup;
        }

        public void SimulateDay()
        {
            // Simulate the day by showing messages for customer interactions and updating profits.
        }

        public void EndDay()
        {
            // Calculate and display profits for the day and update the player's wallet.
        }
    }
}

