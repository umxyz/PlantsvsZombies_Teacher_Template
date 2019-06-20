using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式
{
    class EngineB:IEngine
    {
        public EngineB()
        {
            Console.WriteLine("制造-->EngineB");
        }
    }
}
