using System;
using System.Collections.Generic;
namespace LemonadeStand
{
    public class Day : Weather
    {
        //Member Variables (HAS A)
        public Weather weather;
        public List<Customer> customers;
        List<string> days = new List<string>

            {
                "Day 1",
                "Day 2",
                "Day 3",
                "Day 4",
                "Day 5",
                "Day 6",
                "Day 7"
            };


        //Constructor
        //public Day(Weather weather, Customer customer)
        //{
        //    this.weather = new Weather(condition, temperature, predictedForecast);
            
        }

        //Methods CAN DO

        public void DisplayDay()
        {
            foreach (string day in days)
            {
                Console.WriteLine(day);
            }
        }
    }
}

