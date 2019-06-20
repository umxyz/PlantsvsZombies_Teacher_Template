using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class Facade
    {
        private SubSystemA obj1 = new SubSystemA();
        private SubSystemB obj2 = new SubSystemB();
        private SubSystemC obj3 = new SubSystemC();
        public void Method()
        {
            obj1.Method();
            obj2.Method();
            obj3.Method();
        }
    }
}
