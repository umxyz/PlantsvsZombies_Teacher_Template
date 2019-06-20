using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者
{
    class Monitor : Colleage
    {
        public Monitor(string n):base(n)
        {

        }
        public override void Talk()
        {
            Console.WriteLine("班长大声说：" + this.Context);
        }
    }
}
