using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建主题
            WeatherData weatherData = new WeatherData();
            //创建四观察者
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);
            //进行气象测量，主题的状态会因为测量值而改变
            weatherData.setMeasurements(80, 65, 30.4f);
            Console.WriteLine("");
            weatherData.setMeasurements(82, 70, 29.2f);
            Console.WriteLine("");
            weatherData.setMeasurements(78, 90, 29.2f);
            Console.WriteLine("");

            /*WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay =new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 29.2f);*/

            Console.ReadKey();
        }
    }
}
