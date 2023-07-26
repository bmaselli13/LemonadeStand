using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Recipe
    {
        // member variables (HAS A)
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;


        // constructor (SPAWNER)
        public Recipe()
        {
            amountOfLemons = 2;
            amountOfSugarCubes = 4;
            amountOfIceCubes = 10;
            pricePerCup = 1;
        }

        //Member Methods (CAN DO)
        public void DisplayRecipe()
        {
            Console.WriteLine($"Your recipe currently consists of:\n{amountOfLemons} lemons per pitcher\n{amountOfSugarCubes} sugar cubes per pitcher\n{amountOfIceCubes} ice cubes per pitcher");
        }

    }
}
