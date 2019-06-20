using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式
{
    class FactoryBMW523 : IAbstractFactory
    {
        public IAircondition createAircondition()
        {
            return new AirconditionB();
        }

        public IEngine createEngine()
        {
            return new EngineB();
        }
    }
}
