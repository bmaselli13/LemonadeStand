using System;
namespace LemonadeStand
{
	public class Day
	{
        public Weather weather;
        public Random randomNumber;
        public Recipe recipe;
        public List<Customer> customers;
        public UserInterface ui;

        public Day(Random randomNumber)
        {
            this.randomNumber = randomNumber;
            weather = new Weather(randomNumber);
            recipe = new Recipe();
            customers = new List<Customer>();
            ui = new UserInterface();
        }

        public void SellLemonade(Player player, Recipe recipe)
        {
            int sold;
            int pitcher;
            int pitcherEmpty;

            sold = 0;
            pitcher = 0;
            pitcherEmpty = 0;

            GenerateCustomers();

            for (int i = 0; i < customers.Count; i++)
            {
                customers[i].WillBuy(recipe);
            }

            // check if the customer will buy lemonade
            for (int i = 0; i < customers.Count; i++)
            {                

                if (customers[i].willBuy == true)
                {
                    // if pitcher is equal to 0 check:
                    if (pitcher == pitcherEmpty)
                    {
                        if (player.inventory.CheckLemons(player.inventory.lemons, recipe) &&
                           player.inventory.CheckSugar(player.inventory.cupsOfSugar, recipe) &&
                           player.inventory.CheckCups(player.inventory.cups) &&
                           player.inventory.CheckIce(player.inventory.iceCubes, recipe)
                          ) ;
                        else
                        {
                            ui.ShowSoldOutMessage();
                            break;
                        }
                    }

                    // if pitcher is not equal to zero
                    // check cups
                    // check ice
                    if (player.inventory.CheckCups(player.inventory.cups) && player.inventory.CheckIce(player.inventory.iceCubes, recipe))
                    {
                        // if both are true, remove both from inventory
                        player.inventory.cups.RemoveRange(0, 1);
                        player.inventory.iceCubes.RemoveRange(0, recipe.icePerCup);

                        player.cash += recipe.pricePerCup;
                        player.profit += recipe.pricePerCup;
                        sold++;
                        pitcher--;
                    }
                    else
                    {
                        ui.ShowSoldOutMessage();
                        break;
                    }
                }
            }
            ui.DisplaySoldCups(sold);
        }

        public void GenerateCustomers()
        {
            for (int i = 0; i < 100; i++)
            {
                Customer customer = new Customer(weather, randomNumber);
                customers.Add(customer);
            }
        }
    }
}

