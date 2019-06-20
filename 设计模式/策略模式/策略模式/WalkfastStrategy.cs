using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class WalkfastStrategy : TravelStrategy
    {
        public void Travel(TravelContext t)
        {
            TravelContext2 t2 = (TravelContext2)t;
            Console.WriteLine("从" + t2.Start + "到" + t2.End + t2.Way +"的步行方案");
        }
    }
}
