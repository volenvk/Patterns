using System.Collections.Generic;
using System;

namespace DesignPatterns.Observable
{
	public class WeatherData : ISubject
	{
        private HashSet<IObserv> _observers = new HashSet<IObserv>();
        private float _temperature;
		private float _humidity;
        private float _pressure;

		public void Notify()
		{
			foreach (var o in _observers)
            {
                o.Update(_temperature, _humidity, _pressure);
            }
		}

		public void Register(IObserv o)
		{
			_observers.Add(o);
		}

		public void Remove(IObserv o)
		{
			_observers.Remove(o);
		}

        public void SetMeasurements(float temperature, float humidity, float pressure)
		{
			_temperature = temperature;
			_humidity = humidity;
			_pressure = pressure;
            Notify();
		}
	}
}
