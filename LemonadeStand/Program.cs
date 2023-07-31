namespace LemonadeStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Game game = new Game();
                game.Initialize();
                game.StartGame();

                Console.ReadLine();
            }

        }
    }
}