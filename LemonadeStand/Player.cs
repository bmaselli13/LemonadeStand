using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player 
    {
        //HAS A
        public string name;
        public Wallet wallet;
        public Inventory inventory;
        public Recipe recipe;

        //CONSTRUCTOR
        public Player(string name)
        {
            this.name = name;
            wallet = new Wallet();
            inventory = new Inventory();
            recipe = new Recipe();
        }

        //CAN DO

        
        public Wallet GetWallet()
        {
            return wallet;
        }

        public Inventory GetInventory()
        {
            return inventory;
        }

        public Recipe GetRecipe()
        {
            return recipe;
        }

    }
}
