using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class SubSystemA
    {
        public void Method()
        {
            Console.WriteLine("执行子系统A");
        }
    }
    class SubSystemB
    {
        public void Method()
        {
            Console.WriteLine("执行子系统B");
        }
    }
    class SubSystemC
    {
        public void Method()
        {
            Console.WriteLine("执行子系统C");
        }
    }
}
