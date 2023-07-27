using System;
namespace LemonadeStand
{
	public class Weather
	{
        //Member Variables (HAS A)
        public string condition;
        public int temperature;
        public string predictedForecast;
        private List<string> weatherConditions;


        // Constructor
        public Weather(string condition, double temperature, string forecast)
        {
            condition = condition;
            temperature = temperature;
            predictedForecast = forecast;
            weatherConditions = new List<string>();
        }

        //CAN DO

        // Method to add weather condition to the list
        public void AddWeatherCondition(string condition)
        {
            weatherConditions.Add(condition);
        }

        // Method to get a random weather condition from the list
        public string GetRandomWeatherCondition()
        {           
            Random random = new Random();
            int index = random.Next(0, weatherConditions.Count);
            return weatherConditions[index];
        }

        public void GetDayWeather()
        {
            // Creating a Weather instance for today
            Weather todayWeather = new Weather("Sunny", 25.5, "Clear skies");

            // Adding more weather conditions to the list
            todayWeather.AddWeatherCondition("Cloudy");
            todayWeather.AddWeatherCondition("Rainy");
            todayWeather.AddWeatherCondition("Snowy");

            // Randomly selecting and printing weather condition for today
            Console.WriteLine("Today's Weather: ");
            Console.WriteLine("Weather: " + todayWeather.GetRandomWeatherCondition());
            Console.WriteLine("Temperature: " + todayWeather.temperature + "°C");
            Console.WriteLine("Predicted Forecast: " + todayWeather.predictedForecast);
        }

    }
}

