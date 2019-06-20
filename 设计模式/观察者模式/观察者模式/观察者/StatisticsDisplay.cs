﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void display()
        {
            Console.WriteLine ("平均/最高/最低温度 = " + (tempSum / numReadings)
+ "/" + maxTemp + "/" + minTemp);

        }

        public void Update(float temp, float humidity, float pressure)
        {
            tempSum += temp;
            numReadings++;
            if (temp > maxTemp)
            {
                maxTemp = temp;
            }
            if (temp < minTemp)
            {
                minTemp = temp;
            }
            display();
        }
    }
}
