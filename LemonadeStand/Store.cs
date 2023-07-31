using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public UserInterface ui;
        public List<Ingredient> purchasedIngredients;

        public Store()
        {
            ui = new UserInterface();
            purchasedIngredients = new List<Ingredient>();
        }

        
        public void BuyIngredient(Player player, string ingredient)
        {
            if (ingredient == "cups")
            {
                PurchaseCups(player, ingredient);
            }
            else if (ingredient == "lemons")
            {
                PurchaseLemons(player, ingredient);
            }
            else if (ingredient == "sugar")
            {
                PurchaseSugar(player, ingredient);
            }
            else if (ingredient == "ice")
            {
                PurchaseIce(player, ingredient);
            }
            else
            {
                // call get recipe method
                ui.RecipeWelcomePage();
            }
        }

        // Method to purchase cups 
        public void PurchaseCups(Player player, string ingredient)
        {
            int quantity;
            double total;

            // display buying options
            // let user choose quantity
            quantity = ui.AskForCups();

            // sets price
            switch (quantity)
            {
                case 25:
                    total = .50;
                    break;
                case 50:
                    total = 1.00;
                    break;
                case 100:
                    total = 3.00;
                    break;
                default:
                    total = 0.0;
                    break;
            }

            // subtract price from player.cash
            player.cash = player.cash - total;

            // add price to player.cost
            player.cost = player.cost + total;

            // check if player has enough cash
            if (player.cash < 0)
            {
                Console.WriteLine("You ran out of money!");
                
            }

            // loop through creating as many objects as the user asked for
            for (int i = 0; i < quantity; i++)
            {
                player.inventory.cups.Add(new Cup());
            }

            ui.BackToStoreMenu();
            
        }

        // Method to purchase lemons
        public void PurchaseLemons(Player player, string ingredient)
        {
            int quantity;
            double total;

            // display buying options
            // let user choose quantity
            quantity = ui.AskForLemons();

            // sets price
            switch (quantity)
            {
                case 10:
                    total = .50;
                    break;
                case 30:
                    total = 2.00;
                    break;
                case 75:
                    total = 4.00;
                    break;
                default:
                    total = 0.0;
                    break;
            }

            // subtract price from player.cash
            player.cash = player.cash - total;

            // check if player has enough cash
            if (player.cash < 0)
            {
                Console.WriteLine("You ran out of money!");
                
            }

            // loop through creating as many objects as the user asked for
            for (int i = 0; i < quantity; i++)
            {
                player.inventory.lemons.Add(new Lemon());
            }

            ui.BackToStoreMenu();
            
        }

        // Method to purchase sugar
        public void PurchaseSugar(Player player, string ingredient)
        {
            int quantity;
            double total;

            // display buying options
            // let user choose quantity
            quantity = ui.AskForSugar();

            // sets price
            switch (quantity)
            {
                case 8:
                    total = .50;
                    break;
                case 20:
                    total = 1.00;
                    break;
                case 48:
                    total = 3.00;
                    break;
                default:
                    total = 0.0;
                    break;
            }

            // subtract price from player.cash
            player.cash = player.cash - total;

            // check if player has enough cash
            if (player.cash < 0)
            {
                Console.WriteLine("You ran out of money!");
                
            }

            // loop through creating as many objects as the user asked for
            for (int i = 0; i < quantity; i++)
            {
                player.inventory.cupsOfSugar.Add(new Sugar());
            }

            ui.BackToStoreMenu();
            
        }

        // Method to purchase ice
        public void PurchaseIce(Player player, string ingredient)
        {
            int quantity;
            double total;

            // display buying options
            // let user choose quantity
            quantity = ui.AskForIce();

            // sets price
            switch (quantity)
            {
                case 100:
                    total = .75;
                    break;
                case 250:
                    total = 2.00;
                    break;
                case 500:
                    total = 3.00;
                    break;
                default:
                    total = 0.0;
                    break;
            }

            // subtract price from player.cash
            player.cash = player.cash - total;

            // check if player has enough cash
            if (player.cash < 0)
            {
                Console.WriteLine("You ran out of money!");
                
            }

            // loop through creating as many objects as the user asked for
            for (int i = 0; i < quantity; i++)
            {
                player.inventory.iceCubes.Add(new Ice());
            }

            ui.BackToStoreMenu();
            
        }
    }
}
