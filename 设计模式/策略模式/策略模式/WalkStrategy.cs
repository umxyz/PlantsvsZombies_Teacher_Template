using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class WalkStrategy:TravelStrategy
    {
        public void Travel(TravelContext t)
        {
            Console.WriteLine("从" + t.Start + "到" + t.End + "的步行方案");
        }
    }
}
