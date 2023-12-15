namespace Lab17
{
    public class StatisticsDisplay : IObserver
    {
        private WeatherDataBase weatherData;
        private float maxTemperature;
        private float minTemperature;
        private float temperatureSum;
        private int numReadings = 0;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this);
        }

        public StatisticsDisplay(WeatherDataEvent weatherData)
        {
            this.weatherData = weatherData;
            weatherData.WeatherChanged += Update;
        }

        public void Update()
        {
            float temperature = weatherData.GetTemperature();
            temperatureSum += temperature;
            numReadings++;

            if (temperature > maxTemperature)
            {
                maxTemperature = temperature;
            }

            if (temperature < minTemperature)
            {
                minTemperature = temperature;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Значения по статистике: Средняя/Максимальная/Минимальная температура = " + (temperatureSum / numReadings) + "/" + maxTemperature + "/" + minTemperature);
        }
    }
}
