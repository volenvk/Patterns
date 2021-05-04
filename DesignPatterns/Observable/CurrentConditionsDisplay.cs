using System;

namespace DesignPatterns.Observable
{
	public class CurrentConditionsDisplay : IObserv, IDisplayElement
	{
        private float _temperature;
		private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
        }

        public void Subscribe()
        {
            _weatherData.Register(this);
        }

        public void UnSubscribe()
        {
            _weatherData.Remove(this);
        }

		public void Update(float temp, float humidity, float pressure)
		{
			_temperature = temp;
            _humidity = humidity;
            Display();
		}

		public void Display()
		{
			Console.WriteLine($"Temperature: {_temperature} C, Humidity: {_humidity}%");
		}
	}
}
