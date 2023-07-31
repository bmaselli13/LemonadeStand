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
        public List<Day> days;
        Random randomNumber;
        public UserInterface ui;
        public Player player;
        public Store store;

        public Game()
        {
            days = new List<Day>();
            ui = new UserInterface();
            randomNumber = new Random();
            player = new Player();
            store = new Store();
        }

        public void Initialize()
        {
            ui.DisplayRules();
            int amountOfDays;

            
            // Creates day objects depending on user input and pushes them into a List
            for (int i = 0; i <= 7; i++)
            {
                days.Add(new Day(randomNumber));
            }
        }

        public void StartGame()
        {
            int indexOfDay;
            indexOfDay = 0;

            while (indexOfDay < days.Count)
            {
                ui.ShowCurrentDay(indexOfDay, days.Count);
                ui.DisplayWeather(days[indexOfDay].weather);
                
                // asks for recipe for the current day and save the number to a variable
                days[indexOfDay].recipe.SetQuantityOfIngredients(days[indexOfDay]);
                days[indexOfDay].SellLemonade(player, days[indexOfDay].recipe);
                indexOfDay++;
            }
            ui.DisplayAnalytics(player);
        }


    }
}