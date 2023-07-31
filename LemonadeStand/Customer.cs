using System;
namespace LemonadeStand
{
	public class Customer
	{

        public bool thirsty;
        public double acceptablePrice;
        public Random random;
        public bool willBuy;
        public Customer(Weather weather, Random random)
        {
            this.random = random;            
            CheckThirst(weather);
        }

                
        public void CheckThirst(Weather weather)
        {
            if (weather.temperature > 85)
            {
                if (random.Next(88, 101) > 90)
                {
                    thirsty = true;
                }
                else
                {
                    thirsty = false;
                }
            }
            else if (weather.temperature >= 54 && weather.temperature <= 84)
            {
                if (random.Next(75, 101) > 90)
                {
                    thirsty = true;
                }
                else
                {
                    thirsty = false;
                }
            }
            else
            {
                if (random.Next(50, 101) > 90)
                {
                    thirsty = true;
                }
                else
                {
                    thirsty = false;
                }
            }
        }

        // method determines weather a customer will buy or not
        public void WillBuy(Recipe recipe)
        {
            if (recipe.pricePerCup < acceptablePrice && thirsty == false)
            {
                if (random.Next(20, 101) > 75)
                {
                    willBuy = true;
                }
                else
                {
                    willBuy = false;
                }
            }
            else if (thirsty == true && recipe.pricePerCup > acceptablePrice)
            {
                if (random.Next(40, 101) > 75)
                {
                    willBuy = true;
                }
                else
                {
                    willBuy = false;
                }
            }
            else if (thirsty == true && recipe.pricePerCup < acceptablePrice)
            {
                willBuy = true;
            }
            else if (thirsty == false && recipe.pricePerCup > acceptablePrice)
            {
                willBuy = false;
            }
        }

    }
}

