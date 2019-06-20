using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryBMW320 factoryBMW320 = new FactoryBMW320();
            factoryBMW320.createEngine();
            factoryBMW320.createAircondition();

            //生产宝马523系列配件  
            FactoryBMW523 factoryBMW523 = new FactoryBMW523();
            factoryBMW523.createEngine();
            factoryBMW523.createAircondition();
            Console.ReadKey();
        }
    }
}
