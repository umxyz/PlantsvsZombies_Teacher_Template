using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelStrategy train = new TrainStrategy();
            TravelContext context = new TravelContext( "广州", "上海");
            context.SetStrategy(train);
            context.TravelFuction();

            TravelStrategy air = new AirStrategy();
            context.SetStrategy(air);
            context.TravelFuction();

            TravelContext context2 = new TravelContext2("广州", "上海", "最快");
            TravelStrategy walk = new WalkfastStrategy();
            context2.SetStrategy(walk);
            context2.TravelFuction();
            Console.ReadKey();
        }
    }
}
