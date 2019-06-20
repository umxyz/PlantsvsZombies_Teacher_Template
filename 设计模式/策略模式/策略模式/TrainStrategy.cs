using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class TrainStrategy:TravelStrategy
    {
        public void Travel(TravelContext t)
        {
            Console.WriteLine("从" + t.Start + "到" + t.End + "的坐火车方案");
        }
    }
}
