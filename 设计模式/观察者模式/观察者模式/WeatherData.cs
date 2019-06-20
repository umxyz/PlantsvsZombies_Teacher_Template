using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class WeatherData : ISubject
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private List<IObserver> observers;
        public float Temperature
        {
            get
            {
                return temperature;
            }
        }
        public float Humidity
        {
            get
            {
                return humidity;
            }
        }
        public float Pressure
        {
            get
            {
                return pressure;
            }
        }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void notifyObservers()
        {
            foreach (IObserver element in observers)
            {
                element.Update(Temperature, Humidity, Pressure);
            }
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.RemoveAt(i);
            }
        }
        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
        public void measurementsChanged()
        {
            notifyObservers();
        }
        
    }
}
