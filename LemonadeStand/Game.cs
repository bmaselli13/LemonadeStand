using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LemonadeStand
{
	public class Game
	{
        //HAS A

        private Player Player;
        private Wallet Wallet;
        private int currentDay; 
        private List<Day> days;
                
        //CONSTRUCTOR
        public Game()
        {
            this.Wallet = new Wallet();
                      
        }

        public void InitializeDays()
        {
            // Create instances of Day for each day, starting from "Day 1"
            currentDay = 0;

            //// Print the current number
            //Console.WriteLine(currentDay);

            // Increment the current number and loop back to 1 if it reaches 7
            currentDay = (currentDay % 7) + 1;

            Console.WriteLine($"\nDay {currentDay} begins!");
        }


        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("You have seven days to make as much money as you can\n" +
                "The weather, along with your pricing, can affect your success.\n" +
                "Can you make the big bucks?\n");
        }

                        
        //public void ShowWeatherForecast()
        //{
        //    Console.WriteLine($"Today's forecast: {weather.PredictedForecast}");
        //}


        //public void ShowWeatherActual()
        //{
        //    Console.WriteLine($"The weather for the day is: {weather.Condition}");
        //}


        public void RunGame()
        {
            //Display a message explaining the game
            WelcomeMessage();

            //Start the first day
            InitializeDays();

            //Display player’s inventory
            Wallet.CurrentWallet();

            //Player.GetInventory();

            //Display amount in wallet(money)
            //Wallet.CurrentWallet();

            //Display amount of lemons

            //Display amount of sugar cubes

            //Display amount of ice cubes

            //Display amount of cups

            //Allow user to go to store to purchase ingredients

            //Define in code price for each item to reduce in wallet

            //Give choice on how many items to purchase for each item in inventory

            //Reduce the amount in wallet(cash) based on purchases / amounts

            //Increase the amount in inventory based on purchases

            //Display current recipe based on inventory

            //Add choice to change recipe

            //If yes, add options to change item amounts

            //Display the weather forecast
            //ShowWeatherForecast();

            //Will be a random value

            //Based on what the weather will be, the demand for lemonade will be higher or lower

            //Display how many cups per pitcher there will be and how many pitchers user would like to make

            //Ask the price per cup

            //Display the details about the weather for the day including temp and whether sunny or cloudy
            //ShowWeatherActual();

            //Start day until sold out

            //If it is sold out, display “Sold Out!”

            //Display overview of the day including number of customers, cups sold, and total dollar amount made

            //Continue loop until you reach 7 days incrementing amount made by how many cups sold or until the user runs out of money

            //Display Synopsis of the whole week including money made or lost

        }

    }
}

