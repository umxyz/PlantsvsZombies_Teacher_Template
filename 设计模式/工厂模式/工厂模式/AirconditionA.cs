using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式
{
    class AirconditionA:IAircondition
    {
        public AirconditionA()
        {
            Console.WriteLine("制造-->AirconditionA");
        }
    }
}
