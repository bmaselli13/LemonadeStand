using System;
namespace LemonadeStand
{
	public class Customer
	{

        public bool BuysLemonade;

        public Customer()
        {
            BuysLemonade = false;
        }

        public void DecideToBuy(int temperature, string weatherCondition, double pricePerCup)
        {
            
            // If the temperature is above 75 degrees, and it's sunny, and the price per cup is reasonable, the customer buys lemonade.

            // For demonstration purposes, let's assume the customer buys lemonade if the temperature is above 75 degrees and the price is $0.25 per cup.
            if (temperature > 75 && pricePerCup <= 0.25)
            {
                BuysLemonade = true;
            }
        }
    }
}

