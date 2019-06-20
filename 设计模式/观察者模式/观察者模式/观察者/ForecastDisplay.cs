using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            display();
        }

        public void display()
        {
            Console.Write ("预测: ");
            if (currentPressure > lastPressure)
            {
                Console.Write("气温正在上升\n");
            }
            else if (currentPressure == lastPressure)
            {
                Console.Write("气温没有变化\n");
            }
            else if (currentPressure < lastPressure)
            {
                Console.Write("气温正变得凉爽\n");
            }
        }
    }
}
