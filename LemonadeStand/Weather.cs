using System;
namespace LemonadeStand
{
	public class Weather
	{
        //HAS A
        public string PredictedForecast;
        public string Condition;
        public int Temperature;
        private List<string> WeatherConditions;
        public int CupsPerPitcher;

        //CONSTRUCTOR
        public Weather(string predictedForecast, int temperature, int cupsPerPitcher)
        {
            PredictedForecast = predictedForecast;
            Temperature = temperature;
            //WeatherConditions = weatherConditions;
            CupsPerPitcher = cupsPerPitcher;
        }

        //CAN DO

        public Weather GenerateRandomWeather()
        {
            Random random = new Random();
            string predictedForecast = "Sunny";
            int temperature = random.Next(70, 100); // Random temperature between 70 and 100 degrees Fahrenheit.
            List<string> weatherConditions = new List<string> { "Clear skies", "Sunny", "Warm", "Cloudy", "Cold", "Rainy" };
            int cupsPerPitcher = 8; // Assuming 8 cups per pitcher.

            
            Console.WriteLine($"\nToday's forecast: {predictedForecast}");
            return new Weather(predictedForecast, temperature, cupsPerPitcher);
        }

        
    }
}

