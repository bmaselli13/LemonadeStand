using System;
namespace LemonadeStand
{
	public class Game
	{
		//Member Variables (HAS A)
		private Player player;
		private List<Day> days;
		private int currentDay;

        //Constructor
        public Game()
		{
					

			
		}

		//Methods CAN DO
		public void DisplayWelcome()
		{
			Console.WriteLine("Welcome to Lemonade Stand!\nYou have seven days to make as much money as you can.\nThe weather, along with your pricing, can affect your success.\nCan you make the big bucks?");
			
		}

		public void RunGame()
		{
			DisplayWelcome();
		}
    }
}

