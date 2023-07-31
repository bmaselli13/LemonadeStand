using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
           public UserInterface()
            {

            }

            public void DisplayRules()
            {
                Console.WriteLine("Welcome to Lemonade Stand Game!\n ");
                
            }

            public void DisplayWeather(Weather weather)
            {
                Console.WriteLine($"\nToday's weather is: {weather.forecast} with a high of {weather.temperature} degrees\n");
            }

            
            public void ShowCurrentDay(int day, int duration)
            {
                Console.WriteLine($"\nDay {day + 1} of {duration}");
            }

            public int AskForCups()
            {
                int quatity;
                string userInput;

                Console.WriteLine("\nHow many cups would you like purchase? (10 cups for $.50, 20 cups for $1, 50 cups for $3)");
                userInput = Console.ReadLine().ToLower().Trim();

                if (userInput == "10" || userInput == "20" || userInput == "50")
                {
                    quatity = int.Parse(userInput);
                    return quatity;
                }
                else
                {
                    Console.WriteLine("Please enter in an amount (10, 20, or 50)\n");
                    return AskForCups();
                }
            }

            public int AskForLemons()
            {
                int quatity;
                string userInput;

                Console.WriteLine("\nHow many lemons would you like to purchase? (10 lemons for $.50, 20 lemons for $2, 40 lemons for $4)");
                userInput = Console.ReadLine().ToLower().Trim();

                if (userInput == "10" || userInput == "20" || userInput == "40")
                {
                    quatity = int.Parse(userInput);
                    return quatity;
                }
                else
                {
                    Console.WriteLine("Please enter in an amount (10, 20 or 40)\n");
                    return AskForLemons();
                }
            }

            public int AskForSugar()
            {
                int quatity;
                string userInput;

                Console.WriteLine("\nHow much sugar would you like to purchase? (8 cups of sugar for $.50, 16 cups of sugar for $1, 30 cups of sugar for $3)");
                userInput = Console.ReadLine().ToLower().Trim();

                if (userInput == "8" || userInput == "16" || userInput == "30")
                {
                    quatity = int.Parse(userInput);
                    return quatity;
                }
                else
                {
                    Console.WriteLine("Please enter in an amount (8, 16 or 30)\n");
                    return AskForSugar();
                }
            }
            public int AskForIce()
            {
                int quatity;
                string userInput;

                Console.WriteLine("\nHow much ice would you like to purchase? (100 ice cubes for $.75, 250 ice cubes for $2, 500 ice cubes for $3)");
                userInput = Console.ReadLine().ToLower().Trim();

                if (userInput == "100" || userInput == "200" || userInput == "500")
                {
                    quatity = int.Parse(userInput);
                    return quatity;
                }
                else
                {
                    Console.WriteLine("Please enter in an amount (100, 200 or 500)\n");
                    return AskForIce();
                }
            }

            public void DisplayWelcomeMessage()
            {
                Console.WriteLine("Welcome To The Lemonade Stand Game!");
            }

            //public string DisplayStore()
            //{
            //    string userInput;

            //    Console.WriteLine("\nType in what you'd like to purchase. \n- cups\n- lemons\n- sugar\n- ice\n- finished(If you wish to not purchase any ingredients or you are complete with purchasing)");
            //    userInput = Console.ReadLine();
            //    userInput.ToLower().Trim();

            //    if (userInput == "cups" || userInput == "lemons" || userInput == "sugar" || userInput == "ice")
            //    {
            //        return userInput;
            //    }
            //    else if (userInput == "finished")
            //    {
            //        return "";
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter in one of the folllowing: cups, lemons, sugar, ice or finished\n");
            //        return DisplayStore();
            //    }
            //}

            public void DisplayPlayerInventory(Inventory inventory, Player player)
            {
                Console.WriteLine($"\nYou have: {player.cash.ToString("0.00")}\n" +
                  $"\nYour Inventory:" +
                  $"\nCups: {inventory.cups.Count} cups\n" +
                  $"Lemons: {inventory.lemons.Count} lemons\n" +
                  $"Sugar: {inventory.cupsOfSugar.Count} cups of sugar\n" +
                  $"Ice: {inventory.iceCubes.Count} ice cubes\n"
                  );
            }

            public void BackToStoreMenu()
            {
                Console.WriteLine("Press 'Enter' to return to the store menu");
                Console.ReadLine();
            }

            public void RecipeWelcomePage()
            {
                Console.WriteLine("\nThe current recipe is");
            }

            public int LemonsPerPitcher()
            {
                string lemonsPerPitcher;

                Console.WriteLine("\nHow many lemons would you like to add per pitcher?");
                lemonsPerPitcher = Console.ReadLine();

                try
                {
                    return int.Parse(lemonsPerPitcher);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nPlease enter a number");
                    return LemonsPerPitcher();
                }

            }

            public int IcePerCup()
            {
                string icePerCup;

                Console.WriteLine("How many ice cubes would you like to add per cup?");
                icePerCup = Console.ReadLine();

                try
                {
                    return int.Parse(icePerCup);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nPlease enter a number");
                    return IcePerCup();
                }
            }

            public int SugarPerPitcher()
            {
                string sugarPerPitcher;

                Console.WriteLine("\nHow much sugar would you like to add per pitcher?");
                sugarPerPitcher = Console.ReadLine();

                try
                {
                    return int.Parse(sugarPerPitcher);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nPlease enter a number");
                    return SugarPerPitcher();
                }
            }

            public double PricePerCup()
            {
                string pricePerCup;

                Console.WriteLine("Enter in the price per cup:");
                pricePerCup = Console.ReadLine();

                try
                {
                    return double.Parse(pricePerCup);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nPlease enter a number");
                    return PricePerCup();
                }
            }

            public void DisplaySoldCups(int soldCups)
            {
                Console.WriteLine($"\nYou sold {soldCups} cups of lemonade today!\n");
            }

            public void ShowSoldOutMessage()
            {
                Console.WriteLine("SOLD OUT");
            }

            public void DisplayAnalytics(Player player)
            {
                Console.WriteLine($"\nProfits: {player.CalculateProfit().ToString("0.00")} \nMoney Made: {player.cash} \nSpent: {player.cost}");
            }
        }
}
