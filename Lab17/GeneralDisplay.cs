namespace Lab17
{
    public class GeneralDisplay : IObserver
    {
        private WeatherDataBase weatherData;

        public GeneralDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this);
        }

        public GeneralDisplay(WeatherDataEvent weatherData)
        {
            this.weatherData = weatherData;
            weatherData.WeatherChanged += Update;
        }

        public void Update()
        {
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Общие значения: " + weatherData.GetTemperature() + "градусов по Фаренгейту и " + weatherData.GetHumidity() + "% влажности");
        }
    }
}
