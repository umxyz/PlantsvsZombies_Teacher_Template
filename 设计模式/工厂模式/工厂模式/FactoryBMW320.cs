using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式
{
    class FactoryBMW320 : IAbstractFactory
    {
        public IAircondition createAircondition()
        {
            return new AirconditionA();
        }

        public IEngine createEngine()
        {
            return new EngineA();
        }
    }
}
